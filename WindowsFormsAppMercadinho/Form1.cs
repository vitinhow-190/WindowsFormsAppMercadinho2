﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMercadinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {   
            double total = double.Parse(lblTotal.Text);
            string produto = txtProdutos.Text;
            int quantidade = int.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);

            ListBox listBox = lstProdutos;

            listBox.Items.Add("Produto: " + produto + " / " + "Qtd: " + quantidade + " / " + "Valor Uni: R$ " + valor);

            total += quantidade * valor;

            lblTotal.Text = total.ToString();

            txtProdutos.Clear();
            txtQtde.Clear();
            txtValor.Clear();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProdutos.Clear();
            txtQtde.Clear();
            txtValor.Clear();

            lstProdutos.Items.Clear();

            lblTotal.Text = "";

            txtProdutos.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
