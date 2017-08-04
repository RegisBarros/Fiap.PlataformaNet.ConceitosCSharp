using System;
using System.Collections.Generic;

namespace Fiap.PlataformaNet.ConceitosCSharp.Dados
{
    public class Evento
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public string Responsavel { get; set; }

        public IEnumerable<Convidado> Convidados { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - Descricao: {Descricao} - Data: {Data:dd/MM/yyyy}";
        }
    }
}
