namespace acfour_library
{
    public class Acfour
    {
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }

        public static void QuickValuesChange(ref int numA, ref int numB)
        {
            int aux;
            aux = numA;
            numA = numB;
            numB = aux;
        }

        public static void DescOrderArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])

                    {
                        QuickValuesChange(ref array[i], ref array[j]);
                    }
                }
            }
        }
    }
}