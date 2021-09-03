using System;
using System.Collections.Generic;
using ProjetoSeries.Interfaces;

namespace ProjetoSeries
{
    public class SerieRepo : IRepo<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie obj)
        {
            listaSerie[id] = obj;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie obj)
        {
            listaSerie.Add(obj);
        }

        public List<Serie> Lista()
        {
            retorn listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}