using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    public class ListaGenerica<T> where T : class //Falando que a lista genérica precisa ser uma classe
    {
        private List<T> Itens = new List<T>();
        public void Adicionar(T Item)
        {
            Itens.Add(Item);
        }
        public void MostrarItens()
        {
            foreach(T Item in Itens)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
