using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Прогрессии
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(5, 3, 10);
            GeomProgression geomProgression = new GeomProgression(1, 3, 7);
            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void setStart(int x);        
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int startNum; // Стартовое число
        int num; // Текущее значение
        int step; // Шаг прогрессии
        int count; // Количество элементов прогрессии
        public void setStart(int x)
        {            
            startNum = x;           
        }

        public int getNext()
        {
            return num + step;
        }

        public void reset()
        {
            num = startNum;
        }

        public ArithProgression(int startNum, int step, int count)
        {
            if (step != 0)
            {
                num = startNum;
                Console.WriteLine(num);
                for (int i = 0; i < count; i++)
                {
                    num += step;
                    Console.WriteLine(num);
                }
            } else
            {
                Console.WriteLine("Шаг прогрессии не может быть = 0");
            }
        }

    }

    class GeomProgression : ISeries
    {
        int startNum; // Стартовое число
        int num; // Текущее значение
        int step; // Шаг прогрессии
        int count; // Количество элементов прогрессии
        public void setStart(int x)
        {
            startNum = x;
        }

        public int getNext()
        {
            return num * step;
        }

        public void reset()
        {
            num = startNum;
        }

        public GeomProgression(int startNum, int step, int count)
        {
            if (step != 0)
            {
                num = startNum;
                Console.WriteLine(num);
                for (int i = 0; i < count; i++)
                {
                    num *= step;
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("Шаг прогрессии не может быть = 0");
            }
        }

    }
}
