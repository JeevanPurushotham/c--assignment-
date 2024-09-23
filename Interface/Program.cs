using System;
using StructVsClassDemo;  // Import namespaces
using InterfaceDemo;
using PropertiesDemo;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Struct vs Class demonstration
            PointStruct point1 = new PointStruct(10, 20);
            PointStruct point2 = point1;  // Value type copy
            point2.X = 30;
            point1.Display();  // PointStruct: X = 10, Y = 20
            point2.Display();  // PointStruct: X = 30, Y = 20

            PointClass point3 = new PointClass(10, 20);
            PointClass point4 = point3;  // Reference type copy
            point4.X = 30;
            point3.Display();  // PointClass: X = 30, Y = 20

            // Interface demonstration with explicit implementation
            Document doc = new Document();
            doc.Print();  // Default Print method
            ILoggable loggableDoc = doc;
            loggableDoc.Print();  // Explicit interface implementation

            // Class with properties
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "John Doe";
            emp.Age = 30;
            emp.DisplayInfo();  // Employee details
            emp.Age = 17;       // Invalid age
            emp.DisplayInfo();

            Console.ReadKey();
        }
    }
}
