using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_VargasSantiago_CabrerizoManuel
{
    class Camisa : Prenda
    {
        private Boolean mangaCorta;

        public Camisa(int cantidad, float precio, String calidad, Boolean mangaCorta) : base(cantidad, precio, calidad)
        {
            this.mangaCorta = mangaCorta;
        }

        public bool MangaCorta
        {
            get
            {
                return mangaCorta;
            }

            set
            {
                mangaCorta = value;
            }
        }

        public override void calcularPrecio()
        {
            base.calcularPrecio();

            if (mangaCorta == true)
            {
                precio -= precio * 0.1f;
            }
        }
    }
}
