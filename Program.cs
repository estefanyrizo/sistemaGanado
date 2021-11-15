using System;

namespace sistemaGanado
{
    class Program
    {
        struct RegCompra
        {                  
            public Compra compra;
            public DetalleCompra detalleCompra;
            public TipoCompra tipoCompra;
            public Ganado[] ganadoComprado;
            public void CantCGanado (int cantidad)
            {
                ganadoComprado = new Ganado[cantidad];
            }
            public Usuario usuarioCompra;
            public Proveedor proveedor;
        }

        struct RegVenta
        {
            public Venta venta;
            public DetalleVenta detalleVenta;
            public TipoVenta tipoVenta;
            public Ganado[] ganadoVendido;
            public void CantVGanado(int cantidad)
            {
                ganadoVendido = new Ganado[cantidad];
            }
            public Usuario usuarioVenta;
            public Cliente cliente;

        }

        static RegCompra[] regCompra = new RegCompra[10];
        static RegVenta[] regVenta = new RegVenta[10];
        static Compra[] compras = new Compra[10];
        static Trabajador[] trabajadores = new Trabajador[10];
        static Administrador[] admins = new Administrador[10];
        static Proveedor[] proveedores = new Proveedor[10];
        static Cliente[] clientes = new Cliente[10];
        static Ganado[] ganado = new Ganado[10];
        static int cantAd = 1;
        static int cantTr = 0;
        static int cantCl = 0;
        static int cantPr = 0;
        static int cantGa = 0;
        static int cantComp = 0;
        static int cantVent = 0;
        static Usuario sesion;


        static void Pedir(string m, ref string n)
        {
            Console.WriteLine(m);
            n = Console.ReadLine();
        }

        static void Pedir(string m, ref int x)
        {
            Console.Write("{0} ", m);
            x = int.Parse(Console.ReadLine());
        }

        static void Pedir(string m, ref double x)
        {
            Console.Write("{0} ", m);
            x = double.Parse(Console.ReadLine());
        }

        static void Usuarios()
        {
            Console.WriteLine("\tHola, ¿Que cargo tienes?");
            Console.WriteLine("\n1.Administrador");
            Console.WriteLine("\n2.Trabajador");
        }

        static void Menu()
        {
            Console.WriteLine("\t Menú de opciones");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Listar");
            Console.WriteLine("4. Buscar");
            Console.WriteLine("5. Eliminar");
        }

        static int IniciarSesion(Usuario [] user, int n)
        {
            Console.WriteLine("\t Inicie sesion\n");
            string username = null;
            string contraseña = null;
            Pedir("Username: ", ref username);
            Pedir("Contraseña: ", ref contraseña);

            for(int i = 0; i < n; i++)
            {
                if (user[i].Username == username && user[i].Contraseña == contraseña)
                {
                    sesion = user[i];
                    return i;                    
                }
            }

            return -1;
        }

        static void Administrador()
        {
            admins[0] = new Administrador("jrizo", "123", "Francisco Javier", "Rizo Rizo", "contiguo a hotel musun", "89060009");
            int sesion;
            int op = 0;
            int gest = 0;
            do
            {
                sesion = IniciarSesion(admins, cantAd);
                if (sesion == -1)
                {
                    Console.WriteLine("\nUsername o contraseña, incorrectos\n");
                }

            } while (sesion == -1);
            Console.Clear();
            do
            {
                admins[sesion].Menu();
                Pedir("\nIngrese el numero de su opcion: ", ref op);
               
                Console.Clear();

                if(op >= 1 && op < 7)
                {
                    Menu();
                    Pedir("\nIngrese el numero de su opcion: ", ref gest);
                }

                switch(op)
                {
                    case 1:
                        switch (gest)
                        {
                            case 1:
                                AgregarGanado();
                                break;
                            case 2:

                                break;
                            case 3:
                                Console.WriteLine("\nMostrando informacion del ganado");
                                for (int i = 0; i < cantGa; i++)
                                {
                                    ganado[i].ListarDatos();
                                }
                                break;

                            case 4:

                                string ganadoBus = null;
                                Pedir("Ingrese el nombre del animal a buscar: ", ref ganadoBus);
                                int ganBuscado = BuscarGanado(ganadoBus);
                                if (ganBuscado == -1)
                                    Console.WriteLine("\nAnimal no encontrado");
                                else
                                    ganado[ganBuscado].ListarDatos();
                            
                            break;

                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }
                        break;
                    case 2:
                        switch (gest)
                        {
                            case 1:
                                int user = 0;
                                Console.WriteLine("\nIngrese el tipo de usuario que desea ingresar");
                                Console.WriteLine("1. Administrador");
                                Console.WriteLine("2. Trabajador");
                                Pedir("Numero de su opcion: ", ref user);
                                Console.Clear();

                                if (user == 1)
                                    AgregarAdministrador();
                                else if (user == 2)
                                    AgregarTrabajador();
                                else
                                    Console.WriteLine("Opcion invalida");

                                break;
                            case 2:

                                break;
                            case 3:
                                int user1 = 0;
                                Console.WriteLine("\nIngrese el tipo de usuario que desea listar");
                                Console.WriteLine("1. Administrador");
                                Console.WriteLine("2. Trabajador");
                                Pedir("Numero de su opcion: ", ref user1);

                                if (user1 == 1)
                                {
                                    Console.WriteLine("\nMostrando usuarios administradores");
                                    for (int k = 0; k < cantAd; k++)
                                    {
                                        admins[k].ListarDatos();
                                    }
                                }

                                else if (user1 == 2)
                                {
                                    Console.WriteLine("\nMostrando usuarios trabajadorses");
                                    for (int k = 0; k < cantTr; k++)
                                    {
                                       trabajadores[k].ListarDatos();
                                    }
                                }

                                else
                                    Console.WriteLine("Opcion invalida");

                                break;

                            case 4:
                                int user3 = 0;
                                string usuario = null;
                                Console.WriteLine("\nIngrese el tipo de usuario que desea buscar");
                                Console.WriteLine("1. Administrador");
                                Console.WriteLine("2. Trabajador");
                                Pedir("Numero de su opcion: ", ref user3);
                                Pedir("Ingrese el username o nombre del usuario: ", ref usuario);

                                if (user3 == 1)
                                {
                                     int adminbuscado = BuscarAdministrador(usuario);
                                    if(adminbuscado == -1)
                                        Console.WriteLine("\nUsuario no encontrado");
                                    else
                                        admins[adminbuscado].ListarDatos();
                                }

                                else if (user3 == 2)
                                {
                                        int trabuscado = BuscarTrabajador(usuario);
                                    if (trabuscado == -1)
                                        Console.WriteLine("\nUsuario no encontrado");
                                    else
                                        trabajadores[trabuscado].ListarDatos();
                                }

                                else
                                    Console.WriteLine("Opcion invalida");
                                break;

                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }
                        break;
                    case 3:
                        switch (gest)
                        {
                            case 1:
                                AgregarCliente();
                                break;
                            case 2:

                                break;
                            case 3:
                                Console.WriteLine("\nMostrando clientes");
                                for(int i = 0; i < cantCl; i++)
                                {
                                    clientes[i].ListarDatos();
                                }
                            break;

                            case 4: 
                            break;
                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }
                        break;                    
                    case 4:
                        switch (gest)
                        {
                            case 1:
                                AgregarProveedor();
                                break;
                            case 2:

                                break;
                            case 3:
                                Console.WriteLine("\nMostrando proveedores");
                                for (int i = 0; i < cantPr; i++)
                                {
                                    proveedores[i].ListarDatos();
                                }
                                break;

                            case 4:
                                string proveedor = null;
                                Pedir("Ingrese el nombre del proovedor: ", ref proveedor);

                                int busqueda = BuscarProveedor(proveedor);

                                if (busqueda == -1)
                                    Console.WriteLine("Usuario no encontrado");
                                else
                                    proveedores[busqueda].ListarDatos();

                                break;
                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }

                        break;
                    case 5:
                        switch (gest)
                        {
                            case 1:
                                AgregarCompra();
                                break;
                            case 2:

                                break;
                            case 3:
                                MostrarCompras();
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }

                        break;
                    case 6:
                        switch (gest)
                        {
                            case 1:
                                AgregarVenta();
                                break;
                            case 2:

                                break;
                            case 3:
                                MostrarVentas();
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("\nIngrese una opcion valida\n");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida\n");
                        break;
                }

            } while (op != 7);
        }

        static void Trabajador()
        {
            int sesion;
            do
            {
                sesion = IniciarSesion(trabajadores, cantTr);
                if (sesion == -1)
                {
                    Console.WriteLine("\nUsername o contraseña, incorrectos\n");
                }


            } while (sesion == -1);
            Console.Clear();
            trabajadores[sesion].Menu();
        }

        static void MostrarCompras()
        {
            for(int i = 0; i < cantComp; i++)
            {
                Console.WriteLine("\nCodigo de la compra: " + regCompra[i].compra.Codigo);
                Console.WriteLine("Fecha de la compra: " + regCompra[i].compra.FechaCompra);
                Console.WriteLine("Proveedor: "+ regCompra[i].proveedor.Nombre);
                for (int j = 0; j < regCompra[i].ganadoComprado.Length; j++)
                {
                    Console.WriteLine("Codigo ganado: " + regCompra[i].ganadoComprado[i].Codigo);
                }
                Console.WriteLine("Usuario que hizo la compra: " + regCompra[i].usuarioCompra.Nombre);

            }
        }

        static void AgregarCompra()
        {
            string codigoCompra = null;
            string fechaCompra = null;
            string tipoCompra = null;
            int cantidad = 0;
            double precio = 0;
            double total = 0;
            string nomProveedor = null;
            string animal = null;
            int indanimal = 0;
            int proveedor = 0;

            Pedir("\nIngrese el codigo de la compra: ", ref codigoCompra);
            Pedir("Ingrese la fecha de la compra: ", ref fechaCompra);
            Pedir("Ingrese el tipo de compra: ", ref tipoCompra);
            Pedir("Ingrese la cantidad: ", ref cantidad);
            Pedir("Ingrese el precio:", ref precio);

            do
            {
                Pedir("Ingrese el nombre del proveedor: ", ref nomProveedor);

                proveedor = BuscarProveedor(nomProveedor);

                if(proveedor == -1)
                    Console.WriteLine($"Proveedor con el nombre {nomProveedor} no encontrado, trata de ser mas especifico");

            } while (proveedor == -1);



            Compra compra = new Compra(codigoCompra, fechaCompra);
            DetalleCompra detalle = new DetalleCompra(cantidad, precio);
            TipoCompra tipo = new TipoCompra(tipoCompra);
            regCompra[cantComp].compra = compra;
            regCompra[cantComp].detalleCompra = detalle;
            regCompra[cantComp].tipoCompra = tipo;
            regCompra[cantComp].proveedor = proveedores[proveedor];
            regCompra[cantComp].usuarioCompra = sesion;

            for (int i = 0; i < cantidad; i++)
            {
                do
                {
                    Pedir($"Ingrese el nombre o codigo del animal {i + 1}: ", ref animal);

                    indanimal = BuscarGanado(animal);

                    if (indanimal == -1)
                        Console.WriteLine($"Animal con el nombre o codigo {animal} no encontrado, trata de ser mas especifico");

                } while (indanimal == -1);

                regCompra[cantComp].CantCGanado(cantidad);
                regCompra[cantComp].ganadoComprado[i] = ganado[indanimal];

            }


            if (tipoCompra == "individual")
            {
                total = precio * cantidad;
                Console.WriteLine("\nEl total es: " + total);
            }

            cantComp++;             
           
        }

        static void MostrarVentas()
        {
            for (int i = 0; i < cantVent; i++)
            {
                Console.WriteLine("\nCodigo de la venta: " + regVenta[i].venta.Codigo);
                Console.WriteLine("Fecha de la venta: " + regVenta[i].venta.FechaVenta);
                Console.WriteLine("Cliente: " + regVenta[i].cliente.Nombre);
                for (int j = 0; j < regVenta[i].ganadoVendido.Length; j++)
                {
                    Console.WriteLine("Codigo ganado: " + regVenta[i].ganadoVendido[i].Codigo);
                }
                Console.WriteLine("Usuario que hizo la venta: " + regVenta[i].usuarioVenta.Nombre);

            }
        }

        static void AgregarVenta()
        {
            string codigoVenta= null;
            string fechaVenta = null;
            string tipoVenta = null;
            int cantidad = 0;
            double precio = 0;
            double total = 0;
            string nomCliente = null;
            string animal = null;
            int indanimal = 0;
            int cliente = 0;

            Pedir("\nIngrese el codigo de la venta: ", ref codigoVenta);
            Pedir("Ingrese la fecha de la venta: ", ref fechaVenta);
            Pedir("Ingrese el tipo de venta: ", ref tipoVenta);
            Pedir("Ingrese la cantidad: ", ref cantidad);
            Pedir("Ingrese el precio:", ref precio);

            do
            {
                Pedir("Ingrese el nombre del proveedor: ", ref nomCliente);

                cliente = BuscarCliente(nomCliente);

                if (cliente == -1)
                    Console.WriteLine($"Cliente con el nombre {nomCliente} no encontrado, trata de ser mas especifico");

            } while (cliente == -1);

            Venta venta = new Venta(codigoVenta, fechaVenta);
            DetalleVenta detalle = new DetalleVenta(cantidad, precio);
            TipoVenta tipo = new TipoVenta(tipoVenta);
            regVenta[cantVent].venta = venta;
            regVenta[cantVent].detalleVenta = detalle;
            regVenta[cantVent].tipoVenta = tipo;
            regVenta[cantVent].cliente = clientes[cliente];
            regVenta[cantVent].usuarioVenta = sesion;

            for (int i = 0; i < cantidad; i++)
            {
                do
                {
                    Pedir($"Ingrese el nombre o codigo del animal {i + 1}: ", ref animal);

                    indanimal = BuscarGanado(animal);

                    if (indanimal == -1)
                        Console.WriteLine($"Animal con el nombre o codigo {animal} no encontrado, trata de ser mas especifico");

                } while (indanimal == -1);

                regVenta[cantVent].CantVGanado(cantidad);
                regVenta[cantVent].ganadoVendido[i] = ganado[indanimal];

                cantVent++;

            }


            if (tipoVenta == "individual")
            {
                total = precio * cantidad;
                Console.WriteLine("\nEl total es: " + total);
            }


        }


        static void AgregarTrabajador()
        {
            string username = null;
            string contraseña = null;
            string nombre = null;
            string apellido = null;
            string direccion  = null;
            string telefono = null;

            do
            {
                Pedir("Ingrese el username que tendra el usuario: ", ref username);

                if (BuscarTrabajador(username) != -1)
                    Console.WriteLine("\nUsername ya en uso, intente nuevamente\n");

            } while (BuscarTrabajador(username) != -1);

            Pedir("Ingrese la contraseña: ", ref contraseña);
            Pedir("Ingrese el nombre del usuario: ", ref nombre);
            Pedir("Ingrese el apellido: ", ref apellido);
            Pedir("Ingrese la direccion: ", ref direccion);
            Pedir("Ingrese el telefono: ", ref telefono);

            trabajadores[cantTr] = new Trabajador(username, contraseña, nombre, apellido, direccion, telefono);
            cantTr++;

            Console.Clear();     
        }

        static int BuscarTrabajador(string trabajador)
        {
            for(int i = 0; i < cantTr; i++)
            {
                if (trabajador.ToLower() == trabajadores[i].Nombre.ToLower() || trabajador.ToLower() == trabajadores[i].Username.ToLower())
                {
                    return i;
                }
            }

            return -1;
        }

        static void AgregarAdministrador()
        {
            string username = null;
            string contraseña = null;
            string nombre = null;
            string apellido = null;
            string direccion = null;
            string telefono = null;

            do
            {
                Pedir("Ingrese el username que tendra el usuario: ", ref username);

                if(BuscarAdministrador(username) != -1)
                    Console.WriteLine("\nUsername ya en uso, intente nuevamente\n");

            } while (BuscarAdministrador(username) != -1);

            Pedir("Ingrese la contraseña: ", ref contraseña);
            Pedir("Ingrese el nombre del usuario: ", ref nombre);
            Pedir("Ingrese el apellido: ", ref apellido);
            Pedir("Ingrese la direccion: ", ref direccion);
            Pedir("Ingrese el telefono: ", ref telefono);

            admins[cantAd] = new Administrador(username, contraseña, nombre, apellido, direccion, telefono);
            cantAd++;

            Console.Clear();
        }

        static int BuscarAdministrador(string admin)
        {
            int i = 0;
            while (i < cantAd)
            {
                if (admin.ToLower() == admins[i].Nombre.ToLower() || admin.ToLower() == admins[i].Username.ToLower())
                {
                    return i;
                }
                else
                    i++;
            }

            return -1;
        }


        static void AgregarCliente()
        { 
            string nombre = null;
            string apellido = null;
            string direccion = null;
            string telefono = null;

            Pedir("Ingrese el nombre del cliente: ", ref nombre);
            Pedir("Ingrese el apellido: ", ref apellido);
            Pedir("Ingrese la direccion: ", ref direccion);
            Pedir("Ingrese el telefono: ", ref telefono);

            clientes[cantCl] = new Cliente(nombre, apellido, direccion, telefono);
            cantCl++;

            Console.Clear();
        }
        static int BuscarCliente(string cliente)
        {
            int i = 0;
            while (i < cantCl)
            {
                if (cliente.ToLower() == clientes[i].Nombre.ToLower())
                {
                    return i;
                }
                else
                    i++;
            }

            return -1;
        }

        static void AgregarProveedor()
        {
            string nombre = null;
            string apellido = null;
            string direccion = null;
            string telefono = null;

            Pedir("Ingrese el nombre del proveedor: ", ref nombre);
            Pedir("Ingrese el apellido: ", ref apellido);
            Pedir("Ingrese la direccion: ", ref direccion);
            Pedir("Ingrese el telefono: ", ref telefono);

            proveedores[cantPr] = new Proveedor(nombre, apellido, direccion, telefono);
            cantPr++;

            Console.Clear();
        }

        static int BuscarProveedor(string proveedor)
        {
            int i = 0;
            while (i < cantPr)
            {
                if (proveedor.ToLower() == proveedores[i].Nombre.ToLower())
                {
                    return i;
                }
                else
                    i++;
            }

            return -1;
        }


        static void AgregarGanado()
        {
            string codigo = null;
            string nombre = null;
            string raza = null;
            string color = null;
            double tamaño = 0;
            double peso = 0;
            string fecha_nacimiento = null;

            Pedir("\nIngrese el codigo del animal: ", ref codigo);
            Pedir("Ingrese el nombre: ", ref nombre);
            Pedir("Ingrese la raza: ", ref raza);
            Pedir("Ingrese el color: ", ref color);
            Pedir("Ingrese el tamaño: ", ref tamaño);
            Pedir("Ingrese el peso: ", ref peso);
            Pedir("Ingrese la fecha de nacimiento: ", ref fecha_nacimiento);

            ganado[cantGa] = new Ganado(codigo, nombre, raza, color, tamaño, peso, fecha_nacimiento);
            cantGa++;

            Console.Clear();
        }

        static int BuscarGanado(string ganadoBuscar)
        {
            int i = 0;
            while (i < cantGa)
            {
                if (ganadoBuscar.ToLower() == ganado[i].Codigo.ToLower() || ganadoBuscar.ToLower() == ganado[i].Nombre.ToLower())
                {
                    return i;
                }
                else
                    i++;
            }

            return -1;
        }

        static void Ejecutar()
        {

            int user = 0;

            do {
                Usuarios();
                Pedir("\nIngresa el numero de tu cargo: ", ref user);
                Console.Clear();
            } while (user != 1 && user != 2);

            if (user == 1)
            {
                Administrador();
            }

            else
            {        
                Trabajador();
            }

        }

        static void Main(string[] args)
        {
            Ejecutar();

        }

    }
}
