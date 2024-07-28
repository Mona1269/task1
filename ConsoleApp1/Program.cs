using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            //Console.WriteLine("pls enter student Name ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("pls enter student id ");
            //int id = int.Parse(Console.ReadLine());

            //Console.WriteLine("pls enter student age ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"student name {Name},and his id {id},and his age {age}");
            #endregion

            // check the number is positive or negative 
            // Console.WriteLine("plz enter your number");
            //string  input=Console.ReadLine();
            // int num = int.Parse(input);


            //if  (num > 0) {
            // Console.WriteLine("the number is positive");

            //  }
            // else
            // {
            //  Console.WriteLine("the number is negative");

            // }
            // check the number is even or odd

            //Console.WriteLine("plz enter your num ");
            //string input = Console.ReadLine();
            //int num = int.Parse(input);
            //if ( num % 2==0) {
            //Console.WriteLine("your num is even  ");
            //  }
            // else
            //{
            // Console.WriteLine("the number is odd");
            //}

            Console.WriteLine("enter the length ");
            string  length_input = Console.ReadLine();
            Console .WriteLine("enter the width ");
            string width_input = Console.ReadLine();
            double.Parse(length_input);
            double.Parse(width_input);
            if (length_input == width_input)
            {
                Console.WriteLine("is a square");

            }
            else
            {
                Console.WriteLine("is not a square");
            }





        }
        

    }
    
}

