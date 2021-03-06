﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace Race_Cars
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private void llblRegisto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:49580/Registo.aspx");
        }

        private void btnJA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLoggin_Click(object sender, EventArgs e)
        {
            string email;
            string pass;

            email = tbEmail.Text;
            pass = tbPass.Text;

            Uri uri = new Uri("http://localhost:49580/ValidaLogin.aspx?nome=" + email + "&password=" + pass);
            WebRequest pedido = WebRequest.Create(uri);
            WebResponse resposta = await pedido.GetResponseAsync();
            StreamReader ler = new StreamReader(resposta.GetResponseStream());
            string txtResposta = ler.ReadToEnd();
            if (txtResposta == "erro")
                lberro.Text = "Login falhou";
            else
            {
                string[] respostatxt = txtResposta.Split(';');
                //id
                string id = respostatxt[0].Split(':')[1];
                //nickname
                string nickname = respostatxt[1].Split(':')[1];
                this.Close();
            }
        }
    }
}
