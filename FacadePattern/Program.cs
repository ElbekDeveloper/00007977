using FacadePattern.Models;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check feature was activate by tutor in the system
            ActionFacade action = new ActionFacade(new Tutor(1111));
            action.Check();


            Console.ReadKey();
        }
    }
}
