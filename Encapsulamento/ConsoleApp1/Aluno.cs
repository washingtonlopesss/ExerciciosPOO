namespace FluxoPrincipal
{
    class Aluno
    {
        private string? _nome;
        private string? _sobrenome;

        public string Nome
        {
            set { _nome = value; }
        }

        public string Sobrenome
        {
            set { _sobrenome = value; }
        }

        public Aluno()
        {
            _nome = "\nAdicione um nome";
            _sobrenome = "[ERRO!]\n";
        }

        public string GetExibirAluno()
        {
            return _nome + " " + _sobrenome;
        }

        public override string ToString()
        {
            return GetExibirAluno();
        }
    }
}