using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Polygon : Figure
    {
       /// <summary>
       /// поле для хранения колличества вершин
       /// </summary>
        public string NumVertex { get; set; }
        /// <summary>
        /// лист для хранения всех вершин
        /// </summary>
        private List<Point> _polygonVertex;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="n">колличество вершин</param>
        public Polygon(string n)
        {
            NumVertex = n;

            _polygonVertex = new List<Point>();
        }

        /// <summary>
        /// метод для преобразование в строку
        /// </summary>
        /// <returns>строку</returns>
        public string ToString()
        {
            return $"{_polygonVertex.Count}";
        }

        /// <summary>
        /// метод для ввода вершин
        /// </summary>
        public void Input()
        {
            for (int i = 0; i < _polygonVertex.Count; i++)
            {
                Console.WriteLine($"Ввод данных вершины ");
                Console.WriteLine($"Ввод X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ввод Y");
                int y = Convert.ToInt32(Console.ReadLine());

                _polygonVertex.Add(new Point(x,y));
            }

            _polygonVertex.Add(_polygonVertex[0]);
        }

        /// <summary>
        /// метод вычисления периметра многоугольника
        /// </summary>
        /// <returns>возращает периметр многоугольника</returns>
        public override double P()
        {
            double p = 0;

            for(int i = 0; i < _polygonVertex.Count-1; i++)
            {
             p += Computing.DistanceSquared(_polygonVertex[i],_polygonVertex[i+1]);
            }

            return p;
        }

        /// <summary>
        /// метод вычисления площадь многоугольника
        /// </summary>
        /// <returns>возращает площадь многоугольника</returns>
        public override double S()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            double s = 0;
            int front = 1;

            for (int i = 1; i < _polygonVertex.Count - 2; i++)
            {
                
                for(int z = 1; z < _polygonVertex.Count; z++)
                {
                   
                    

                    if(front == i)
                    {
                      a = Computing.DistanceSquared(_polygonVertex[0], _polygonVertex[i]);
                      b = Computing.DistanceSquared(_polygonVertex[0], _polygonVertex[i+1]); 
                      c = Computing.DistanceSquared(_polygonVertex[i], _polygonVertex[i + 1]);
                        front++; 
                        Triangle triangle = new Triangle(a,b,c);
                      s += triangle.S();
                        break;
                    }
                   
                }
               
            }

            return s;
        }

        /// <summary>
        /// метод для вывода информации о многоугольнике
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Многоугольник ");

            Console.WriteLine(_polygonVertex.ToString<Point>());
            
        }
    }
}
