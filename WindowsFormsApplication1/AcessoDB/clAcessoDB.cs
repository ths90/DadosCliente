﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class clAcessoDB
    {
        //variável para receber a string de conexão
        public string vConexao = "";

        //método responsável por abrir a conexão com o banco
        //de dados

        public SqlConnection AbreBanco()
        {
            //Abre a Conexão com a Base de Dados
            SqlConnection conn = new SqlConnection(vConexao);
            conn.Open();
            return conn;
        }
        //método responsável por abrir a conexão com o banco
        //de dados

        public void FechaBanco(SqlConnection conn)
        {
            //Fecha a Conexão com a Base de Dados
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        //método responsável por executar comandos (INSERT, UPDATE, DELETE)
        //no banco de dados

        public void ExecutarComando(string strQuery)
        {
            //cria objeto de conexão
            SqlConnection conn = new SqlConnection();
            try
            {
                //abre a conexão com o banco de dados
                conn = AbreBanco();

                //cria o objeto de comando
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;

                //passa os valores da query SQL, tipo do comando,
                //conexão e  executa o comando
                cmdComando.ExecuteNonQuery();
           }
            //tratamento de excessoes
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally
                //é executado para fechar a conexão com o banco de dados
                FechaBanco(conn);
            }
        }
    }
}

