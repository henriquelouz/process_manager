using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Gdk;
namespace process_manager
{
    public partial class ControlPanel : Gtk.Window
    {
        private Gtk.ListStore ProcessList;
        private Gtk.ListStore SwapList;
        private Thread RAMTicker;
        private char kind;
        private double step;
        private bool firstRun = true;
        private Process processLib = new Process();
        List<Process> processListControl;

        public ControlPanel(char kind) : base(Gtk.WindowType.Toplevel)
        {
            this.kind = kind;
            processListControl = new List<Process>();

            Build();
            BuildRAM();
            BuildSwap();
            RAMTicker = new Thread(Tick);

            ModifyBg(Gtk.StateType.Normal, new Color(255, 255, 255));
            if (kind == 'F')
                Title = Title + " - FCFS";
            else if (kind == 'R')
            {
                frmQuantum.Visible = true;
                Title = Title + " - RR";
            }
        }

        protected void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
        {
            RAMTicker.Abort();
            this.Hide();
            Kind k = new Kind();
            k.Show();
        }

        protected void BuildRAM()
        {
            ProcessList = new Gtk.ListStore(typeof(string), typeof(string), typeof(string));
            RAM.Model = ProcessList;

            Gtk.CellRendererText ProcesscellView = new Gtk.CellRendererText();
            var process = new Gtk.TreeViewColumn("Process", ProcesscellView);
            process.AddAttribute(ProcesscellView, "text", 0);
            RAM.AppendColumn(process);

            Gtk.CellRendererText TimeCellView = new Gtk.CellRendererText();
            var time = new Gtk.TreeViewColumn("Time", TimeCellView);
            time.AddAttribute(TimeCellView, "text", 1);
            RAM.AppendColumn(time);

            Gtk.CellRendererText SizeCellView = new Gtk.CellRendererText();
            var size = new Gtk.TreeViewColumn("Size", SizeCellView);
            size.AddAttribute(SizeCellView, "text", 2);
            RAM.AppendColumn(size);
        }


        protected void BuildSwap()
        {
            SwapList = new Gtk.ListStore(typeof(string), typeof(string), typeof(string));
            Swap.Model = SwapList;

            Gtk.CellRendererText ProcesscellView = new Gtk.CellRendererText();
            var process = new Gtk.TreeViewColumn("Process", ProcesscellView);
            process.AddAttribute(ProcesscellView, "text", 0);
            Swap.AppendColumn(process);

            Gtk.CellRendererText TimeCellView = new Gtk.CellRendererText();
            var time = new Gtk.TreeViewColumn("Time", TimeCellView);
            time.AddAttribute(TimeCellView, "text", 1);
            Swap.AppendColumn(time);

            Gtk.CellRendererText SizeCellView = new Gtk.CellRendererText();
            var size = new Gtk.TreeViewColumn("Size", SizeCellView);
            size.AddAttribute(SizeCellView, "text", 2);
            Swap.AppendColumn(size);
        }

        protected void Tick()
        {
            double qtVal = quantum.Value;
            while (true)
            {
                Thread.Sleep(1000);
                if (kind == 'F')
                {
                    Gtk.TreeIter iter;
                    ProcessList.GetIterFirst(out iter);
                    string time = ProcessList.GetValue(iter, 1).ToString();

                    int newTime = int.Parse(time) - 1;
                    CPU.Fraction -= step;

                    if (newTime == 0)
                    {
                        ProcessList.Remove(ref iter);
                        Process p = processListControl[0];
                        processListControl.RemoveAt(0);

                        p.Button.Visible = true;
                        GetCancelButton(p.Button).Visible = false;

                        RAMSpace.Fraction -= (double)p.Size / 1024;
                        RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) - p.Size).ToString() + "/820 (1024) MB";

                        TryFit();

                        if (ProcessList.IterNChildren() == 0)
                        {
                            RAMTicker.Suspend();
                        }
                        else
                        {
                            CPU.Fraction = 1;

                            ProcessList.GetIterFirst(out iter);
                            string nextTime = ProcessList.GetValue(iter, 1).ToString();

                            step = 1 / double.Parse(nextTime);
                        }

                        continue;
                    }
                    ProcessList.SetValue(iter, 1, newTime.ToString());
                }
                else if (kind == 'R')
                {
                    Gtk.TreeIter iter;
                    ProcessList.GetIterFirst(out iter);
                    Process p = processListControl[0];
                    string time = ProcessList.GetValue(iter, 1).ToString();

                    if (qtVal > 0)
                    {
                        int newTime = int.Parse(time) - 1;
                        CPU.Fraction -= step;
                        p.Percentage -= step;

                        qtVal--;
                        if (newTime == 0)
                        {
                            processListControl.RemoveAt(0);
                            ProcessList.Remove(ref iter);
                            p.Button.Visible = true;
                            GetCancelButton(p.Button).Visible = false;

                            RAMSpace.Fraction -= (double)p.Size / 1024;
                            RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) - p.Size).ToString() + "/820 (1024) MB";

                            TryFit();

                            qtVal = quantum.Value;
                            if (ProcessList.IterNChildren() == 0)
                            {
                                frmQuantum.Sensitive = true;
                                RAMTicker.Suspend();
                            }
                            else
                            {
                                p = processListControl[0];
                                CPU.Fraction = p.Percentage;

                                ProcessList.GetIterFirst(out iter);
                                string nextTime = ProcessList.GetValue(iter, 1).ToString();

                                step = p.Percentage / double.Parse(nextTime);
                            }

                            continue;
                        }
                        ProcessList.SetValue(iter, 1, newTime.ToString());
                    }
                    else
                    {
                        qtVal = quantum.Value;

                        string process = ProcessList.GetValue(iter, 0).ToString();
                        string size = ProcessList.GetValue(iter, 2).ToString();
                        ProcessList.Remove(ref iter);
                        ProcessList.InsertWithValues(ProcessList.IterNChildren(), process, time, size);

                        if (processListControl.Count > 1)
                        {
                            processListControl.Add(processListControl[0]);
                            processListControl.RemoveAt(0);
                        }

                        if (ProcessList.IterNChildren() == 0)
                        {
                            frmQuantum.Sensitive = true;
                            RAMTicker.Suspend();
                        }
                        else
                        {
                            ProcessList.GetIterFirst(out iter);
                            string nextTime = ProcessList.GetValue(iter, 1).ToString();

                            p = processListControl[0];
                            CPU.Fraction = p.Percentage;
                            step = p.Percentage / double.Parse(nextTime);
                        }
                    }
                }
            }
        }

        protected void ProcessEnqueue(Process p)
        {
            if (RAMSpace.Fraction + ((double)p.Size / 1024) > 1)
            {
                Gtk.TreeIter iter;
                ProcessList.IterNthChild(out iter, ProcessList.IterNChildren() - 1);
                string leavingSize = ProcessList.GetValue(iter, 2).ToString();

                SwapList.InsertWithValues(
                    SwapList.IterNChildren(),
                    ProcessList.GetValue(iter, 0).ToString(),
                    ProcessList.GetValue(iter, 1).ToString(),
                    leavingSize
                );

                RAMSpace.Fraction -= double.Parse(ProcessList.GetValue(iter, 2).ToString()) / 1024;
                ProcessList.Remove(ref iter);

                processListControl.RemoveAt(processListControl.Count - 1);

                RAMSpace.Fraction += (double)p.Size / 1024;
                RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) - int.Parse(leavingSize) + p.Size).ToString() + "/820 (1024) MB";


            }
            else
            {
                RAMSpace.Fraction += (double)p.Size / 1024;
                RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) + p.Size).ToString() + "/820 (1024) MB";
            }


            p.Button.Visible = false;
            GetCancelButton(p.Button).Visible = true;
            processListControl.Add(p);


            if (ProcessList.IterNChildren() == 0)
            {
                CPU.Fraction = 1;
                step = 1 / (double)p.Time;
            }

            ProcessList.InsertWithValues(ProcessList.IterNChildren(), p.Name, p.Time.ToString(), p.Size.ToString());

            if (firstRun)
            {
                frmQuantum.Sensitive = false;
                RAMTicker.Start();
                firstRun = false;
                return;
            }

            if (RAMTicker.ThreadState == ThreadState.Suspended)
            {
                frmQuantum.Sensitive = false;
                RAMTicker.Resume();
            }
        }

        protected void OnBtnP1Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P1(btnP1));
        }

        protected void OnBtnP2Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P2(btnP2));
        }

        protected void OnBtnP3Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P3(btnP3));
        }

        protected void OnBtnP4Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P4(btnP4));
        }

        protected void OnBtnP5Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P5(btnP5));
        }

        protected void OnBtnP6Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P6(btnP6));
        }

        protected void OnBtnP7Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P7(btnP7));
        }

        protected void OnBtnP8Clicked(object sender, EventArgs e)
        {
            ProcessEnqueue(processLib.P8(btnP8));
        }

        protected Gtk.Button GetProcessButton(string pName)
        {
            switch (pName)
            {
                case "P1":
                    return btnP1;
                case "P2":
                    return btnP2;
                case "P3":
                    return btnP3;
                case "P4":
                    return btnP4;
                case "P5":
                    return btnP5;
                case "P6":
                    return btnP6;
                case "P7":
                    return btnP7;
                default:
                    return btnP8;
            }
        }

        protected Gtk.Button GetCancelButton(Gtk.Button btn)
        {
            if (btn == btnP1)
                return cnclP1;
            else if (btn == btnP2)
                return cnclP2;
            else if (btn == btnP3)
                return cnclP3;
            else if (btn == btnP4)
                return cnclP4;
            else if (btn == btnP5)
                return cnclP5;
            else if (btn == btnP6)
                return cnclP6;
            else if (btn == btnP7)
                return cnclP7;
            return cnclP8;
        }

        protected void OnCnclP1Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP1);
        }

        protected void OnCnclP2Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP2);
        }

        protected void OnCnclP3Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP3);
        }

        protected void OnCnclP4Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP4);
        }

        protected void OnCnclP5Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP5);
        }

        protected void OnCnclP6Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP6);
        }

        protected void OnCnclP7Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP7);
        }

        protected void OnCnclP8Clicked(object sender, EventArgs e)
        {
            CancelProcess(btnP8);
        }

        protected void CancelProcess(Gtk.Button btn)
        {
            Gtk.TreeIter iter;
            int index = processListControl.FindIndex(p => p.Name == btn.Label);
            ProcessList.IterNthChild(out iter, index);

            if (index > 0)
            {
                RAMSpace.Fraction -= (double)processListControl[index].Size / 1024;
                RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) - processListControl[index].Size).ToString() + "/820 (1024) MB";

                ProcessList.Remove(ref iter);
                processListControl.RemoveAt(index);
                TryFit();
            }
            else if (index < 0)
            {
                SwapList.GetIterFirst(out iter);
                SwapList.Remove(ref iter);
            }
            else
            {
                ProcessList.SetValue(iter, 1, "1");
                TryFit();
            }
            btn.Visible = true;
            GetCancelButton(btn).Visible = false;
        }

        protected void TryFit()
        {
            Gtk.TreeIter iter;
            SwapList.GetIterFirst(out iter);

            if (
                SwapList.IterNChildren() > 0 &&
                RAMSpace.Fraction + (double.Parse(SwapList.GetValue(iter, 2).ToString()) / 1024) < 1
            )
            {
                string swapName = SwapList.GetValue(iter, 0).ToString();
                int swapTime = int.Parse(SwapList.GetValue(iter, 1).ToString());
                int swapSize = int.Parse(SwapList.GetValue(iter, 2).ToString());

                ProcessList.InsertWithValues(ProcessList.IterNChildren(), swapName, swapTime.ToString(), swapSize.ToString());
                SwapList.Remove(ref iter);
                processListControl.Add(new Process() { Name = swapName, Time = swapTime, Size = swapSize, Button = GetProcessButton(swapName) });

                RAMSpace.Fraction += (double)swapSize / 1024;
                RAMSpace.Text = (int.Parse(RAMSpace.Text.Split('/')[0]) + swapSize).ToString() + "/820 (1024) MB";
            }
        }
    }
}
