using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20._1
{
    internal class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            /*
             
             В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
            -       метод получает входным параметром переменную типа double;
            -       метод возвращает значение типа double, которое является результатом вычисления.
 
            Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
            -       длину окружности по формуле D = 2 * π* R;
            -       площадь круга по формуле S = π* R²;
            -       объем шара. Формула V = 4/3 * π * R³.
             
            */

            Console.Write("Введите значение радиуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            MyDelegate myCircle = Circle;
            Console.WriteLine($"Длина окружности: { myCircle?.Invoke(radius)}");

            MyDelegate myArea = Area;
            Console.WriteLine($"Длина окружности: { myArea?.Invoke(radius)}");

            MyDelegate myVolume = Volume;
            Console.WriteLine($"Длина окружности: { myVolume?.Invoke(radius)}");



            Console.ReadKey();

            #region Методы
            double Circle(double Radius)
            {
                return 2 * Radius * Math.PI;
            }
            double Area(double Radius)
            {
                return Math.Pow(Radius, 2) * Math.PI;
            }
            double Volume(double Radius)
            {
                return 4 / 3 * Math.Pow(Radius, 3) * Math.PI;
            }
            #endregion


        }

    }
}
