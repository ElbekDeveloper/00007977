using System;
using System.Collections.Generic;
using TranscriptBuilder.Builders;
using TranscriptBuilder.Models;

namespace TranscriptBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating dummy data 
            //In real life, entity framework would bring it from database
            Transcript dummyTranscriptData = new PdfTranscript
            {
                StudentId = "00007777",
                FullName = "John Doe",
                Marks = new List<int> { 80, 93, 67}
            };
            //Image that student has requested pdf format
            PdfBuilder pdfBuilder = new PdfBuilder();
            TranscriptDirector director = new TranscriptDirector(pdfBuilder);
            director.Construct(dummyTranscriptData, true);
            Console.WriteLine("------------------------");

            //Creating dummy data 
            //In real life, entity framework would bring it from database
            Transcript sameDummyData = new WordTranscript
            {
                StudentId = "00007777",
                FullName = "John Doe",
                Marks = new List<int> { 80, 93, 67 }
            };
            //Image that student has requested pdf format
            WordBuilder wordBuilder = new WordBuilder();
            TranscriptDirector newDirector = new TranscriptDirector(wordBuilder);
            newDirector.Construct(sameDummyData, true);

            Console.WriteLine("------------------------");

            Console.ReadKey();
        }
    }
}
