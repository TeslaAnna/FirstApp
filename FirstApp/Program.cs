using System;

namespace FirstApp
{
    class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {

            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;

        }

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;

            int[] sasc;
            int[] sdesc;

            if (IsSort)
            {
                temp = SortArray(array, out sdesc, out sasc);
            }

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

        }
        static void SortArray(in int[] array, out int[] sortdesc, out int[] sortasc)
        {

            sortdesc = SortArrayDesc(array);
            sortasc = SortArrayAsc(array);

        }

        static int[] SortArrayDesc(int[] desc)
        {
            int temp = 0;

            for (int i = 0; i < desc.Length; i++)
            {
                for (int j = i + 1; j < desc.Length; j++)
                    if (desc[i] < desc[j])
                    {
                        temp = desc[i];
                        desc[i] = desc[j];
                        desc[j] = temp;

                    }
            }


            return desc;
        }

        static int[] SortArrayAsc(int[] asc)
        {
            int temp = 0;

            for (int i = 0; i < asc.Length; i++)
            {
                for (int j = i + 1; j < asc.Length; j++)
                    if (asc[i] > asc[j])
                    {
                        temp = asc[i];
                        asc[i] = asc[j];
                        asc[j] = temp;

                    }
            }


            return asc;
        }
        static void Main(string[] args)

        {
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);
            Console.ReadKey();

        }







    }

}










