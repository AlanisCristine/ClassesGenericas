using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas;

public class Pilha<T>
{
    private List<T> Itens = new List<T>();
    
    public void Push(T item) //Adicionar
    {
        Itens.Add(item);
    }
    public void Pop()
    {
        Itens.RemoveAt(Itens.Count - 1);
    }
    public void MostrarItens()
    {
        foreach (T Item in Itens)
        {
            Console.WriteLine(Item);
        }
    }



}

