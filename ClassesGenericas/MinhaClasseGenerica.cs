using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    public class MinhaClasseGenerica<T>
    {
        public T _valor;

        public MinhaClasseGenerica(T valor)
        {
            _valor = valor;
        }
        public T ObterValor()
        {
            return _valor;
        }

        public void MostrarTipo()
        {
            Console.WriteLine($"O tipo da classe é: {typeof(T)}");
        }
    }
}
