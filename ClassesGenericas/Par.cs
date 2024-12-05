using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{
    public class Par <T1, T2>
    {
        public T1 nome;
        public T2 idade;

        public Par(T1 nome, T2 idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
