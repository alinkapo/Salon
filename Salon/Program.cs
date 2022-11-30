namespace Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас!");


            Console.WriteLine("Выберите команду:");


            while (true)
            {
                var command = Console.ReadLine().ToLower().Split(' ');
                Controller s = new Controller();
                switch (command[0])
                {
                    case "добавить":
                        s.AddGood(command[1], float.Parse(command[2]), float.Parse(command[3]), command[4]);
                        break;
                    case "2":
                        Console.WriteLine(s.GetGoods());
                        break;
                    default:
                        Console.WriteLine("Ошибка в команде");
                        break;

                }
            }
        }
    }
}