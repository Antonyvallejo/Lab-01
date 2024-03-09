using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Entidades.Abstracción
{
    public class Cliente : Empresa, ICliente
    {
        public int Cedula {  get; set; }

        public void AgregarCliente()
        {

        }

        public void ActualizarCliente()
        {
           
        }

        public void BuscarCliente()
        {
          
        }
    }
}
