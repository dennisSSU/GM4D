using System;
using System.Collections.Generic;


namespace GM4D
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller ctrl;
            ctrl = new GM4D.Controller();
            ctrl.Run();
        }
    }
}
