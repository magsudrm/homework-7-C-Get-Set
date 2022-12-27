using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    internal class Store
    {
        Notebook[] notebooks2=new Notebook[0];

        public Notebook[] AddNotebook(Notebook[] arr,Notebook notebook)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = notebook;
            return arr;
        }

        public void SearchNotebooks(Notebook[] arr, string search)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                search = search.ToLower();
                if (arr[i].Name.Contains(search))
                {
                    Console.WriteLine("Name: " + arr[i].Name + " Price: " + arr[i].Price);
                }
            }
        }
        public void ShowNotebooks(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Name: " + arr[i].Name+" Price: " + arr[i].Price);
            }
        }
    }
}
