namespace FacadePattern.Models
{
    public class Coursework
    {
        public string ModuleCode { get; set; }
        private Student _student;
        public bool IsChecked { get; set; } 
        public Coursework()
        {
            ModuleCode = "";
            IsChecked = false;
        }

        public Coursework(string moduleCode, Student student)
        {
            ModuleCode = moduleCode;
            _student = student;
        }
    }
}
