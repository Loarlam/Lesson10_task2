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
    class MyList<T> where T: new()
    {
        T[] _array;

        //свойство TotalNumberOfElements на чтение, для получения общего количества элементов
        public int TotalNumberOfElements => _array.Length;

        //Индексатор для получения значения элемента по указанному индексу
        public T this[int index] => _array[index];

        //метод AddItem для добавления элемента
        public void AddItem(T[] element)
        {
            _array = element;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
