using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EmpLIB;


namespace Binary24Ass
{
    //Step 2: Binary Serialization and Deserialization

    //Create an instance of the Employee class and populate its properties
    internal class program
    {
        static void Main(string[] args)
        {
            // Serialize the object to binary format


            Employee employee = new Employee();

            Console.WriteLine("Enter  Employee ID");
            employee.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Name");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            employee.Salary = double.Parse(Console.ReadLine());

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\Simplilearn\\Day-21\\Assignment\\employee", FileMode.Create))

            {
                formatter.Serialize(fs, employee);
            }
            Console.WriteLine("Created & Serialized");
            Console.ReadKey();
        }
    }
}


