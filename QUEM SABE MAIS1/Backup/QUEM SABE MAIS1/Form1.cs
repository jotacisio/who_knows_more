﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QUEM_SABE_MAIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); TB_nomeP1.Select(); 
        }
    
        Form2 OBJ_form2 = new Form2();
        public string x;

        private void BT_jogar_Click_1(object sender, EventArgs e)
        {
            OBJ_form2.Show();
            if (TB_nomeP1.Text != "")
            {
                //Mudar para o local do arquivo de som
                SoundPlayer IniciarPlayer = new SoundPlayer(@"G:\Arquivos de música.wav\Entrada1.wav");
                IniciarPlayer.Play();
                x = TB_nomeP1.Text;
                OBJ_form2.LB_nickprincipal.Text = x;
                OBJ_form2.Show();
            }
            else
            {
                MessageBox.Show("Insira um nick", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
