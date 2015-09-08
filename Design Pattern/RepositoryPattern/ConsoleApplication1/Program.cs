using ConsoleApplication1;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            StateService stateService = new StateService();
            
            Console.WriteLine("Menu .....");
            Console.WriteLine("1. Add A new State");
            Console.WriteLine("2. Delete a State");
            Console.WriteLine("3. Update a State");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        State newState = new State();
                        Console.WriteLine("enter the State Id");
                        newState.StateId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the State Name");
                        newState.StateName = Console.ReadLine();
                        stateService.Add(newState);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("enter the State Id");
                        int StateId = Convert.ToInt32(Console.ReadLine());
                        stateService.Delete(StateId);
                        break;
                    }
                case 3:
                    {
                        State updatedState = new State();
                        Console.WriteLine("enter the State Id");
                        updatedState.StateId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the State Name");
                        updatedState.StateName = Console.ReadLine();
                        stateService.update(updatedState);
                        break;
                    }
            }
        }
    }
}
