namespace ExeriseProg
{
	partial class Calculatrice
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_Num1 = new System.Windows.Forms.TextBox();
			this.txt_Deno1 = new System.Windows.Forms.TextBox();
			this.txt_Num2 = new System.Windows.Forms.TextBox();
			this.txt_Deno2 = new System.Windows.Forms.TextBox();
			this.txt_NumRep = new System.Windows.Forms.TextBox();
			this.txt_DenoRep = new System.Windows.Forms.TextBox();
			this.cmb_Operateur = new System.Windows.Forms.ComboBox();
			this.btn_calcul = new System.Windows.Forms.Button();
			this.lbl_ligne = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_Num1
			// 
			this.txt_Num1.Location = new System.Drawing.Point(35, 46);
			this.txt_Num1.Name = "txt_Num1";
			this.txt_Num1.Size = new System.Drawing.Size(49, 20);
			this.txt_Num1.TabIndex = 0;
			// 
			// txt_Deno1
			// 
			this.txt_Deno1.Location = new System.Drawing.Point(35, 100);
			this.txt_Deno1.Name = "txt_Deno1";
			this.txt_Deno1.Size = new System.Drawing.Size(49, 20);
			this.txt_Deno1.TabIndex = 1;
			// 
			// txt_Num2
			// 
			this.txt_Num2.Location = new System.Drawing.Point(165, 46);
			this.txt_Num2.Name = "txt_Num2";
			this.txt_Num2.Size = new System.Drawing.Size(46, 20);
			this.txt_Num2.TabIndex = 2;
			// 
			// txt_Deno2
			// 
			this.txt_Deno2.Location = new System.Drawing.Point(165, 100);
			this.txt_Deno2.Name = "txt_Deno2";
			this.txt_Deno2.Size = new System.Drawing.Size(46, 20);
			this.txt_Deno2.TabIndex = 3;
			// 
			// txt_NumRep
			// 
			this.txt_NumRep.Location = new System.Drawing.Point(309, 46);
			this.txt_NumRep.Name = "txt_NumRep";
			this.txt_NumRep.Size = new System.Drawing.Size(94, 20);
			this.txt_NumRep.TabIndex = 4;
			// 
			// txt_DenoRep
			// 
			this.txt_DenoRep.Location = new System.Drawing.Point(309, 100);
			this.txt_DenoRep.Name = "txt_DenoRep";
			this.txt_DenoRep.Size = new System.Drawing.Size(94, 20);
			this.txt_DenoRep.TabIndex = 5;
			// 
			// cmb_Operateur
			// 
			this.cmb_Operateur.FormattingEnabled = true;
			this.cmb_Operateur.Location = new System.Drawing.Point(105, 73);
			this.cmb_Operateur.Name = "cmb_Operateur";
			this.cmb_Operateur.Size = new System.Drawing.Size(42, 21);
			this.cmb_Operateur.TabIndex = 6;
			// 
			// btn_calcul
			// 
			this.btn_calcul.Location = new System.Drawing.Point(237, 46);
			this.btn_calcul.Name = "btn_calcul";
			this.btn_calcul.Size = new System.Drawing.Size(48, 74);
			this.btn_calcul.TabIndex = 8;
			this.btn_calcul.Text = "=";
			this.btn_calcul.UseVisualStyleBackColor = true;
			this.btn_calcul.Click += new System.EventHandler(this.btn_calcul_Click);
			// 
			// lbl_ligne
			// 
			this.lbl_ligne.AutoSize = true;
			this.lbl_ligne.Location = new System.Drawing.Point(32, 73);
			this.lbl_ligne.Name = "lbl_ligne";
			this.lbl_ligne.Size = new System.Drawing.Size(55, 13);
			this.lbl_ligne.TabIndex = 9;
			this.lbl_ligne.Text = "________";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(162, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "________";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(306, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "_______________";
			// 
			// Calculatrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 182);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_ligne);
			this.Controls.Add(this.btn_calcul);
			this.Controls.Add(this.cmb_Operateur);
			this.Controls.Add(this.txt_DenoRep);
			this.Controls.Add(this.txt_NumRep);
			this.Controls.Add(this.txt_Deno2);
			this.Controls.Add(this.txt_Num2);
			this.Controls.Add(this.txt_Deno1);
			this.Controls.Add(this.txt_Num1);
			this.Name = "Calculatrice";
			this.Text = "Calculatrice Fraction";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Num1;
		private System.Windows.Forms.TextBox txt_Deno1;
		private System.Windows.Forms.TextBox txt_Num2;
		private System.Windows.Forms.TextBox txt_Deno2;
		private System.Windows.Forms.TextBox txt_NumRep;
		private System.Windows.Forms.TextBox txt_DenoRep;
		private System.Windows.Forms.ComboBox cmb_Operateur;
		private System.Windows.Forms.Button btn_calcul;
		private System.Windows.Forms.Label lbl_ligne;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

