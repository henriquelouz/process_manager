using System;
using Gtk;

namespace process_manager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Kind kind = new Kind();
            kind.Show();
            Application.Run();
        }
    }
}
