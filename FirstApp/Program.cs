using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {
            (string Name, string Type, double Age, int NameCount) Pet;

            
            Console.WriteLine("Введите имя вашего питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите тип вашего питомца: ");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возраст вашего питомца цифрами: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            




            Console.WriteLine("Имя вашего питомца: {0}", Pet.Name);
            Console.WriteLine("Тип вашего животного: {0}", Pet.Type);
            Console.WriteLine("Возраст вашего питомца: {0} ", Pet.Age);
            Console.WriteLine("Длина имени вашего питомца: {0}", Pet.NameCount);
            

            

            Console.ReadKey();
        }

    }

}










