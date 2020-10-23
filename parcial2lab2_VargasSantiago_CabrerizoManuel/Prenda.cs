using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_VargasSantiago_CabrerizoManuel
{
    abstract class Prenda 
    {
        protected int cantidad;
        protected float precio;
        protected String calidad;
        
        public Prenda(int cantidad, float precio, String calidad)
        {
            this.cantidad = cantidad;
            this.precio = precio * cantidad;
            this.calidad = calidad;
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Calidad
        {
            get
            {
                return calidad;
            }

            set
            {
                calidad = value;
            }
        }

        public virtual void calcularPrecio()
        {
            if (Calidad == "Premium")
            {
                precio += precio * 0.3f;
            }           
        }
    }
}
