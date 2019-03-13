using Containervervoer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containervervoer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Testing purpose
            TestClass testClass = new TestClass();
            Ship ship = new Ship(2,2);
            ship.CheckPossibilityForSolution(testClass.Setup());



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConatainerVervoerForm());

            

        }
    }
}
