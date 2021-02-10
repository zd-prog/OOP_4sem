using System;
using System.Data;
using System.Windows.Forms;

namespace Lab_1
{
    interface IOperations
    {
        int plus(int b);
        int minus(int b);
        int multiply(int b);
        int devide(int b);
        int percent(int b);
        void memory_in(int b);
        void memory_clear();
    }
    class Calculator : IOperations
    {
        private int a = 0;
        public int memory = 0;
        public int devide(int b)
        {
            return a / b;
        }

        public int minus(int b)
        {
            return a - b;
        }

        public int multiply(int b)
        {
            return a * b;
        }

        public int percent(int b)
        {
            return a % b;
        }

        public int plus(int b)
        {
            return a + b;
        }

        public void memory_in(int a)
        {
            memory = a;
        }

        public void memory_clear()
        {
            memory = 0;
        }
        public delegate void DelHandler(string message);
        DelHandler handler;
        public void RegisterDelegate(DelHandler handl)
        {
            handler = handl;
        }
        public void Error_is()
        {
            if (handler != null)
                handler("Поле примера не было заполнено");
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
