using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Pratica
{
    class ModeloRoupa
    {
        public Cliente cadastroCliente = new Cliente();
        public string tipo;
        public string cor;

        public string genero(char opcaoG)
        {
            if(opcaoG == 'M')
            {
                return "O gênero é masculino";
            }
            else
            {
                return "O gênero é feminino";
            }
        }

        public int tamanho;
    }
}
