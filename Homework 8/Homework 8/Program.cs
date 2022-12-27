using System;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[0];
            string option;
            do
            {
                Console.WriteLine("1. Notebook elave et");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Notebooklar uzre axtaris et");
                Console.WriteLine("0. Prosesi bitir");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Notebook newNotebook = CreateNotebook();
                    notebooks = AddNotebook(ref notebooks, newNotebook);
                }
                else if (option == "2")
                {
                    LookNotebooks(notebooks);
                }
                else if (option == "3")
                {
                    FindSearch(notebooks);
                }
                else if (option == "0")
                {
                    Console.WriteLine("Proses bitdi");
                }

            } while (option != "0");
        }
        static Notebook CreateNotebook()
        {
            Notebook newNotebook = new Notebook();
            do
            {
                Console.WriteLine("Notebookun adini yaz: ");
                string notebookNameStr = Console.ReadLine();
                newNotebook.Name = (notebookNameStr.ToLower());

            } while (newNotebook.Name == null);
            do
            {
                Console.WriteLine("Notebookun price yaz: ");
                string priceStr = Console.ReadLine();
                int price = Convert.ToInt32(priceStr);
                newNotebook.Price = (price);
            } while (newNotebook.Price == 0);
            return newNotebook;
        }
        static Notebook[] AddNotebook(ref Notebook[] arr, Notebook newNotebook)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newNotebook;
            return arr;
        }
        static void LookNotebooks(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Name: " + arr[i].Name+" Price: " + arr[i].Price);
            }
        }
        static void FindSearch(Notebook[] arr)
        {
            Console.Write("Axtaris deyerini daxil edin: ");
            String search = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                search = search.ToLower();
                if (arr[i].Name.Contains(search))
                {
                    Console.WriteLine("Name: " + arr[i].Name+" Price: " + arr[i].Price);
                }
            }

        }
    }
}