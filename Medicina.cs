using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    public class Medicina
    {
        private string nombre;
        private float precio;
        private string fechaAplicacion;
        private string fechaVencimiento;

        public Medicina(string nombre, float precio, string fechaAplicacion, string fechaVencimiento)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.fechaAplicacion = fechaAplicacion;
            this.fechaVencimiento = fechaVencimiento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public string FechaAplicacion { get => fechaAplicacion; set => fechaAplicacion = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }

        public void ListarDatos()
        {
            Console.WriteLine($"\nNombre: {nombre}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Fecha de Aplicacion: {fechaAplicacion}");
            Console.WriteLine($"fecha de Vencimiento: {fechaVencimiento}");
        }

        public void AgregarDetalleMedicina(int dosisEn_ml)
        {
            DetalleMedicina detalleMedicina = new DetalleMedicina(dosisEn_ml);
        }

        public void AgregarDetallePresentacion(string nombrePresentacion, string viaAplicacion, int contenidoEN_ml)
        {
            PresentacionMedicina presentacion = new PresentacionMedicina(nombrePresentacion, viaAplicacion, contenidoEN_ml);
        }
    }

    public class DetalleMedicina
    {
        private int dosis;

        public DetalleMedicina(int dosis)
        {
            this.dosis = dosis;
        }

        public int Dosis1 { get => dosis; set => dosis = value; }
    }

    public class PresentacionMedicina
    {
        private string nombrePresentacion;
        private string viaAplicacion;
        private int contenido;

        public PresentacionMedicina(string nombrePresentacion, string viaAplicacion, int contenido)
        {
            this.nombrePresentacion = nombrePresentacion;
            this.viaAplicacion = viaAplicacion;
            this.contenido = contenido;
        }

        public string NombrePresentacion { get => nombrePresentacion; set => nombrePresentacion = value; }
        public string ViaAplicacion { get => viaAplicacion; set => viaAplicacion = value; }
        public int Contenido { get => contenido; set => contenido = value; }
    }
}