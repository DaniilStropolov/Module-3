namespace Questionnaire2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Тебя зовут {name} и тебе {age}");

            Console.Write("Введите дату своего рождения: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine($"Вы родились {birthDate}");
        }
    }
}
