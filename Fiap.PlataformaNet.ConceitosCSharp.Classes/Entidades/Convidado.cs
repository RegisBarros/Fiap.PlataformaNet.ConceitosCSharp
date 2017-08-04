namespace Fiap.PlataformaNet.ConceitosCSharp.Dados
{
    public class Convidado
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Evento InfoEvento { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Nome} - E-Mail: {Email}";
        }
    }
}
