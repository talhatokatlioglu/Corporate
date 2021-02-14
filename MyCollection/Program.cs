using System;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> names = new MyList<string>();

            names.Add("Talha");

            //Console.WriteLine(names.Length);

            names.Add("Süha");

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
