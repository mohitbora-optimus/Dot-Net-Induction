using System;

namespace Assignment8
{
    public class Program
    {   
        public static string _name;
        public static int _rollNumber;
        public static string _address;
        public static int _marks;

        enum StudentDetails { Name = 1, Marks, Address, RollNumber, EnrollmentNumber };

        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            char choice;
            int i = 0;

            do
            {
                Console.WriteLine("enter deatils of students: {0} \t ", i + 1);
                Console.Write("Enter the name of student : \t ");
                _name = Console.ReadLine();
                Console.Write("Enter the Roll Number of student : \t ");
                _rollNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the address of student : \t ");
                _address = Console.ReadLine();
                Console.Write("Enter the marks of student : \t ");
                _marks = Convert.ToInt32(Console.ReadLine());
                 
                students[i] = new Student(_name, _rollNumber,_address,_marks);
                i++;

                Console.WriteLine("want you to insert more data (y/n)");
                choice = Convert.ToChar(Console.ReadLine());

            }while(choice == 'y' || choice == 'Y');

            for (int j = 0; j < i; j++)
               Console.WriteLine("{0} \t {1}", j + 1, students[j].Name);
            
            int UserChoiceWhose, UserChoiceWhat;
            Console.WriteLine("whose detail you want ..... enter choice in numeric  \t :");
            
            UserChoiceWhose = Convert.ToInt32(Console.ReadLine()) - 1;


            Console.Write("What detail you want \n\t 1. Name 2. marks\n\t 3. address \n\t 4. roll number \n\t  5. enrollment number");
            UserChoiceWhat = Convert.ToInt32(Console.ReadLine());

            switch (UserChoiceWhat)
            {
                case (int)StudentDetails.Name:
                    Console.WriteLine(students[UserChoiceWhose].Name);
                    break;
                case (int)StudentDetails.Marks:
                    Console.WriteLine(students[UserChoiceWhose].Marks);
                    break;
                case (int)StudentDetails.Address:
                    Console.WriteLine(students[UserChoiceWhose].Address);
                    break;
                case (int)StudentDetails.RollNumber:
                    Console.WriteLine(students[UserChoiceWhose].RollNumber);
                    break;
                case (int)StudentDetails.EnrollmentNumber:
                    Console.WriteLine(students[UserChoiceWhose].EnrollmentNumber);
                    break;
                    
            }         
             Console.ReadKey();
        }
    }
}
 

          

           