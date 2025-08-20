using System;
using System.Collections.Generic;

namespace proyecto_DirectorioEmp
{
    class Program
    {
        static List<Persona> directorio = new List<Persona>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA POO TAREA 6.1 ===");
            Console.WriteLine("¡Bienvenido al sistema de gestión de personas!");

            int opcion;
            do
            {
                MostrarMenu();
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        RegistrarPersona();
                        break;
                    case 2:
                        MostrarTodasLasPersonas();
                        break;
                    case 3:
                        BuscarPersona();
                        break;
                    case 4:
                        Console.WriteLine("\n¡Gracias por usar el sistema!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Registrar nueva persona");
            Console.WriteLine("2. Mostrar todas las personas");
            Console.WriteLine("3. Buscar persona por ID");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción: ");
        }

        static int LeerOpcion()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                return 0;
            }
        }

        static void RegistrarPersona()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTRAR NUEVA PERSONA ===\n");

            // Datos personales
            Console.Write("Número de ID: ");
            string numeroID = Console.ReadLine();

            Console.Write("Nombres: ");
            string nombres = Console.ReadLine();

            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
            DateTime fechaNacimiento;
            if (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
            {
                fechaNacimiento = DateTime.Now.AddYears(-25); // Valor por defecto
            }

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Celular: ");
            string celular = Console.ReadLine();

            Console.Write("País: ");
            string pais = Console.ReadLine();

            Console.Write("Ciudad: ");
            string ciudad = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            Console.Write("Profesión: ");
            string profesion = Console.ReadLine();

            // Crear la persona
            Persona persona = new Persona(numeroID, nombres, apellidos, fechaNacimiento,
                                        telefono, celular, pais, ciudad, direccion, profesion);

            // Agregar grados académicos
            RegistrarGrados(persona);

            // Agregar cargos laborales
            RegistrarCargos(persona);

            // Agregar al directorio
            directorio.Add(persona);

            Console.WriteLine($"\n✓ Persona {persona.ToString()} registrada exitosamente!");
        }

        static void RegistrarGrados(Persona persona)
        {
            Console.WriteLine("\n--- REGISTRAR GRADOS ACADÉMICOS ---");
            Console.Write("¿Cuántos grados académicos desea registrar? ");

            int cantidadGrados;
            if (!int.TryParse(Console.ReadLine(), out cantidadGrados) || cantidadGrados < 0)
            {
                cantidadGrados = 0;
            }

            for (int i = 0; i < cantidadGrados; i++)
            {
                Console.WriteLine($"\nGrado #{i + 1}:");

                Console.Write("Número de grado: ");
                int numeroGrado = int.TryParse(Console.ReadLine(), out numeroGrado) ? numeroGrado : i + 1;

                Console.Write("Nivel educativo: ");
                string nivelEducativo = Console.ReadLine();

                Console.Write("Institución: ");
                string institucion = Console.ReadLine();

                Console.Write("Nombre del título: ");
                string nombreTitulo = Console.ReadLine();

                Console.Write("Fecha de inicio (dd/mm/yyyy): ");
                DateTime fechaInicio;
                if (!DateTime.TryParse(Console.ReadLine(), out fechaInicio))
                {
                    fechaInicio = DateTime.Now.AddYears(-4);
                }

                Console.Write("Fecha final (dd/mm/yyyy): ");
                DateTime fechaFinal;
                if (!DateTime.TryParse(Console.ReadLine(), out fechaFinal))
                {
                    fechaFinal = DateTime.Now;
                }

                Console.Write("Tipo de grado: ");
                string tipoGrado = Console.ReadLine();

                Console.Write("Fecha de expiración (dd/mm/yyyy): ");
                DateTime fechaExpiracion;
                if (!DateTime.TryParse(Console.ReadLine(), out fechaExpiracion))
                {
                    fechaExpiracion = DateTime.Now.AddYears(10);
                }

                Console.Write("País: ");
                string paisGrado = Console.ReadLine();

                Grado grado = new Grado(numeroGrado, nivelEducativo, institucion, nombreTitulo,
                                      fechaInicio, fechaFinal, tipoGrado, fechaExpiracion, paisGrado);

                persona.AgregarGrado(grado);
                Console.WriteLine("✓ Grado agregado exitosamente!");
            }
        }

        static void RegistrarCargos(Persona persona)
        {
            Console.WriteLine("\n--- REGISTRAR EXPERIENCIA LABORAL ---");
            Console.Write("¿Cuántos cargos laborales desea registrar? ");

            int cantidadCargos;
            if (!int.TryParse(Console.ReadLine(), out cantidadCargos) || cantidadCargos < 0)
            {
                cantidadCargos = 0;
            }

            for (int i = 0; i < cantidadCargos; i++)
            {
                Console.WriteLine($"\nCargo #{i + 1}:");

                Console.Write("Número de cargo: ");
                int numeroCargo = int.TryParse(Console.ReadLine(), out numeroCargo) ? numeroCargo : i + 1;

                Console.Write("Título del cargo: ");
                string titulo = Console.ReadLine();

                Console.Write("Fecha de inicio (dd/mm/yyyy): ");
                DateTime fechaInicio;
                if (!DateTime.TryParse(Console.ReadLine(), out fechaInicio))
                {
                    fechaInicio = DateTime.Now.AddYears(-2);
                }

                Console.Write("Fecha final (dd/mm/yyyy): ");
                DateTime fechaFinal;
                if (!DateTime.TryParse(Console.ReadLine(), out fechaFinal))
                {
                    fechaFinal = DateTime.Now;
                }

                Console.Write("¿Es empleo actual? (s/n): ");
                bool empleoActual = Console.ReadLine().ToLower().StartsWith("s");

                Console.Write("Empresa: ");
                string empresa = Console.ReadLine();

                Console.Write("Salario: ");
                decimal salario;
                if (!decimal.TryParse(Console.ReadLine(), out salario))
                {
                    salario = 0;
                }

                Console.Write("Detalles adicionales: ");
                string detalles = Console.ReadLine();

                Cargo cargo = new Cargo(numeroCargo, titulo, fechaInicio, fechaFinal,
                                      empleoActual, empresa, salario, detalles);

                persona.AgregarCargo(cargo);
                Console.WriteLine("✓ Cargo agregado exitosamente!");
            }
        }

        static void MostrarTodasLasPersonas()
        {
            Console.Clear();
            Console.WriteLine("=== TODAS LAS PERSONAS REGISTRADAS ===\n");

            if (directorio.Count == 0)
            {
                Console.WriteLine("No hay personas registradas en el sistema.");
                return;
            }

            Console.WriteLine($"Total de personas: {directorio.Count}\n");

            for (int i = 0; i < directorio.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {directorio[i].ToString()}");
                Console.WriteLine($"   Profesión: {directorio[i].GetProfesion()}");
                Console.WriteLine($"   Ubicación: {directorio[i].GetCiudad()}, {directorio[i].GetPais()}");
                Console.WriteLine($"   Grados: {directorio[i].GetGrados().Count}, Cargos: {directorio[i].GetCargos().Count}");
                Console.WriteLine();
            }
        }

        static void BuscarPersona()
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR PERSONA POR ID ===\n");

            Console.Write("Ingrese el ID de la persona a buscar: ");
            string idBuscar = Console.ReadLine();

            Persona personaEncontrada = null;
            foreach (var persona in directorio)
            {
                if (persona.GetNumeroID().Equals(idBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    personaEncontrada = persona;
                    break;
                }
            }

            if (personaEncontrada != null)
            {
                Console.WriteLine("¡Persona encontrada!");
                personaEncontrada.MostrarInformacion();
            }
            else
            {
                Console.WriteLine($"No se encontró ninguna persona con ID: {idBuscar}");
            }
        }
    }
}