using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    class Ganado
    {
        public Ganado(string codigoG, string nombreG, string razaG)
        {
            codigo = codigoG;
            nombre = nombreG;
            raza = razaG;
            
        }

        private string codigo;
        private string nombre;
        private string raza;
        private string color;
        private double tamaño;
        private double peso;
        private string fecha_nacimiento;

        public Ganado(string codigo, string nombre, string raza, string color, double tamaño, double peso, string fecha_nacimiento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.raza = raza;
            this.color = color;
            this.tamaño = tamaño;
            this.peso = peso;
            this.fecha_nacimiento = fecha_nacimiento;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Color { get => color; set => color = value; }
        public double Tamaño { get => tamaño; set => tamaño = value; }
        public double Peso { get => peso; set => peso = value; }

        public void ListarDatos()
        {
            Console.WriteLine($"\nCodigo: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Raza: {Raza}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamaño}");
            Console.WriteLine($"Peso: {Peso}");
        }

    }
}
