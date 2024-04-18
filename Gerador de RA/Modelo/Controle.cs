using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_RA.Modelo
{
public class Controle
{
    public string codaluno;
    public string mensagem;

    public void Executar(string hor, string cur, string camp)
        {
        mensagem = "";
        Validacao validacao = new Validacao();
        validacao.Validar(hor, cur, camp);
        if (validacao.mensagem.Equals(""))
        {
            Decisao decisao = new Decisao();
            codaluno = decisao.Decidir(hor, cur, camp).ToString();
        }
        else
        {
            mensagem = validacao.mensagem;
        }

    }
}
}
