using System;
using System.Collections.Generic;
using TranscriptBuilder.Models;

namespace TranscriptBuilder.Builders
{
    public class WordBuilder : TranscriptBuilder
    {
        private WordTranscript _wordTranscript;
        public WordBuilder()
        {
            _wordTranscript = new WordTranscript();
        }

        public override void AttachMarks(List<int> marks)
        {
            _wordTranscript.Marks = marks;
            Console.WriteLine("Marks are attached according to Word format generation rules");
            //Display
            marks.ForEach(i => Console.Write(i + " "));
        }

        public override void AttachName(string fullName)
        {
            _wordTranscript.FullName = fullName;
            Console.WriteLine($"Full Name {(fullName)} is attached according to Word format generation rules...");
        }

        public override void AttachStudentId(string id)
        {
            _wordTranscript.StudentId = id;
            Console.WriteLine($"Student Id Number {(id)} is attached according to Word format generation rules...");
        }

        public override void PutSignature(bool verified)
        {
            if (verified == true)
            {
                Console.WriteLine("\n\nSuccessfully generated (Word)!");
            }
            else
            {
                Console.WriteLine("\n\nYour request is not verified by university administration...\nPlease, contact Registrar's Office...");
            }
        }
        //returns the instance of transcript in pdf version
        public override Transcript GetTranscript()
        {
            return _wordTranscript;
        }
    }
}
