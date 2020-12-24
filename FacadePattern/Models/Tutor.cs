using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class Tutor
    {
        private int _id;
        public string InstructingModuleCode { get; set; }
        public Tutor(int id)
        {
            _id = id;
        }

        public bool Check(Coursework coursework)
        {
            coursework.IsChecked = true;
            Console.WriteLine("Checking is in progress...");
            return coursework.IsChecked;
        }
    }
}
