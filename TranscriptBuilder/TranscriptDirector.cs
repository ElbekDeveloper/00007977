using TranscriptBuilder.Models;

namespace TranscriptBuilder
{
    public class TranscriptDirector
    {
        private Builders.TranscriptBuilder _transcriptBuilder;

        public TranscriptDirector(Builders.TranscriptBuilder transcriptBuilder)
        {
            _transcriptBuilder = transcriptBuilder;
        }
        /// <summary>
        /// Constructs specific model based on generic one
        /// </summary>
        /// <param name="transcript">Model data from database</param>
        /// <param name="verified">Verification status from administration</param>
        public void Construct(Transcript transcript, bool verified)
        {
            _transcriptBuilder.AttachStudentId(transcript.StudentId);
            _transcriptBuilder.AttachName(transcript.FullName);
            _transcriptBuilder.AttachMarks(transcript.Marks);
            _transcriptBuilder.PutSignature(verified);

            _transcriptBuilder.GetTranscript();
        }

    }
}
