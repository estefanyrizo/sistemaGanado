using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    public class Venta
    {
        private string codigo;
        private string fechaVenta;

        public Venta(string codigo, string fechaVenta)
        {
            this.codigo = codigo;
            this.fechaVenta = fechaVenta;
        }

        public string Codigo { get => codigo; set => codigo = value; }

        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }

    }

    public class DetalleVenta
    {
        private int cantidad;
        private double precio;

        public DetalleVenta(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public double Precio { get => precio; set => precio = value; }
    }

    public class TipoVenta
    {
        private string nombre;
        public TipoVenta(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

    }

}
