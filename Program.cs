using System;
namespace ConsoleApplication7
{
    public enum DayOfWeek
    {
        Понедельник = 0,
        Вторник = 1,
        Среда = 2,
        Четверг = 3,
        Пятниццо = 4,
        Суббота = 5,
        Воскресенье = 6
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));
        }
    }
}