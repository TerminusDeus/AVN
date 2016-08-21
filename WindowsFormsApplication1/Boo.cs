using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public sealed class Boo
    {
        private readonly int _id;

        public Boo()
        {
            NotMain();
        }

        public Boo(int id)
        {
            _id = id;
        }

        public static IEnumerable<Boo> Generate(int numberOfElements)
        {
            return Enumerable.Range(1, numberOfElements).Select(id => new Boo(id + 1)); 
            
            // Range - Создает последовательность целых чисел в указанном диапазоне; в нашем случае от 1 до 100
            // Select - Проецирует каждый элемент последовательности в IEnumerable<T>

            //Маркер => называется лямбда - оператором.Он используется в лямбда - выражениях для отделения входных переменных 
            //с левой стороны от тела лямбда-выражения с правой стороны.Лямбда - выражения — это встроенные выражения, 
            //аналогичные анонимным методам, но более гибкие.
        }

        public static void NotMain()
        {
            var elements = Boo.Generate(100);

            Console.WriteLine("Тип равен " + elements. GetType().ToString());
        }
    }
}


