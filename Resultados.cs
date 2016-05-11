using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Cars
{
    public partial class Resultados : Form
    {
        int idplay, car, pista, pont, moedas;

        public Resultados(int id, int pontuacao, int carro, int pist)
        {
            InitializeComponent();
       
            idplay = id;
            car = carro;
            pont = pontuacao;
            pista = pist;

            if (pontuacao <= 0)
            {
                pont = 0;
            }

            if (pont <= 50)
            {
                moedas = 10;
            }
            else if (pont <= 100)
            {
                moedas = 20;
            }
            else if (pont <= 150)
            {
                moedas = 30;
            }
            else if (pont <= 200)
            {
                moedas = 40;
            }
            else if (pont <= 250)
            {
                moedas = 60;
            }
            else if (pont <= 300)
            {
                moedas = 100;
            }
            else if (pont <= 350)
            {
                moedas = 150;
            }
            else if (pont <= 400)
            {
                moedas = 210;
            }
            else if (pont <= 450)
            {
                moedas = 250;
            }
            else if (pont <= 500)
            {
                moedas = 300;
            }

            lblPon.Text = pont.ToString();
            lblMoedas.Text = moedas.ToString();
        }

        private async void btnCont_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri("http://localhost:49580/RecebeDados.aspx?id=" + idplay + "&carro=" + car + "&pista=" + pista + "&pontuacao=" + pont + "&moedas=" + moedas);
                WebRequest pedido = WebRequest.Create(uri);
                WebResponse resposta = await pedido.GetResponseAsync();
                StreamReader ler = new StreamReader(resposta.GetResponseStream());
                string txtResposta = ler.ReadToEnd();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao guardar dados no servidor") ;
            }
            this.Close();
        }
    }
}
