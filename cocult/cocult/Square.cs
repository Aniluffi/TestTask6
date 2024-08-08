using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с квадратом
    /// </summary>
    class Square :Figure
    {  
        /// <summary>
        /// поле хранящее длину стороны квадрата
        /// </summary>
        public double A {  get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны квадрата</param>
        public Square(double a)
        {
            this.A = a;
        }

        /// <summary>
        /// метод для вычисления площади квадрата
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            return Computing.SquareS(A);
        }

        /// <summary>
        /// метод для вычисления периметра квадрата
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {
            return Computing.SquareP(A);
        }

        /// <summary>
        /// метод для вывода информации о квадрате
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Квадрат A = {A};");
        }
    }
}
