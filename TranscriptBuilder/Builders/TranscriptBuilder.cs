using System.Collections.Generic;
using TranscriptBuilder.Models;

namespace TranscriptBuilder.Builders
{
    /// <summary>
    /// Generic class that includes common methods 
    /// across any transcript format
    /// </summary>
    public abstract class TranscriptBuilder
    {
        public abstract void AttachStudentId(string id);
        public abstract void AttachName(string fullName);
        public abstract void AttachMarks(List<int> marks);
        public abstract void PutSignature(bool verified);

        public abstract Transcript GetTranscript();
    }
}
