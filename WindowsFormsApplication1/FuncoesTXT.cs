using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Votacao_
{
    class funcoestxt
    {
        candidatos candidato = new candidatos();

        public string ler(string arquivo, int linha)
        {
            int counter = 1;
            string line;
            string valorfinal = "0";

            // Lê o txt e mostra linha por linha.
            System.IO.StreamReader file = new System.IO.StreamReader(@arquivo);
            while ((line = file.ReadLine()) != null)
            {
                if (counter == linha)
                { valorfinal = line; }
                counter++;
            }
            file.Close();
            return valorfinal;
        }


        public void gravartudo(string arquivo, int v1, int v2, params string[] titulo)
        {  
            System.IO.File.WriteAllText(@arquivo,"        "+titulo[0]+":    "+ v1 +" votos          "+titulo[1]+": " + v2 +" votos"); }

        public void gravar(string arquivo, params int[] lines)
        {
            string[] strlines;
            strlines= new string[3];

            for (int i = 0; i < candidato.qtd; i++)
            {
                strlines[i] = lines[i].ToString();
            }
            
            System.IO.File.WriteAllLines(@arquivo, strlines);
        }


    }

}
