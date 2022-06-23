using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FIAD_TINFEM
{
    class BD
    {
        //Contém os dados da conexão com o banco de dados
        private const string CONNECTION_STRING = "server=193.123.97.250;database=fiad_tinfem;uid=tds;pwd=tds;convert zero datetime=True";

        //É a variável UNIVERSAL de conexão
        private static MySqlConnection conn;

        //Método que inicia a conexão
        public static MySqlConnection Conectar()
        {
            //Cria a conexão
            conn = new MySqlConnection(CONNECTION_STRING);
            //Abrir a conexão
            conn.Open();
            //Retorna a conexão aberta
            return conn;
        }

        //Método para executar comandos que alteram o BD (INSERT, UPDATE e DELETE)
        public static void ExecutarAlteracao(string sql)
        {
            //Conecta ao banco de dados chamando o método Conectar
            Conectar();
            //Cria o comando
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //Executa o comando
            cmd.ExecuteNonQuery();
            //Finaliza a conexão
            conn.Close();
        }

        //Método que serve para executar comando SELECT
        public static DataTable ExecutarSelecao(string sql)
        {
            //Conecta ao banco de dados chamando o método Conectar
            Conectar();
            //Cria o comando
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //Cria a tabela vazia que armazenará os resultados
            DataTable dt = new DataTable();
            //Executa o comando e traz os resultados ainda fora de ordem
            var res = cmd.ExecuteReader();
            //Coloca o resultado no formato de tabela (datatable)
            dt.Load(res);
            //Finaliza a conexão
            conn.Close();
            //Retorna a datatable para onde foi chamada
            return dt;
        }
    }
}
