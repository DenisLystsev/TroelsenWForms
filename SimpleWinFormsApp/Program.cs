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
        //Члены для простой системы меню
        private MenuStrip MainMenu = new MenuStrip();
        private ToolStripMenuItem tsmiFile = new ToolStripMenuItem();
        private ToolStripMenuItem tsmiFileExit = new ToolStripMenuItem();

        public MainWindow() { }
        public MainWindow(string title, int width, int height)
        {
            Text = title;
            Width = width;
            Height = height;

            //Вывод в центре экрана
            CenterToScreen();

            //Создаем систему меню
            BuildMenuSystem();
        }

        private void BuildMenuSystem()
        {
            //Добавить в главное меню пункт Файл
            tsmiFile.Text = "Файл";
            MainMenu.Items.Add(tsmiFile);
            //Добавить в меню Файл пункт Выход
            tsmiFileExit.Text = "Выход";
            tsmiFile.DropDownItems.Add(tsmiFileExit);
            tsmiFileExit.Click += (o, s) => Application.Exit();
            //Установить меню для этой формы
            Controls.Add(this.MainMenu);
            MainMenuStrip = this.MainMenu;
        }
    }
}
