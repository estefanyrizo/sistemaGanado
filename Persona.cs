using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;

        public Persona(string nombre, string apellido, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public void ListarDatos()
        {
            Console.WriteLine($"\nNombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }

    public class Cliente : Persona
    {
        public Cliente(string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido, direccion, telefono)
        {

        }

    }

    public class Proveedor : Persona
    {
        public Proveedor(string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido, direccion, telefono)
        {

        }

    }

    public class Usuario : Persona
    {
        private string username;
        private string contraseña;

        public Usuario(string username, string contraseña, string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido, direccion, telefono)
        {
            this.username = username;
            this.contraseña = contraseña;
        }

        public string Username { get => username; set => username = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

    }

    public class Administrador : Usuario
    {
        public Administrador(string username, string contraseña, string nombre, string apellido, string direccion, string telefono) : base(username, contraseña, nombre, apellido, direccion, telefono)
        {

        }

        public void Menu()
        {
            Console.WriteLine("\n\t Menú de opciones\n");
            Console.WriteLine("1. Gestionar ganado");
            Console.WriteLine("2. Gestionar usuario");
            Console.WriteLine("3. Gestionar cliente");
            Console.WriteLine("4. Gestionar provedor");
            Console.WriteLine("5. Gestionar compra");
            Console.WriteLine("6. Gestionar venta");
        }
    }

    public class Trabajador : Usuario
    {
        public Trabajador(string username, string contraseña, string nombre, string apellido, string direccion, string telefono) : base(username, contraseña, nombre, apellido, direccion, telefono)
        {

        }

        public void Menu()
        {
            Console.WriteLine("\n\t Menú de opciones\n");
            Console.WriteLine("1. Gestionar ganado");
            Console.WriteLine("2. Gestionar medicina");
            Console.WriteLine("3. Gestionar compra");
            Console.WriteLine("4. Gestionar venta");
        }
    }
}
