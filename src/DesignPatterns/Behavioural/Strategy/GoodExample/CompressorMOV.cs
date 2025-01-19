namespace DesignPatterns.src.DesignPatterns.Behavioural.Strategy.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MOV");
        }
    }
}