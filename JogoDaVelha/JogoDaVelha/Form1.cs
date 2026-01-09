using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public int ContTurno = 0, Caso = 0, ContJogadorX = 0, ContJogadorO = 0, ContEmpate = 0;
        Matriz matriz = new Matriz();

        public Form1()
        {
            InitializeComponent();
            txtboxResultado.Text = "Turnos (Jogador X)";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn1.ForeColor = Color.MediumBlue;
                labelbtn1.Text = "X";
            }

            else
            {
                labelbtn1.ForeColor = Color.Red;
                labelbtn1.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 0, 0);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn2.ForeColor = Color.MediumBlue;
                labelbtn2.Text = "X";
            }

            else
            {
                labelbtn2.ForeColor = Color.Red;
                labelbtn2.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 0, 1);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn3.ForeColor = Color.MediumBlue;
                labelbtn3.Text = "X";
            }

            else
            {
                labelbtn3.ForeColor = Color.Red;
                labelbtn3.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 0, 2);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn4.ForeColor = Color.MediumBlue;
                labelbtn4.Text = "X";
            }

            else
            {
                labelbtn4.ForeColor = Color.Red;
                labelbtn4.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 1, 0);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn5.ForeColor = Color.MediumBlue;
                labelbtn5.Text = "X";
            }

            else
            {
                labelbtn5.ForeColor = Color.Red;
                labelbtn5.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 1, 1);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn6.ForeColor = Color.MediumBlue;
                labelbtn6.Text = "X";
            }

            else
            {
                labelbtn6.ForeColor = Color.Red;
                labelbtn6.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 1, 2);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn7.ForeColor = Color.MediumBlue;
                labelbtn7.Text = "X";
            }

            else
            {
                labelbtn7.ForeColor = Color.Red;
                labelbtn7.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 2, 0);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn8.ForeColor = Color.MediumBlue;
                labelbtn8.Text = "X";
            }

            else
            {
                labelbtn8.ForeColor = Color.Red;
                labelbtn8.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 2, 1);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Visible = false;

            if (ContTurno % 2 != 0)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = ("Turno do Jogador X!");
            }

            else
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.BackColor = txtboxResultado.BackColor;
                txtboxResultado.Text = "Turno do Jogador O!";
            }

            if (ContTurno % 2 == 0)
            {
                labelbtn9.ForeColor = Color.MediumBlue;
                labelbtn9.Text = "X";
            }

            else
            {
                labelbtn9.ForeColor = Color.Red;
                labelbtn9.Text = "O";
            }

            matriz.atualizarMatriz(ContTurno, 2, 2);
            ContTurno++;
            Caso = matriz.verificarMatriz(ContTurno);
            verificarCaso();
        }

        public void verificarCaso()
        {
            if (Caso == 1 || Caso == 9)
            {
                labelbtn1.BackColor = Color.Lime;
                labelbtn4.BackColor = Color.Lime;
                labelbtn7.BackColor = Color.Lime;
            }

            else if (Caso == 2 || Caso == 10)
            {
                labelbtn2.BackColor = Color.Lime;
                labelbtn5.BackColor = Color.Lime;
                labelbtn8.BackColor = Color.Lime;
            }

            else if (Caso == 3 || Caso == 11)
            {
                labelbtn3.BackColor = Color.Lime;
                labelbtn6.BackColor = Color.Lime;
                labelbtn9.BackColor = Color.Lime;
            }

            else if (Caso == 4 || Caso == 12)
            {
                labelbtn1.BackColor = Color.Lime;
                labelbtn2.BackColor = Color.Lime;
                labelbtn3.BackColor = Color.Lime;
            }

            else if (Caso == 5 || Caso == 13)
            {
                labelbtn4.BackColor = Color.Lime;
                labelbtn5.BackColor = Color.Lime;
                labelbtn6.BackColor = Color.Lime;
            }

            else if (Caso == 6 || Caso == 14)
            {
                labelbtn7.BackColor = Color.Lime;
                labelbtn8.BackColor = Color.Lime;
                labelbtn9.BackColor = Color.Lime;
            }

            else if (Caso == 7 || Caso == 15)
            {
                labelbtn1.BackColor = Color.Lime;
                labelbtn5.BackColor = Color.Lime;
                labelbtn9.BackColor = Color.Lime;
            }

            else if (Caso == 8 || Caso == 16)
            {
                labelbtn3.BackColor = Color.Lime;
                labelbtn5.BackColor = Color.Lime;
                labelbtn7.BackColor = Color.Lime;
            }

            if (Caso > 0 && Caso < 9)
            {
                txtboxResultado.ForeColor = Color.MediumBlue;
                txtboxResultado.Text = "Vitória Jogador X!";
                pararJogo();
                ContJogadorX++;
                txtPlacarX.Text = Convert.ToString(ContJogadorX);
                MessageBox.Show("JOGADOR X GANHOU!!!");
            }

            else if (Caso > 9 && Caso < 17)
            {
                txtboxResultado.ForeColor = Color.Red;
                txtboxResultado.Text = "Vitória Jogador O!";
                pararJogo();
                ContJogadorO++;
                txtPlacarO.Text = Convert.ToString(ContJogadorO);
                MessageBox.Show("JOGADOR O GANHOU!!!");
            }

            else if (Caso == 17)
            {
                txtboxResultado.ForeColor = Color.Black;
                txtboxResultado.Text = "Empate!";
                pararJogo();
                ContEmpate++;
                txtPlacarEmpate.Text = Convert.ToString(ContEmpate);
                MessageBox.Show("Empate!");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ContTurno = 0;
            txtboxResultado.Text = "Turnos (Jogador X)";
            txtboxResultado.ForeColor = Color.Black;

            matriz.reiniciarMatriz();

            btn1.Enabled = true;
            btn1.Visible = true;
            labelbtn1.BackColor = Color.Transparent;
            btn2.Enabled = true;
            btn2.Visible = true;
            labelbtn2.BackColor = Color.Transparent;
            btn3.Enabled = true;
            btn3.Visible = true;
            labelbtn3.BackColor = Color.Transparent;
            btn4.Enabled = true;
            btn4.Visible = true;
            labelbtn4.BackColor = Color.Transparent;
            btn5.Enabled = true;
            btn5.Visible = true;
            labelbtn5.BackColor = Color.Transparent;
            btn6.Enabled = true;
            btn6.Visible = true;
            labelbtn6.BackColor = Color.Transparent;
            btn7.Enabled = true;
            btn7.Visible = true;
            labelbtn7.BackColor = Color.Transparent;
            btn8.Enabled = true;
            btn8.Visible = true;
            labelbtn8.BackColor = Color.Transparent;
            btn9.Enabled = true;
            btn9.Visible = true;
            labelbtn9.BackColor = Color.Transparent;
        }

        public void pararJogo()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
    }
}