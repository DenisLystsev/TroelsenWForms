using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinFormsApp
{
    //c 5
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MainWindow("Новое окно", 700, 400));
        }
    }

    //Главное окно
    class MainWindow : Form
    {
        public MainWindow() { }
        public MainWindow(string title, int width, int height)
        {
            Text = title;
            Width = width;
            Height = height;

            //Вывод в центре экрана
            CenterToScreen();
        }
    }
}
