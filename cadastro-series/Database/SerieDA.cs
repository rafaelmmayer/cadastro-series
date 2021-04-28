using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace cadastro_series.Database
{
    public class SerieDA : DataAccessBase
    {
        public List<Serie> SelectSeries()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Serie>($"select * from Series", new DynamicParameters());
                return output.ToList();
            }
        }

        public Serie SelectSerie(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QueryFirstOrDefault<Serie>($"select * from Series where id={id}", new DynamicParameters());
                return output;
            }
        }

        public void InsertSerie(Serie serie)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Execute("insert into Series (Genero, Titulo, Descricao, Ano) values (@Genero, @Titulo, @Descricao, @Ano)", serie);
            }
        }

        public void DeleteSerie(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Execute($"delete from Series where Id={id}");
            }
        }

        public void UpdateSerie(int id, Serie serie)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Execute($"update Series set Genero=@Genero, Titulo=@Titulo, Descricao=@Descricao, Ano=@Ano where id={id}", serie); 
            }
        }
    }
}
