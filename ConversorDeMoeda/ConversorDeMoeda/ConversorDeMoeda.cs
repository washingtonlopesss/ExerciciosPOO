namespace Escopo
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double Cotacao;
        public static double QTD;
        public static double CalcularValor()
        {
            return (Cotacao * QTD) + ((Cotacao * QTD) * IOF);
        }
    }
}
