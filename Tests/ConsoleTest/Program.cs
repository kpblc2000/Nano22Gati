using ConsoleTest.Infrastructure;
using Nano22GatiCore.ViewModels;
using Nano22GatiCore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleTest
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CadRepository cadRep = new CadRepository();
            GatiWindowViewModel viewModel = new GatiWindowViewModel(cadRep, new MessageService());
            GatiWindow win = new GatiWindow()
            {
                DataContext = viewModel,
            };

            win.ShowDialog();
            //cadRep.ShowModalWindow(win);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
