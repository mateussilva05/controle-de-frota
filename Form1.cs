using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrl_de_frota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Carro
        {
            private string modelo, placa, km;

            public void gravarModelo(string modelo)
            {
                this.modelo = modelo;
            }

            public string showModelo()
            {
                return modelo;
            }

            public void gravarPlaca(string placa)
            {
                this.placa = placa;
            }

            public string showPlaca()
            {
                return placa;
            }

            public void gravarKm(string km)
            {
                this.km = km;
            }

            public string showKm()
            {
                return km;
            }
        }

        public class Caminhao : Carro
        {
            private string eixo;

            public void gravarEixo(string eixo)
            {
                this.eixo = eixo;
            }

            public string showEixo()
            {
                return eixo;
            }
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            pnlCarro.Visible = true;
            pnlCaminhao.Visible = false;
            txtRegistro.Visible = true;
            txtRegistro2.Visible = false;
            lblRegistroEixo.Visible = false;
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            pnlCaminhao.Visible = true;
            pnlCarro.Visible = false;
            txtRegistro2.Visible = true;
            txtRegistro.Visible = false;
            lblRegistroEixo.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pnlCarro.Visible == true || txtRegistro.Visible == true)
            {
                Carro novoCarro = new Carro();

                novoCarro.gravarModelo(txtModelo.Text);
                novoCarro.gravarPlaca(txtPlaca.Text);
                novoCarro.gravarKm(txtKm.Text);
                
                txtRegistro.AppendText(novoCarro.showModelo() + "\t\t");
                txtRegistro.AppendText(novoCarro.showPlaca() + "\t");
                txtRegistro.AppendText(novoCarro.showKm() + "\r\n");

                txtModelo.Text = "";
                txtPlaca.Text = "";
                txtKm.Text = "";
            }
            else
                if (pnlCaminhao.Visible == true || txtRegistro2.Visible == true)
            {
                Caminhao novoCaminhao = new Caminhao();

                novoCaminhao.gravarModelo(txtModelo2.Text);
                novoCaminhao.gravarPlaca(txtPlaca2.Text);
                novoCaminhao.gravarKm(txtKm2.Text);
                novoCaminhao.gravarEixo(txtEixos.Text);

                txtRegistro2.AppendText(novoCaminhao.showModelo() + "\t");
                txtRegistro2.AppendText(novoCaminhao.showPlaca() + "\t");
                txtRegistro2.AppendText(novoCaminhao.showKm() + "\t\t");
                txtRegistro2.AppendText(novoCaminhao.showEixo() + "\r\n");

                txtModelo2.Text = "";
                txtPlaca2.Text = "";
                txtKm2.Text = "";
                txtEixos.Text = "";
            }
        }
    }
}
