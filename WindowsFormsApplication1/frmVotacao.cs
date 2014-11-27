using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Votacao_
{
    public partial class frmvotacao : Form
    {
        // Instânciando a Classe "Funcoes"  --  EX: X = f.lertxt("arquivo",2)
                funcoestxt txt = new funcoestxt();
            //Candidatos
                candidatos.candidato c1 = new candidatos.candidato();
                candidatos.candidato c2 = new candidatos.candidato();
                candidatos candidato = new candidatos();

        public frmvotacao()
        {
            InitializeComponent();
        }

        private void frmvotacao_Load(object sender, EventArgs e)
        {
            c1.votos = Convert.ToInt32(txt.ler("candidato.cd", 1));
            c2.votos = Convert.ToInt32(txt.ler("candidato.cd", 2));
            lbc1.Text = c1.votos.ToString()+" votos";    //
            lbc2.Text = c2.votos.ToString()+" votos";    //
        }


        private void btnc1_Click(object sender, EventArgs e)  { votar("c1"); }

        private void btnc2_Click(object sender, EventArgs e)  { votar("c2"); }



        public void votar(string cd)  // votar("c1");
        {   
            if (cd == "c1") { c1.votos += 1; }
            if (cd == "c2") { c2.votos += 1; }

            lbc1.Text = c1.votos.ToString() + " votos";
            lbc2.Text = c2.votos.ToString() + " votos";

            MessageBox.Show("Próximo Eleitor...!");
            txt.gravar("candidato.cd", c1.votos, c2.votos);
            txt.gravartudo("Resultado.txt", c1.votos, c2.votos, "Candidato 1", "Candidato 2");

            for (int i = 1; i < candidato.qtd; i++) { }
        }

            //TESTE DE XML
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    XmlTextReader textReader = new XmlTextReader("xmlResultado.xml");
        //}


    }
}
