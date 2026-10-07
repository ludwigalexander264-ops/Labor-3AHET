






namespace ChessComandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turm turm = new Turm(Figur.Color.BLACK, 8, 'A');
            turm.MakeRandomMove();
        }
    }
}
