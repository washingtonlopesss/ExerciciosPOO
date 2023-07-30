namespace FluxoPrincipal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento: ");
            DateTime dataDeHoje = DateTime.Now;
            TimeSpan calcularIdade = dataDeHoje.Subtract(DateTime.Parse(Console.ReadLine()));
            Console.Write("Sua idade é: " + calcularIdade.TotalDays / 365);
        }
    }
}