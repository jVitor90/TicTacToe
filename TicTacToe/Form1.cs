using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Variaveis global
        string jogadaatual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void PicbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Jogada_Click(object sender, EventArgs e)
        {
            Button botaoclicado = (Button)sender;
            botaoclicado.Text = jogadaatual;
            botaoclicado.Enabled = false;
            //trocar de X para 0 e O para X
            if (jogadaatual == "X")
            {
                jogadaatual = "O";
                LblInfo.ForeColor = Color.Yellow;
            }
            else
            {
                jogadaatual = "X";
                LblInfo.ForeColor = Color.Red;
            }
            //Atualizar o label
            LblInfo.Text = $"A vez è do {jogadaatual}";

            //Verificar o vencedor 
            VerificarVencedor();
        }

        private void PicbReset_Click(object sender, EventArgs e)
        {
            jogadaatual = "X";
            LblInfo.Text = $"È a vez do {jogadaatual}";
            LblInfo.ForeColor = Color.Red;

            //Resetar os botôes
            Btn11.Enabled = true;
            Btn11.Text = "";

            Btn12.Enabled = true;
            Btn12.Text = "";

            Btn13.Enabled = true;
            Btn13.Text = "";

            Btn21.Enabled = true;
            Btn21.Text = "";

            Btn22.Enabled = true;
            Btn22.Text = "";

            Btn23.Enabled = true;
            Btn23.Text = "";

            Btn31.Enabled = true;
            Btn31.Text = "";

            Btn32.Enabled = true;
            Btn32.Text = "";

            Btn33.Enabled = true;
            Btn33.Text = "";
        }
        public void VerificarVencedor()
        {
            //Verficar as linhas

            //Horizontal 1
            if (Btn11.Text == Btn12.Text && Btn12.Text == Btn13.Text && Btn11.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn11.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Horizontal 2
            else if (Btn21.Text == Btn22.Text && Btn22.Text == Btn23.Text && Btn21.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn21.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Horizontal 3
            else if (Btn31.Text == Btn32.Text && Btn32.Text == Btn33.Text && Btn31.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn31.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Vertical 1
            else if (Btn11.Text == Btn21.Text && Btn21.Text == Btn31.Text && Btn11.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn11.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Vertical 2
            else if (Btn12.Text == Btn22.Text && Btn22.Text == Btn32.Text && Btn12.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn12.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Vertical 3
            else if (Btn13.Text == Btn23.Text && Btn23.Text == Btn33.Text && Btn13.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn13.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Diagonal 1
            else if (Btn11.Text == Btn22.Text && Btn22.Text == Btn33.Text && Btn11.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn11.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Diagonal 2
            else if (Btn13.Text == Btn22.Text && Btn22.Text == Btn31.Text && Btn13.Text != "")
            {
                LblInfo.Text = $"O vencedor é {Btn13.Text}";
                LblInfo.ForeColor = Color.Green;
                PararOJogo();
            }
            //Verificar se deu velha
            else if (!Btn11.Enabled && !Btn12.Enabled && !Btn13.Enabled && !Btn21.Enabled && !Btn22.Enabled &&
            Btn23.Enabled && !Btn31.Enabled && !Btn32.Enabled && !Btn33.Enabled)
            {
                LblInfo.Text = "O jogo deu velha, Empate!";
            }

            
        }
        public void PararOJogo()
        {
            //Desativar os botões, quando houver um vencedor para impedir que o jogo continue.
            Btn11.Enabled = false;
            Btn12.Enabled = false;
            Btn13.Enabled = false;
            Btn21.Enabled = false;
            Btn22.Enabled = false;
            Btn23.Enabled = false;
            Btn31.Enabled = false;
            Btn32.Enabled = false;
            Btn33.Enabled = false;
        }



    }
}
