using FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class ActionFacade
    {
        private Tutor _tutor;

        public ActionFacade(Tutor tutor)
        {
            _tutor = tutor;
        }

        public void Check()
        {
            //Tutor is in the student profile within the system
            Console.WriteLine("Getting student details...");
            Student student = new Student(7777);
            Console.WriteLine("Getting the coursework file...");
            Coursework coursework = new Coursework(_tutor.InstructingModuleCode, student);
            Console.WriteLine("Opening the file...");
            _tutor.Check(coursework);
            Console.WriteLine("Checking is complete...");
        }
    }
}
