using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion_base
{
    public class Pokemon_base
    {


        public List<Pokemon> Listar()
        {
        
        //Si no pongo esto dentro de una funcion que retorne una lista
        //No funciona 
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        SqlDataReader lector;
        List<Pokemon> RegistrosDeLaBase = new List<Pokemon>();    

            try
            {
                Conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = "select POKEMONS.Numero, POKEMONS.Nombre, POKEMONS.Descripcion, ELEMENTOS.Descripcion from POKEMONS , ELEMENTOS where POKEMONS.id = ELEMENTOS.Id";
                Command.Connection = Conexion;
                Conexion.Open();    

                lector = Command.ExecuteReader();


                while (lector.Read())
                {
                    Pokemon Datos = new Pokemon();
                    Datos.Numero = lector.GetInt32(0);
                    Datos.Nombre = (string)lector["Nombre"];
                    Datos.Descripcion = (string)lector["Descripcion"];
                    Datos.Tipo = new Elemento();
                    Datos.Tipo.Descripcion = (string)lector["Tipo"];

                    RegistrosDeLaBase.Add(Datos);

                }

                Conexion.Close();
                return RegistrosDeLaBase;
            }
            catch (Exception ex)
            {
                throw;
            }            
                          

        }




        


    }
}
