using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeriseProg
{
	public partial class Calculatrice : Form
	{
		public Calculatrice()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] Operateur = { "+", "-", "*", "/" };
			for (int compteur = 0; compteur <= Operateur.GetUpperBound(0); compteur++)
			{
				cmb_Operateur.Items.Add(Operateur[compteur]);
			}
		}

		private void btn_calcul_Click(object sender, EventArgs e)
		{
			try
			{
				Fraction premiereFraction = new Fraction(int.Parse(txt_Num1.Text), int.Parse(txt_Deno1.Text));
				Fraction deuxiemeFraction = new Fraction(int.Parse(txt_Num2.Text), int.Parse(txt_Deno2.Text));

				if (cmb_Operateur.SelectedItem.ToString() == "+")
				{
					var Total = premiereFraction + deuxiemeFraction;
					Afficher(Total);
				}
				else if (cmb_Operateur.SelectedItem.ToString() == "-")
				{
					var Total = premiereFraction - deuxiemeFraction;
					Afficher(Total);
				}
				else if (cmb_Operateur.SelectedItem.ToString() == "*")
				{
					var Total = premiereFraction * deuxiemeFraction;
					Afficher(Total);
				}
				else if (cmb_Operateur.SelectedItem.ToString() == "/")
				{
					var Total = premiereFraction / deuxiemeFraction;
					Afficher(Total);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private void Afficher(Fraction Total)
		{
			txt_NumRep.Text = Total.GetNumerateur().ToString();
			txt_DenoRep.Text = Total.GetDenominateur().ToString();
		}
	}
}
