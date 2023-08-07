using System;
using System.IO;
using System.Xml.Serialization;
using EmpLIB;



namespace _24XMLSerial
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            // Step 3: XML Serialization and Deserialization
            Console.WriteLine("XML Serialization \n");
            // Create an instance of the Employee class and populate its properties
            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Salary = 50000.0
            };
            

            // Serialize the object to XML format
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (FileStream stream = new FileStream(" D:\\Simplilearn\\Day-21\\Assignment\\employee.xml", FileMode.Create))
            {
                serializer.Serialize(stream, employee);
                Console.WriteLine("XML Serialization ***Done***\n");
            }
            

            // Deserialize the object from XML format
            using (FileStream stream = new FileStream("D:\\Simplilearn\\Day-21\\Assignment\\employee.xml", FileMode.Open))
            {
                Employee deserializedEmployee = (Employee)serializer.Deserialize(stream);
                Console.WriteLine("Deserialized Employee:");
                Console.WriteLine($"ID: {deserializedEmployee.Id}");
                Console.WriteLine($"First Name: {deserializedEmployee.FirstName}");
                Console.WriteLine($"Last Name: {deserializedEmployee.LastName}");
                Console.WriteLine($"Salary: {deserializedEmployee.Salary}\n");
            }
            Console.WriteLine("XML Created & Deserialized");
            Console.ReadKey();
        }

    }
    
}
