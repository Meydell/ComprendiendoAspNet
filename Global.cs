using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComprendiendoAspNet
{
    public class Global
    {
        //Definimos la lista y la iniciamos con valores
        public static List<Region> Regiones = new List<Region>()
        {
            new Region(1,"Pacífico", "Clima Tropical y Soleado"),
            new Region(2,"Central", "Clima de Montaña y Fresco"),
            new Region(3,"Atlántico", "Costa Caribe del país, rica en gastronomía")
        };

        //Definimos la lista y la iniciamos con valores
        public static List<Departamento> Departamentos = new List<Departamento>()
        {
            new Departamento(1,"Managua", 1),
            new Departamento(2,"León", 1),
            new Departamento(3,"Masaya", 1),
            new Departamento(4,"Matagalpa", 2),
            new Departamento(5,"Estelí", 2),
            new Departamento(6,"RAAS", 3),
            new Departamento(7,"RAAN", 3),
        };

        //Definimos la Lista de los municipios
        public static List<Municipio> Municipios = new List<Municipio>()
        {
            new Municipio(1,"El Crucero",1222,1),
            new Municipio(2,"Ciudad Sandino",800,1)
        };
        //Creamos la Estructura de los municipios
        public class Municipio
        {
            int id;
            string nombre;
            decimal extension;
            int idDepartamento;

            public Municipio(int id, string nombre, decimal extension, int idDepartamento)
            {
                this.id = id;
                this.nombre = nombre;
                this.extension = extension;
                this.idDepartamento = idDepartamento;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public decimal Extension { get => extension; set => extension = value; }
            public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        }
        //Definimos la estructura
        public class Departamento
        {
            int id;
            string nombre;
            int idRegion;

            public Departamento(int id, string nombre, int idRegion)
            {
                //Definimos los campos
                this.id = id;
                this.nombre = nombre;
                this.idRegion = idRegion;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int IdRegion { get => idRegion; set => idRegion = value; }
        }
        public class Region
        {
            int id;
            string nombre;
            string descripcion;

            public Region(int id, string nombre, string descripcion)
            {
                this.id = id;
                this.nombre = nombre;
                this.descripcion = descripcion;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
        }
    }
}