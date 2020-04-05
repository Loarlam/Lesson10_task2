/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyList<T>. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>.
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения 
общего количества элементов.  
*/
using System;

namespace Task2
{
    class MyList<T>
    {
        T[] _array;
        int _counter;

        public MyList(int numberOfArrayElements)
        {
            _array = new T[numberOfArrayElements];
        }

        //свойство TotalNumberOfElements на чтение, для получения общего количества элементов
        public int TotalNumberOfElements => _array.Length;

        //Индексатор для получения значения элемента по указанному индексу
        public T this[int index] => _array[index];

        //метод AddItem для добавления элемента
        public void AddItem(T element)
        {
            _array[_counter] = element;
            _counter++;
        }
    }

    class Program
    {
        static MyList<int> instance;
        static int numberOfArrayElements;

        static void Main(string[] args)
        {
            numberOfArrayElements = new Random().Next(10,20);

            instance = new MyList<int>(numberOfArrayElements);

            Console.WriteLine($"Количество элементов массива = {TotalNumberOfArrayElements()}");

            //Цикл, выводящий на экран элементы массива со значениями
            for (int i = 0; i < numberOfArrayElements; i++)
            {
                Console.WriteLine($"array[{i+1}] = {instance[i]}");
            }

            //Передаем рандомные элементы, по одному, в метод AddItem.
            int TotalNumberOfArrayElements()
            {
                for (int i = 0; i < numberOfArrayElements; i++)
                {
                    instance.AddItem(new Random().Next(100));
                }

                return instance.TotalNumberOfElements;
            }

            Console.ReadKey();
        }
    }
}
