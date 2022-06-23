using System;
using System.Collections.Generic;
using System.Text;

namespace FIAD_TINFEM
{
    class Professor
    {
        int siape;
        string nome;
        string email;
        string senha;

        public Professor Login(string email, string senha)
        {
            //Define e coloca os dados no comando SQL
            var sql = "SELECT * FROM professor " +
                "WHERE email = '$email' AND senha = '$senha'";
            sql = sql.Replace("$email", email);
            sql = sql.Replace("$senha", senha);

            //Executa o comando sql no banco de dados
            var resultado = BD.ExecutarSelecao(sql);

            //Analisa se veio resultado ou veio vazio
            if (resultado.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //Deu certo, retornar os dados completos do prof
                //IMPLEMENTAR 
            }

        }
    }
}
