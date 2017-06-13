using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Wpf_Jugador
{
    public class DaoMySQL
    {
        MySqlConnection conexion;

        public bool Conectar(string server, string usuario, string bada, string password)
        {
            string cadenaConexion = "server=" + server + ";database=" + bada + ";uid=" + usuario + ";pwd=" + password + ";";
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return true;
            }
            catch (MySqlException)
            {

                throw;
            }
        }

        public bool Desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                    return conexion.State == System.Data.ConnectionState.Closed;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                
                throw;
            }
        }

        public ObservableCollection<Jugador> Seleccionar(int? id)
        {
            try
            {
                ObservableCollection<Jugador> resultado = new ObservableCollection<Jugador>();
                string orden;
                if (conexion != null)
                {
                    if (id == null)
                    {
                        orden = "select id, nombre, apellido, altura, capitan, puesto, fecha_alta, salario, equipo from jugador;";
                    }
                    else
                    {
                        orden = "select id, nombre, apellido, altura, capitan, puesto, fecha_alta, salario, equipo from jugador where id = " + id + ";";
                    }
                    MySqlCommand cmd = new MySqlCommand(orden, conexion);
                    MySqlDataReader lector = cmd.ExecuteReader();
                    Jugador unJugador;
                    while (lector.Read())
                    {
                        unJugador = new Jugador();
                        unJugador.Id = int.Parse(lector["id"].ToString());
                        unJugador.Nombre = lector["nombre"].ToString();
                        unJugador.Apellido = lector["apellido"].ToString();
                        unJugador.Altura = double.Parse(lector["altura"].ToString());
                        unJugador.Capitan = int.Parse(lector["capitan"].ToString());
                        unJugador.Puesto = int.Parse(lector["puesto"].ToString());
                        unJugador.FechaAlta = lector["fecha_alta"].ToString();
                        unJugador.Salario = double.Parse(lector["salario"].ToString());
                        unJugador.Equipo = int.Parse(lector["equipo"].ToString());
                        resultado.Add(unJugador);
                    }                 
                }
                return resultado;
            }
            catch (MySqlException)
            {
                
                throw;
            }
        }

        public bool Insertar(Jugador unJugador)
        {
 
        }
    }
}
