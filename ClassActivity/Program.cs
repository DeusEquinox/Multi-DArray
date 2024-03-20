using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var members = new[]
            {
                new{Number = 1, name = "Mpho Machailo", gender = "Male", DOB = "10/08/2004"},
                new{Number = 2, name = "Shaz Nkosi", gender = "Female", DOB = "30/08/2002"},
                new{Number = 3, name = "Yandisa Mdoda", gender = "Male", DOB = "18/07/2003"}
            };

            Console.WriteLine("Student Information:");

            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine($"Student {members[i].Number}:\n" +
                    $"Name: {members[i].name}\n" +
                    $"Gender: {members[i].gender}\n" +
                    $"DOB {members[i].DOB}\n");
            }
        }
    }
}
