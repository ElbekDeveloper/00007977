using System.Collections.Generic;

namespace TranscriptBuilder.Models
{
    public abstract class Transcript
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public List<int> Marks { get; set; }
    }
}
