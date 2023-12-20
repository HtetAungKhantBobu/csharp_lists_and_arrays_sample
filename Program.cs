using System;
namespace ListNArrays{
    class ListNArrays{
        public static void Main(string[] args){
            List<string> user_strings = new List<string>();
            
            
            
            bool yn = true;
            do{
                Console.WriteLine("Enter a string to be added...");
                string user_input = Console.ReadLine();
                user_strings.Add(user_input);
                Console.WriteLine("Add again? y/n");
                string user_answer = Console.ReadLine();
                switch (user_answer){
                    case "n":
                        yn = false;
                        break;
                }
            }while(yn);
            Console.WriteLine("Here are the strings you gave me.");
            foreach(string s in user_strings){
                Console.WriteLine(s);
            }
        }
    }
}