using System;

namespace FirstApp
{
    public class Program
    {

        private static (string Name, string SurName, int Age, string[] PetNames, string[] FavoriteColors) GetUserData()
        {
            Console.WriteLine("Введите ваше имя:");
            var userName = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            var userSurName = Console.ReadLine();

            var hasCorrectAge = false;
            var age = 0;
            while (!hasCorrectAge)
            {
                Console.WriteLine("Введите ваш возраст:");
                var stringAge = Console.ReadLine();
                hasCorrectAge = ParseIntValue(stringAge, out age);
            }
            
            Console.WriteLine("У вас есть домашние животные: Да или Нет?");
            string stringHavePets = Console.ReadLine();
            var havePets = false;
            if (stringHavePets == "Да")
            {
                havePets = true;
            }

            var petNames = new string[0];
            if (havePets)
            {
                var petsCount = 0;
                var hasCorrectPetsCount = false;
                while (!hasCorrectPetsCount)
                {
                    Console.WriteLine("Введите количество питомцев:");
                    var stringPetsCount = Console.ReadLine();
                    hasCorrectPetsCount = ParseIntValue(stringPetsCount, out petsCount);
                }
                petNames = GetPetNames(petsCount);
            }

            var favoriteColors = new string[0];
            var colorsCount = 0;
            var hasCorrectColorsCount = false;
            while (!hasCorrectColorsCount)
            {
                Console.WriteLine("Введите количество любимых цветов:");
                var stringColorsCount = Console.ReadLine();
                hasCorrectColorsCount = ParseIntValue(stringColorsCount, out colorsCount);
            }
            favoriteColors = GetFavoriteColors(colorsCount);

            return (userName, userSurName, age, petNames, favoriteColors);
        }

        private static bool ParseIntValue(string inputValue, out int intValue)
        {
            var result = Int32.TryParse(inputValue, out intValue);
            if (!result || intValue <= 0)
            {
                result = false;
                Console.WriteLine("Введите положительное целое число.");
            }
            
            return result;
        }

        private static string[] GetFavoriteColors(int colorsCount)
        {
            var favoriteColors = new string[colorsCount];
            for (var i = 0; i < colorsCount; i++)
            {
                Console.WriteLine($"Введите любимый цвет: {i + 1}:");
                favoriteColors[i] = Console.ReadLine();
            }
            return favoriteColors;
        }

        private static string[] GetPetNames(int petsCount)
        {
            var petNames = new string[petsCount];
            for (var i = 0; i < petsCount; i++)
            {
                Console.WriteLine($"Введите имя питомца {i + 1}:");
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }

        private static void PrintUserData((string Name, string SurName, int Age, string[] PetNames, string[] FavoriteColors) userData)
        {
            Console.WriteLine("Имя пользователя:");
            Console.WriteLine(userData.Name);
            Console.WriteLine("Фамилия пользователя:");
            Console.WriteLine(userData.SurName);
            Console.WriteLine("Возраст пользователя:");
            Console.WriteLine(userData.Age);
            if (userData.PetNames.Length > 0)
            {
                Console.WriteLine("Имена питомцев:");
                Console.WriteLine(String.Join(", ", userData.PetNames));
            }
            Console.WriteLine("Любимые цвета:");
            Console.WriteLine(String.Join(", ", userData.FavoriteColors));

        }

        private static void Main(string[] args)

        {
            var userData = GetUserData();
            Console.WriteLine();
            PrintUserData(userData);
            
            Console.ReadKey();
        }

    }

}










