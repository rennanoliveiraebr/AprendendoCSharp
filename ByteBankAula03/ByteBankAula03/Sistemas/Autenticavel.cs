using ByteBankAula03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAula03.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
