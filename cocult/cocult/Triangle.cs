using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с треугольником
    /// </summary>
    class Triangle :Figure
    {

        /// <summary>
        /// поле хранящее сторону 1 треуголника
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// поле хранящее сторону 2 треуголника
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// поле хранящее сторону 3 треуголника
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны 1 треуголника </param>
        /// <param name="b">ввод стороны 2 треуголника</param>
        /// <param name="c">ввод стороны 3 треуголника</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// метод для вычисления площади треугольника
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            double p = Computing.p(P());

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// метод для вычисления периметра треугольника
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {           
            return Computing.TringleP(A,B,C);
        }

        /// <summary>
        /// метод для вывода информации о треугольнике
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Треугольник A = {A}; B = {B}; C = {C}");
        }
    }
}
