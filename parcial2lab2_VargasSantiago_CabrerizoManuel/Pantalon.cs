using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_VargasSantiago_CabrerizoManuel
{
    class Pantalon : Prenda
    {
        private Boolean bermuda;

        public Pantalon(int cantidad, float precio, String calidad, Boolean bermuda) : base(cantidad, precio, calidad)
        {
            this.bermuda = bermuda;
        }

        public bool Bermuda
        {
            get
            {
                return bermuda;
            }

            set
            {
                bermuda = value;
            }
        }

        public override void calcularPrecio()
        {
            base.calcularPrecio();

            if (bermuda == true)
            {
                precio -= precio * 0.2f;
            }
        }
    }
}
