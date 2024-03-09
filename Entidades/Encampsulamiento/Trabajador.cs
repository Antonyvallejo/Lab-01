using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Entidades.Encampsulamiento
{
    public class Trabajador
    {
        public string Nombre { get; set; }

        public int ID { get; set; }

        public double Salario { get; set; }

        public double HorasTrabajadas { get; set; }

        public void RegitrarNombre()//Metodo que se puede acceder en otras clases
        {

        }
        private double CalcularSalario(double salario)//Metodo encampusulada solo de la clase Trabajador se puede acceder a está clase
        {
            HorasTrabajadas = 8;
            double TotalPago=HorasTrabajadas* Salario;

            return TotalPago;
        }
    }
}
