using System;
namespace process_manager
{
    public class Process
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Size { get; set; }
        public double Percentage { get; set; } = 1;
        public Gtk.Button Button { get; set; }

        public Process P1(Gtk.Button button)
        {
            return new Process
            {
                Name = "P1",
                Time = 23,
                Size = 118,
                Button = button,

            };
        }

        public Process P2(Gtk.Button button)
        {
            return new Process
            {
                Name = "P2",
                Time = 20,
                Size = 100,
                Button = button
            };
        }

        public Process P3(Gtk.Button button)
        {
            return new Process
            {
                Name = "P3",
                Time = 21,
                Size = 105,
                Button = button
            };
        }

        public Process P4(Gtk.Button button)
        {
            return new Process
            {
                Name = "P4",
                Time = 22,
                Size = 110,
                Button = button
            };
        }

        public Process P5(Gtk.Button button)
        {
            return new Process
            {
                Name = "P5",
                Time = 19,
                Size = 98,
                Button = button
            };
        }

        public Process P6(Gtk.Button button)
        {
            return new Process
            {
                Name = "P6",
                Time = 18,
                Size = 93,
                Button = button
            };
        }

        public Process P7(Gtk.Button button)
        {
            return new Process
            {
                Name = "P7",
                Time = 25,
                Size = 125,
                Button = button
            };
        }

        public Process P8(Gtk.Button button)
        {
            return new Process
            {
                Name = "P8",
                Time = 26,
                Size = 128,
                Button = button
            };
        }
    }
}
