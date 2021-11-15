using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    public class Compra
    {
        private string codigo;
        private string fechaCompra;

        public Compra(string codigo, string fechaCompra)
        {
            this.codigo = codigo;
            this.fechaCompra = fechaCompra;
        }

        public string Codigo { get => codigo; set => codigo = value; }

        public string FechaCompra { get => fechaCompra; set => fechaCompra = value; }

    }

    public class DetalleCompra
    {
        private int cantidad;
        private double precio;

        public DetalleCompra(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public double Precio { get => precio; set => precio = value; }
    }

    public class TipoCompra
    {
        private string nombre;
        public TipoCompra(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

    }

}