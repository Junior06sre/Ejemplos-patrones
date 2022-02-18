using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class Productos
    {
        public string Name { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }

        public Productos(string name, double precio, string categoria)
        {
            Name = name;
            Precio = precio;
            Categoria = categoria;
        }

        public Productos() { }

        public void EntradaInv(int cantidad)
        {
            Cantidad += cantidad;
        }

        public void SalidaInv(int cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}
