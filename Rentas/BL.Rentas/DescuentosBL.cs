using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class DescuentosBL
    {
        public BindingList<int> ListaDescuentos { get; set; }

        public DescuentosBL()
        {
            ListaDescuentos = new BindingList<int>();

            ListaDescuentos.Add(0);
            ListaDescuentos.Add(5);
            ListaDescuentos.Add(10);
            ListaDescuentos.Add(15);
            ListaDescuentos.Add(20);
        }

        public BindingList<int> ObtenerDescuentos()
        {
            return ListaDescuentos;
        }
    }
}
