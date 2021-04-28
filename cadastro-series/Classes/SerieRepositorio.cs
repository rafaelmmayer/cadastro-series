using cadastro_series.Database;
using cadastro_series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private SerieDA database;
        private List<Serie> listaSeries;

        public SerieRepositorio()
        {
            database = new SerieDA();
        }

        public void Atualiza(int id, Serie serie)
        {
            database.UpdateSerie(id, serie);
        }

        public void Exclui(int Id)
        {
            database.DeleteSerie(Id);
        }

        public void Insere(Serie serie)
        {
            database.InsertSerie(serie);
        }

        public List<Serie> Lista()
        {
            listaSeries = database.SelectSeries();
            return listaSeries;
        }

        public Serie RetornaPorId(int id)
        {
            return database.SelectSerie(id);
        }
    }
}
