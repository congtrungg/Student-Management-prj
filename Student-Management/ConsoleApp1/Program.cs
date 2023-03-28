using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            List<Student> students = new List<Student>();
            int n, id, choice;
            string username, password, name, course, room, loop_choice;   
            int ctr = 0;
            Console.Write("\n\nCheck Username and Password : \n");
            Console.Write("N.B. : Default username and password is : abcd and 1234\n");
            Console.Write("------------------------------------------------------------------------------- \n");
            do
            {
                Console.Write("input a username: ");
                username = Console.ReadLine();

                Console.Write("input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234") {
                    ctr++;
                } else {
                    ctr = 1;
                }
            }
            while ((username != "abcd" || password != "1234") && (ctr != 3));
            if (ctr == 3) {
                Console.Write("\nLogin attempt three or moret times.Try later!\n\n");
            } else {

               
                do {

                    
                    Console.WriteLine("Choose one of the following options : ");
                    Console.WriteLine("1. Insert student details");
                    Console.WriteLine("2. View student details");
                    choice = int.Parse(Console.ReadLine());                   

                    switch (choice)
                    {
                        case 1: 
                                    Console.WriteLine("Enter How Many student Data you want to enter?");
                                    n = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < n; i++) 
                                    {
                                        Console.WriteLine("Enter the name of the student " + (i+1));
                                        name = Console.ReadLine();

                                        Console.WriteLine("Enter the id no of the student" + (i+1));
                                        id = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter the course of the student" + (i+1));
                                        course = Console.ReadLine();

                                        Console.WriteLine("Enter the room of the student" + (i+1));
                                        room = Console.ReadLine();

                                        Student new_student = new Student(name, id, course, room);
                                        students.Add(new_student);
                                    }
                                    break;

                        case 2:     
                                    Console.WriteLine("Displaying students...");
                                    Console.WriteLine("-----------------------");
                                    
                                    int count = students.Count; 
                                    if(count !=0) {
                                        foreach (Student student in students)
                                        {
                                            Console.WriteLine("Name of the student is : " + student.getName());
                                            Console.WriteLine("ID of the student is : " + student.getRoll());
                                            Console.WriteLine("Course of the student is : " + student.getCourse());
                                            Console.WriteLine("ROOM of the student is : " + student.getStream());
                                            Console.WriteLine("\n");
                                        }
                                    } else {
                                        Console.WriteLine("There are no students in the list. Please Insert records!!");
                                    }
                                    break;

                        default:    Console.WriteLine("Wrong choice!!");
                                    break;
                    }
                    Console.WriteLine("Go back to the menu?(Y/n): ");
                    loop_choice = Console.ReadLine();
                } while(loop_choice == "Y" || loop_choice == "y");         

            }
        }
    }
}
