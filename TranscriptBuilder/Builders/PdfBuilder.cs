using System;
using System.Collections.Generic;
using TranscriptBuilder.Models;

namespace TranscriptBuilder.Builders
{
    public class PdfBuilder : TranscriptBuilder
    {
        private PdfTranscript _pdfTranscript;
        public PdfBuilder()
        {
            _pdfTranscript = new PdfTranscript();
        }

        public override void AttachMarks(List<int> marks)
        {
            _pdfTranscript.Marks = marks;
            Console.WriteLine("Marks are attached according to PDF generation rules");
            //Display
            marks.ForEach(i => Console.Write(i + " "));
        }

        public override void AttachName(string fullName)
        {
            _pdfTranscript.FullName = fullName;
            Console.WriteLine($"Full Name {(fullName)} is attached according to PDF generation rules...");
        }

        public override void AttachStudentId(string id)
        {
            _pdfTranscript.StudentId = id;
            Console.WriteLine($"Student Id Number {(id)} is attached according to PDF generation rules...");
        }

        public override void PutSignature(bool verified)
        {
            if (verified == true)
            {
                Console.WriteLine("\n\nSuccessfully generated (PDF)!");
            }
            else
            {
                Console.WriteLine("\n\nYour request is not verified by university administration...\nPlease, contact Registrar's Office...");
            }
        }
        //returns the instance of transcript in pdf version
        public override Transcript GetTranscript()
        {
            return _pdfTranscript;
        }
    }
}
