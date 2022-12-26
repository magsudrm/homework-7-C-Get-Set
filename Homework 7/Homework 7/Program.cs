using System;
using System.Linq;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users=new User[0];
            string option;
            do
            {
                Console.WriteLine("1. User elave et");
                Console.WriteLine("2. Userlere bax");
                Console.WriteLine("3. Userler uzre axtaris et");
                Console.WriteLine("0. Prosesi bitir");
                option = Console.ReadLine();
                if (option == "1")
                {
                    User newUser=CreateUser();
                    users = AddUser(ref users, newUser);

                }
                else if (option == "2")
                {
                    LookUsers(users);
                }
                else if (option == "3")
                {
                    FindSearch(users);
                }
                else if (option == "0")
                {
                    Console.WriteLine("Proses bitdi");
                }

            } while (option != "0");

        }

        static User CreateUser()
        {
            User newUser = new User(null);
            do
            {
                Console.WriteLine("adini yaz: ");
                string userNameStr = Console.ReadLine();
                newUser.UserName = (userNameStr.ToLower());

            } while (newUser.UserName == null);
            do
            {
                Console.WriteLine("Password yaz: ");
                string passwordStr = Console.ReadLine();
                newUser.Password = (passwordStr);
            } while (newUser.Password == null);
            newUser.DateTime = DateTime.Now.ToString();
            return newUser;
        }
        static User[] AddUser(ref User[] arr,User newUser)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newUser;
            return arr;
        }
        static void FindSearch(User[] arr)
        {
            Console.Write("Axtaris deyerini daxil edin: ");
            String search=Console.ReadLine();
            for(int i = 0; i < arr.Length; i++)
            {
                search = search.ToLower();
                if (arr[i].UserName.Contains(search))
                {
                    Console.WriteLine("Username: "+arr[i].UserName);
                    Console.WriteLine("Yaranma tarixi: "+arr[i].DateTime);
                }
            }
        }
        static void LookUsers(User[] arr)
        {
            for(int i=0;i<arr.Length;i++)     
            {
                Console.WriteLine("Username: "+arr[i].UserName);
                Console.WriteLine("Yaranma tarixi: "+arr[i].DateTime);
            }
        }
    }
}
