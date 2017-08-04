using Fiap.PlataformaNet.ConceitosCSharp.Dados;
using Fiap.PlataformaNet.ConceitosCSharp.Dados.Dados;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Fiap.PlataformaNet.ConceitosCSharp.Classes.Dados
{
    public class DaoConvidado : Dao<Convidado>
    {
        public override void Incluir(Convidado convidado)
        {
            var sql = "INSERT INTO TBConvidados VALUES (@IDEVENTO, @NOME, @EMAIL)";

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IDEVENTO", convidado.InfoEvento.Id);
                    cmd.Parameters.AddWithValue("@NOME", convidado.Nome);
                    cmd.Parameters.AddWithValue("@EMAIL", convidado.Email);

                    cmd.ExecuteNonQuery();
                }

                cn.Close();
            }
        }

        public override Convidado Buscar(int id)
        {
            var sql = "SELECT ID, IDEVENTO, NOME, EMAIL FROM TBConvidados WHERE ID = @ID";

            Convidado convidado = null;

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", id);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        convidado = new Convidado()
                        {
                            Id = (int)reader["ID"],
                            Nome = (string)reader["NOME"],
                            Email = (string)reader["EMAIL"],
                            InfoEvento = new Evento()
                            {
                                Id = (int)reader["IDEVENTO"]
                            }
                        };
                    }

                    cn.Close();
                }
            }

            return convidado;
        }

        public override IEnumerable<Convidado> Listar(params int[] id)
        {
            var sql = "SELECT ID, IDEVENTO, NOME, EMAIL FROM TBConvidados";

            var convidados = new List<Convidado>();

            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cn.Open();

                    cmd.Parameters.Clear();

                    if (id.Any())
                    {
                        sql += " WHERE IDEVENTO = @IDEVENTO";

                        cmd.Parameters.AddWithValue("IDEVENTO", id[0]);
                    }

                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var c = new Convidado()
                        {
                            Id = (int)reader["ID"],
                            Nome = (string)reader["NOME"],
                            Email = (string)reader["EMAIL"],
                            InfoEvento = new Evento()
                            {
                                Id = (int)reader["IDEVENTO"]
                            }
                        };

                        convidados.Add(c);
                    }

                    cn.Close();
                }
            }

            return convidados;
        }
    }
}
