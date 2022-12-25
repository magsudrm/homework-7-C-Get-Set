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
                    User newUser=createUser();
                    users = addUser(ref users, newUser);

                }
                else if (option == "2")
                {
                    lookUsers(users);
                }
                else if (option == "3")
                {
                    findSearch(users);
                }
                else if (option == "0")
                {
                    Console.WriteLine("Proses bitdi");
                }

            } while (option != "0");

        }

        static User createUser()
        {
            User newUser = new User(null);
            do
            {
                Console.WriteLine("adini yaz: ");
                string userNameStr = Console.ReadLine();
                newUser.UserName = (userNameStr);

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
        static User[] addUser(ref User[] arr,User newUser)
        {
            User[] arr2 = new User[arr.Length + 1]; 
            for(int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr2.Length-1] = newUser;
            return arr2;
        }
        static void findSearch(User[] arr)
        {
            Console.Write("Axtaris deyerini daxil edin: ");
            String search=Console.ReadLine();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].UserName.Contains(search))
                {
                    Console.WriteLine("Username: "+arr[i].UserName);
                    Console.WriteLine("Yaranma tarixi: "+arr[i].DateTime);
                }
            }
        }
        static void lookUsers(User[] arr)
        {
            for(int i=0;i<arr.Length;i++)     
            {
                Console.WriteLine("Username: "+arr[i].UserName);
                Console.WriteLine("Yaranma tarixi: "+arr[i].DateTime);
            }
        }
    }
}
