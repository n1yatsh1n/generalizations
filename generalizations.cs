using System;
using System.Security.Cryptography.X509Certificates;

namespace g_class
{
    public class GenericArray<T>
    {
        private T[] array;

        public GenericArray()
        {
            array = new T[0];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(T value)
        {
            T[] newData = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newData[i] = array[i];
            }
            newData[array.Length] = value;
            array = newData;
        }
        public void DeleteItem(T value)
        {
            T[] newData = new T[array.Length - 1];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value)) k = i;
            }
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == k)
                {
                    continue;
                }
                newData[c] = array[i];
                c += 1;
            }
            array = newData;
        }
        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericArray<string> stringArray = new GenericArray<string>();
            stringArray.SetItem("1");
            stringArray.SetItem("3");
            stringArray.SetItem("4");
            stringArray.DeleteItem("1");
            stringArray.PrintArray();

            string first = stringArray.GetItem(1);
            Console.WriteLine(first);
        }
    }
}