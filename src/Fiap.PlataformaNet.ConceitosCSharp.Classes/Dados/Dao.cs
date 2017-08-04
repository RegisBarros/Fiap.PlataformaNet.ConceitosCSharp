using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fiap.PlataformaNet.ConceitosCSharp.Dados.Dados
{
    public abstract class Dao<T>
    {
        //protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\fundamentosNet\DBEVENTOS\DBEVENTOS.mdf;Integrated Security=True;Connect Timeout=30";

        protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\reginaldo\fundamentosNet\Fiap.PlataformaNet.ConceitosCSharp\database\DBEVENTOS.mdf;Integrated Security=True;Connect Timeout=30";

        protected SqlConnection cn;
        protected SqlCommand cmd;
        protected SqlDataReader reader;

        public abstract void Incluir(T elemeto);

        public abstract T Buscar(int id);

        public abstract IEnumerable<T> Listar(params int[] id);
    }
}
