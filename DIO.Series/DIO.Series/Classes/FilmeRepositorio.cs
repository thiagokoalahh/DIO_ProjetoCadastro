using DIO.Series.Interfaces;
using System.Collections.Generic;

namespace DIO.Series.Classes
{
    // Baseada na classe SerieRepositorio
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilmes = new List<Filme>();

        public void Atualiza(int id, Filme obj)
        {
            listaFilmes[id] = obj;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere(Filme obj)
        {
            listaFilmes.Add(obj);
        }

        public List<Filme> Lista()
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}
