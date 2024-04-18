using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_RA.Modelo
{
    public class Validacao
    {
        public string mensagem;

        public void Validar(string hor, string cur, string camp)
        {
            mensagem = "";
            try
            {
                if (hor.Equals(""))
                {
                    mensagem = "Selecione todas as opções";
                }
                else if (cur.Equals(""))
                {
                    mensagem = "Selecione todas as opções";
                }
                else if (camp.Equals(""))
                {
                    mensagem = "Selecione todas as opções";
                }
            }
            catch (Exception erro)
            {
                mensagem = "";
            }
        }

    }
}



