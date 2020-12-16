using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {
            (string Name, string LastName, string Login, int LoginLength, bool HavePet, double Age, string[] Color) User;

            for (int x = 0; x< 3; x++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string i = Console.ReadLine();

                if (i == "Да")
                {
                    User.HavePet = true;
                }
                else
                {
                    User.HavePet = false;

                }

                Console.WriteLine("Введите возраст пользователя");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.Color = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int k = 0; k < User.Color.Length; k++)
                {
                    User.Color[k] = Console.ReadLine();

                }


            }
            

            Console.ReadKey();
        }

    }

}










