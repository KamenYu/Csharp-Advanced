namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IStreamable stream; // this does not follow O/C besause adding new classes like Music f.e. breaks close for modification rule

        public Progress(IStreamable stream)
        {
            this.stream = stream;
        }

        public int CurrentPercent()
        {
            return this.stream.Sent * 100 / this.stream.Length;
        }
    }
}
