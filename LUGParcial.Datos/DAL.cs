using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LUGParcial.Datos
{
    public class DAL
   {
        private readonly string strCon;
        private readonly SqlConnection cnnTransac;
        private SqlTransaction transaccion;
        private readonly List<SqlCommand> lTransacciones;

        public DAL()
        {
            strCon = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            cnnTransac = new SqlConnection(strCon);
            lTransacciones = new List<SqlCommand>();

            using (SqlConnection conTemp = new SqlConnection(strCon))
                conTemp.Open();
        }

        #region [ Métodos para ejecución con Comandos ]
        public bool TransacExec()
        {
            bool retorno = true;
            transaccion = null;

            try
            {
                cnnTransac.Open();
                transaccion = cnnTransac.BeginTransaction();
                foreach (SqlCommand comando in lTransacciones)
                {
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                retorno = false;
                throw new Exception("Falló la ejecución de la transacción: " + ex.Message);
            }
            finally
            {
                cnnTransac.Close();
                lTransacciones.Clear();
            }

            return retorno;
        }
        public void TransacAdd(string comando, params object[] parametros)
        {
            SqlCommand cmd;
            List<string> listaParametros = BuscarParametros(comando);

            if (parametros.Length != listaParametros.Count)
                throw new Exception("La cantidad de parámetros no coinciden");
            else
            {
                cmd = new SqlCommand(comando, cnnTransac);

                for (int i = 0; i < parametros.Length; i++)
                    cmd.Parameters.AddWithValue(listaParametros[i], parametros[i]);

                lTransacciones.Add(cmd);
            }
        }

        public int EjecutarNonQuery(string comando, params object[] parametros)
        {
            int filasAfectadas = 0;
            List<string> listaParametros = BuscarParametros(comando);

            if (parametros.Length != listaParametros.Count)
                throw new Exception("La cantidad de parámetros no coinciden");
            else
            {
                using (SqlConnection conTemp = new SqlConnection(strCon))
                {
                    conTemp.Open();

                    using (SqlCommand cmd = new SqlCommand(comando, conTemp))
                    {
                        for (int i = 0; i < listaParametros.Count; i++)
                            cmd.Parameters.AddWithValue(listaParametros[i], parametros[i]);                     

                        filasAfectadas = cmd.ExecuteNonQuery();
                    }
                }
            }

            return filasAfectadas;
        }


        public object EjecutarScalar(string comando, params object[] parametros)
        {
            object valorRetorno = new object();
            List<string> listaParametros = BuscarParametros(comando);

            if (parametros.Length != listaParametros.Count)
                throw new Exception("La cantidad de parámetros no coinciden");
            else
            {
                using (SqlConnection conTemp = new SqlConnection(strCon))
                {
                    conTemp.Open();

                    using (SqlCommand cmd = new SqlCommand(comando, conTemp))
                    {
                        for (int i = 0; i < listaParametros.Count; i++)
                            cmd.Parameters.AddWithValue(listaParametros[i], parametros[i]);
                       
                        valorRetorno = cmd.ExecuteScalar();
                    }
                }
            }

            if (valorRetorno == DBNull.Value)
                valorRetorno = 0;

            return valorRetorno;
        }

        public DataTable ObtenerTabla(string comando, params object[] parametros)
        {
            DataTable dt = new DataTable();
            List<string> listaParametros = BuscarParametros(comando);

            if (parametros.Length != listaParametros.Count)
                throw new Exception("La cantidad de parámetros no coinciden");
            else
            {
                using (SqlConnection conTemp = new SqlConnection(strCon))
                {
                    using (SqlCommand cmd = new SqlCommand(comando, conTemp))
                    {
                        for (int i = 0; i < listaParametros.Count; i++)
                            cmd.Parameters.AddWithValue(listaParametros[i], parametros[i]);                      

                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                            adp.Fill(dt);
                    }
                }
            }

            return dt;
        }
        #endregion
        private List<string> BuscarParametros(string parametros)
        {
            List<string> lista = new List<string>();
            int inicio, fin;
            string[] caracteresSeparadores = { ",", ";", " ", "(", ")" };
            string caracterSiguiente;

            inicio = 0;
            inicio = parametros.IndexOf("@", inicio);

            while (inicio != -1)
            {
                fin = inicio;
                bool encontrado = false;
                while (!(encontrado))
                {
                    fin++;
                    if (fin != parametros.Length)
                    {
                        caracterSiguiente = parametros.Substring(fin, 1);
                        foreach (string elemento in caracteresSeparadores)
                        {
                            if (caracterSiguiente == elemento)
                                encontrado = true;
                        }
                    }
                    else
                        encontrado = true;
                }
                lista.Add(parametros.Substring(inicio, fin - inicio));
                inicio = parametros.IndexOf("@", fin);
            }

            return lista;
        }
    }
}
