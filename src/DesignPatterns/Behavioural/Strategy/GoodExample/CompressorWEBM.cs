namespace DesignPatterns.src.DesignPatterns.Behavioural.Strategy.GoodExample
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using WebM");
        }
    }
}