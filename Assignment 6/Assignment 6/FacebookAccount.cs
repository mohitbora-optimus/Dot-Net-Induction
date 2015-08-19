using System;

namespace Assignment_6
{
    class FacebookAccount
    {
        private string _userName;
        private int _userId;
        private int _age;
        private string _designation;

        public void GetDetails()
        {
            Console.WriteLine("..........Enter the details of the user ............ ");

            Console.Write("Enter User Name: \t");
            _userName = Console.ReadLine();

            Console.Write("Enter User Id number: \t");
            _userId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter User Age: \t");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter User Designation: \t");
            _designation = Console.ReadLine();

        }
        
        public void PutDetails()
        {
            Console.WriteLine(" \n \n \t ..........User Details....... ");
            Console.WriteLine("\t\t User Name: \t {0}", this._userName);
            Console.WriteLine("\t\t User Id: \t {0}", this._userId);
            Console.WriteLine("\t\t User Age: \t {0}", this._age);
            Console.WriteLine("\t\t User Designation: \t {0}", this._designation);        
        }
       
    }
}
