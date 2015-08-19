using System;
using Assignment_6;

namespace Assignment_6
{
    class program
    {
        static void Main(string[] args)
        {
            FacebookAccount[] FacebookUser = new FacebookAccount[5];
            int i ;

            for(i = 0; i < 5; i++)
            {
                char choice;

                Console.WriteLine("Want to insert data ..... (y/n) :");
                choice = Convert.ToChar(Console.Read());

                if (choice == 'y' || choice == 'Y')
                {
                }
                else
                    break;

                FacebookUser[i] = new FacebookAccount();

                FacebookUser[i].GetDetails();
            }


            for (int j = 0; j < i /*sizeof(FacebookUser)/sizeof(FacebookAccount)*/; j++)
            {
                FacebookUser[j].PutDetails();
                Console.ReadKey();
            }

        }
    }
}
