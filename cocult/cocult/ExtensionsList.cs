using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс расширения для лист
    /// </summary>
    static class ExtensionsList
    {
        /// <summary>
        /// метод расширения для класса лист ,который вычисляет сумму площадей определенного типа фигуры
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает сумму всех площадей</returns>
        public static double S<T>(this List<Figure> list) where T : Figure
        {
            return (double)list.OfType<T>().Sum(a => a.S());
        }

        /// <summary>
        /// метод расширения для класса лист ,который вычисляет сумму периметров определенного типа фигуры
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает сумму всех периметров</returns>
        public static double P<T> (this List<Figure> list) where T : Figure
        {
            return (double)list.OfType<T>().Sum(a => a.P());
        }

        /// <summary>
        /// метод расширения для класса лист ,который его переопределяет в строку
        /// </summary>
        /// <param name="list">список с которым мы работаем</param>
        /// <returns>возращает строку содержмого</returns>
        public static string ToString<T>(this List<Point> list) where T : Point
        {
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
              str += $"Вершина {i}: ({list[i].X};{list[i].Y})\n";
            }
            return str;
        }
    }
}
