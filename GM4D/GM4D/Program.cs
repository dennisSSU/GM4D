using System;
using System.Collections.Generic;
/* 
 * Filename: Programm.cs
 * Author: Dennis Stodko
 * Date: 2015
 * Description: entry point for the applcation, creates the main Controller object 
 */

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
