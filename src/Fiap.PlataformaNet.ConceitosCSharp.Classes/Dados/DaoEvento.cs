using Fiap.PlataformaNet.ConceitosCSharp.Dados.Dados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fiap.PlataformaNet.ConceitosCSharp.Dados
{
    public class DaoEventos : Dao<Evento>
    {
        public override void Incluir(Evento evento)
        {
            var sql = "INSERT INTO TBEventos VALUES (@DATA, @DESCRICAO, @RESPONSAVEL)";

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@DATA", evento.Data);
                    cmd.Parameters.AddWithValue("@DESCRICAO", evento.Descricao);
                    cmd.Parameters.AddWithValue("@RESPONSAVEL", evento.Responsavel);

                    cmd.ExecuteNonQuery();
                }

                cn.Close();
            }
        }

        public override Evento Buscar(int id)
        {
            var sql = "SELECT ID, DATA, DESCRICAO FROM TBEventos Where ID = @ID";

            Evento evento = null;

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    cmd.Parameters.AddWithValue("@ID", id);

                    reader = cmd.ExecuteReader();

                    evento = new Evento()
                    {
                        Id = (int)reader["ID"],
                        Data = (DateTime)reader["DATA"],
                        Descricao = (string)reader["DESCRICAO"],
                        Responsavel = (string)reader["RESPONSAVEL"]
                    };
                } 
            }

            return evento;
        }

        public override IEnumerable<Evento> Listar(params int[] id)
        {
            var sql = "SELECT ID, DATA, DESCRICAO, RESPONSAVEL FROM TBEventos";

            var eventos = new List<Evento>();

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var e = new Evento()
                        {
                            Id = (int)reader["ID"],
                            Data = (DateTime)reader["DATA"],
                            Descricao = (string)reader["DESCRICAO"],
                            Responsavel = (string)reader["RESPONSAVEL"]
                        };

                        eventos.Add(e);
                    }
                } 
            }

            return eventos;
        }
    }
}
