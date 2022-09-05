﻿
using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT repoDT = new RepositorioDT();
        private static IRepositorioEquipo repoEquipo = new RepositorioEquipo();

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("___________Bienvenido______________");
                Console.WriteLine("(1) Insertar Muinicipio");
                Console.WriteLine("(2) Insertar Director Tecnico");
                Console.WriteLine("(3) Insertar Equipo");
                Console.WriteLine("(0) Salir");
                Console.WriteLine("Ingrese Opcion---------------------");
                opcion = Int32.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2: 
                        AddDT();
                        break;
                    case 3:
                        AddEquipo();
                        break;
                }
            } while (opcion != 0);

        }

        private static void AddMunicipio()
        {
            Console.WriteLine("Ingrese nombre del municipio");
            String nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre
            };

            repoMunicipio.AgregarMunicipio(municipio);

        }   

        private static void AddDT()
        {
            Console.WriteLine("Ingrese nombre DT");
            string nombre =  Console.ReadLine();
            Console.WriteLine("Ingrese documento");
            string documento = Console.ReadLine();
            Console.WriteLine("Ingrese numero de telefono");
            string numeroTlf = Console.ReadLine();
            var DT = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = numeroTlf
            };

            repoDT.AgregarDT(DT);
        }

        private static void AddEquipo()
        {
            Console.WriteLine("Ingrese nombre del equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ungrese el id del Municipio");
            int idMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese id del Director Tecnico");
            int idDT = Int32.Parse(Console.ReadLine());

            var equipo = new Equipo
            {
                Nombre = nombre,
            };

            repoEquipo.AgregarEquipo(equipo, idMunicipio, idDT);

            
        }

    }
}