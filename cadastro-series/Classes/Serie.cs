using cadastro_series.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_series
{
    public class Serie : ClasseBase
    {
        public int Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }


        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {Genero}\n";
            retorno += $"Título: {Titulo}\n";
            retorno += $"Descrição: {Descricao}\n";
            retorno += $"Ano de Início: {Ano}\n";
            return retorno;
        }
    }
}
