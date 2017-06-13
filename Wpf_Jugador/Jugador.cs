using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Jugador
{
    public class Jugador
    {
        int? _id;
        string _nombre;
        string _apellido;
        double? _altura;
        int? _capitan;
        int? _puesto;
        string _fechaAlta;
        double? _salario;
        int _equipo;

        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public double? Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        
        public int? Capitan
        {
            get { return _capitan; }
            set { _capitan = value; }
        }
        
        public int? Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }
        
        public string FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
        
        public double? Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }
        
        public int Equipo
        {
            get { return _equipo; }
            set { _equipo = value; }
        }
    }
}
