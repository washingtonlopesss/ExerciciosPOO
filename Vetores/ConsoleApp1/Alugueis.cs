namespace Fluxo
{
    class Alugueis
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int? Quart { get; set; }

        public override string ToString()
        {
            return Quart + ", " + Nome + ", " + Email;
        }
    }
}