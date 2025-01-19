namespace DesignPatterns.src.DesignPatterns.Behavioural.Strategy.GoodExample
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MP4");
        }
    }
}