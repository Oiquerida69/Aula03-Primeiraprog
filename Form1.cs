﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telinha01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;
            usuario = txb01.Text;
            senha = txb02.Text;
            if (usuario == "Wendell" && senha == "Bixadestruidora")
            {
                MessageBox.Show("Login Feito com Sucesso");
                panel_Saldo.Show();
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorreto ");
            }
        }
    }
}
