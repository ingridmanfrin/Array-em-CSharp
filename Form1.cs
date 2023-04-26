using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            //int[] valores;
            //valores = new int[5]; // instancia de valores / criação de array de índice 5 (sempre começa no índice 0)
            //valores[0] = 10;
            //valores[1] = 20;
            //valores[2] = 30;
            //valores[3] = 40;
            //valores[4] = 50;
            //ListBox.Items.Add(valores[4] + valores[2]);
            //arrays

            //int[] valores = new int[] {10, 20, 30, 40, 50, 60, 70 };

            //foreach (int valor in valores)
            //{
            //    ListBox.Items.Add(valor);
            //}

            //int[] valores = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            //for (int indice = 0; indice < 7; indice++)
            //{
            //    ListBox.Items.Add(valores[indice]);
            //}

            int[] valores = new int[] { 00, 500, 60, 10, 20, 30, 40, 50, 60, 10, 20, 30, 40, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190 };

            for (int indice = 0; indice <valores.Length; indice++)
            {
                ListBox.Items.Add(valores[indice]); 
            }

        }
    }
}
