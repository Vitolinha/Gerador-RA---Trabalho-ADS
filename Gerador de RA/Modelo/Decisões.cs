using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_RA.Modelo
{
    public class Decisao
    {
        public string per;
        public int curso;
        public string campus;

        public string Decidir(string hor, string cur, string camp)
        {
            if (hor.Equals("Manhã"))
            {
                per = "E";
            }
            else
            {
                per = "F";
            }

            if (cur.Equals("Análise e Desenvolvimento de Sistemas") || cur.Equals("Ciência da Computação"))
            {
                Random numAleatorio = new Random();
                curso = numAleatorio.Next(100, 300);
            }
            else
            {
                Random numAleatorio = new Random();
                curso = numAleatorio.Next(300, 500);
            }

            if (camp.Equals("Sorocaba"))
            {
                Random finalAleatorio = new Random();
                int campAleatorio = finalAleatorio.Next(0, 9);
                campus = "CB" + campAleatorio.ToString();
            }
            else if (camp.Equals("Itapetininga"))
            {
                Random finalAleatorio = new Random();
                int campAleatorio = finalAleatorio.Next(0, 9);
                campus = "CA" + campAleatorio.ToString();
            }
            else
            {
                Random finalAleatorio = new Random();
                int campAleatorio = finalAleatorio.Next(0, 9);
                campus = "CD" + campAleatorio.ToString();
            }

            return $"Per:{per}, Curso: {curso}, Campus: {campus}";
        }
    }
}
