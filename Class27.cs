using ConsoleApp1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Employee
    {
        public string name { get; set; }
        private int age;
        //private Data member can not be initialized outside the class but can be initialized inside the class
        public string dept { get; set; }
        //private double salary;
        protected double salary;
        //does not any return type and does not have any parameters
        //same name as class name
        //why private data members are used? to hide the data from outside world and to access them we use getter and setter methods
        //why this keyword is used? to refer the current object of the class
        //why access specifier is used? to control the access of the data members and methods of the class
        //why private access specifier is used? to hide the data members and methods from outside world
        //why public access specifier is used? to allow the access of the data members and methods from outside world
        //why property is used? to provide a way to access the private data members of the class
        //why getter and setter methods are used? to access the private data members of the class

        public Employee()
        { }



        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public int Age
        {
            get {
                return age;
            }
            set
            {
                if (value >= 18)
                    age = value;
                else
                    age = -1;
            }

        }


        public void Display()
          
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee Department: " + dept);
            Console.WriteLine("Employee salary: " + salary);
        }
        Public void Check()
        {

            Console.WriteLine("Employee Name: " + Basic);
            Console.WriteLine("Employee Age: " + DA);
            Console.WriteLine("Employee Department: " + HRA);
            Console.WriteLine("Employee salary: " + PF);
            Console.WriteLine("Employee salary: " + PT);




        class Class27
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee();
                e1.name = "shreeya";
                e1.Age = 20;
                e1.dept = "CE";
                e1.SetSalary(200000);

                e1.Display();

                Employee e2 = new Employee();

                e2.name = "mahi";
                e2.Age = 17;
                e2.dept = "IT";
                e2.SetSalary(30000);


                e2.Display();


                Employee e3 = new Employee();
                e3.Display(); //employee
                e3.check();
                Console.WriteLine("-----------------");

                RegularEmployee e4 = new RegularEmployee();
                e4.Display();
                e4.check();
                Console.WriteLine("-----------------");

                Employee e5 = new Employee();
                e4.Display();
                e4.check();
                Console.WriteLine("-----------------");





                Console.ReadLine();

            }
        }
    }
}


class RegularEmployee : Employee
{
    //Data member : from class : 5
    //Data menber : from parent class employee :3
    //protected : from this class 8
    //properties : from parent class employee :1
    //methos : from this class :0
    //Method :from parent class Employee: 3

    private double Basic;
    private double DA;
    private double HRA;
    private double PF;
    private double PT;







       Public void  Check()
       {

    Console.WriteLine("Employee Name: " + Basic);
    Console.WriteLine("Employee Age: " + DA);
    Console.WriteLine("Employee Department: " + HRA);
    Console.WriteLine("Employee salary: " + PF);
        Console.WriteLine("Employee salary: " + PT);


           }
        Employee e3 = new Employee();
        e3.Display(); //employee
        e3.Check();
        Console.WriteLine("-----------------");

        RegularEmployee e4 = new RegularEmployee();
        e4.Display();
        e4.check();
        Console.WriteLine("-----------------");

        Employee e5 = new Employee();
        e4.Display();
        e4.check();
        Console.WriteLine("-----------------");
    }

//class,object,data member,methods,property,getter or setter method,this keyword,access specifier,private,pubic
