using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Name: ");
            String fname = Console.ReadLine();
            Console.Write("Enter Your Last Name: ");
            String lname = Console.ReadLine();
            Console.Write("Enter Your Date of Birth (DOB): ");
            String dob = Console.ReadLine();
            Console.Write("Enter Your Admission Number: ");
            int adnum = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Telephone Number: ");
            int tpnum = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Gender: ");
            String gender = Console.ReadLine();
            Console.Write("Enter Your NIC No: ");
            String nicnum = Console.ReadLine();


            Console.WriteLine("\n--- User Details  ---");
            Console.WriteLine($"First Name: {fname}");
            Console.WriteLine($"Last Name: {lname}");
            Console.WriteLine($"Full Name: {fname} {lname}");
            Console.WriteLine($"DOB: {dob}");
            Console.WriteLine($"Admission Number: {adnum}");
            Console.WriteLine($"Telephone Number: {tpnum}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"NIC No: {nicnum}");
        }
    }
}
