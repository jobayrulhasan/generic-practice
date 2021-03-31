using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            student<bool> std = new student<bool>() { Name = "Jobayrul Hasan", success = true };
            student<int> std1 = new student<int>() { Name = "Rezaul Karim", success = 2 };
            student<string> std2 = new student<string>() { Name = "Hamidur Rahman", success = "Pass" };
            //studentInt std1 = new studentInt() { Name = "Rezaul Karim", success = 2 };
            //studentString std2 = new studentString() { Name = "Hamidur Rahman", success = "Pass" };
            Console.WriteLine("Output for bool: {0}",std.success);
            Console.WriteLine("Output for integer: {0}", std1.success);
            Console.WriteLine("Output for string: {0}", std2.success);
            print(std1); //call to method
            Console.ReadKey();
        }
        public static void print(student<int> std1)
        {
            Console.WriteLine("Name : "+std1.Name+","+"Result : "+std1.success);
        }
    }
   public class student<t>
   {
        public string Name { get; set; }
        public t success { get; set; }
   }
    //public class studentInt
    //{
    //    public string Name { get; set; }
    //    public int success { get; set; }
    //}
    //public class studentString
    //{
    //    public string Name { get; set; }
    //    public string success { get; set; }
    //}
}