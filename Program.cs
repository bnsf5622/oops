using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOPSConcepts
{
    class MainClass
    {
    public void Student()
    {
        int noOfStudents = 50;
        Console.WriteLine("No of Students in the Class is " +
        noOfStudents);
    }
        static void Main(string[] args)
    {
        MainClass objMainClass = new MainClass();
        objMainClass.Student();
        Console.ReadLine();
    }
}
}