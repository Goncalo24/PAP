using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Cars
{
    class MudaCarro
    {
        int carroAT;

        public async void carro(int id, int loggado)
        {
            int player = id;
            int log = loggado;
            int car;

            try
            {
                Uri uri = new Uri("http://localhost:49580/MudaCarro.aspx?id=" + player);
                WebRequest pedido = WebRequest.Create(uri);
                WebResponse resposta = await pedido.GetResponseAsync();
                StreamReader ler = new StreamReader(resposta.GetResponseStream());
                string txtResposta = ler.ReadToEnd();

                if (txtResposta != "erro")
                {
                    string[] respostatxt = txtResposta.Split(';');

                    //id
                    string carro = respostatxt[0].Split(':')[1];

                    string[] arr = { player.ToString(), log.ToString() , carro };

                    File.WriteAllLines("Content/Carro.txt", arr);
                }  
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao guardar dados no servidor");
            }
        }
    }
}
