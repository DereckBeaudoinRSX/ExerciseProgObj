using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class _3x3 : Form
    {
        
         
        public _3x3()
        {
            InitializeComponent();
        }

        private void Click_Case(object sender, EventArgs e)
        {
            try
            {
                Controle controle = new Controle();
                Button b = (Button)sender;

                if (controle.ValeurTour() == true)
                {
                    b.Enabled = false;

                    b.Text = "X";
                    controle.Plus1Tour();


                    check();

                }
                else if (controle.ValeurTour() == false)
                {
                    b.Enabled = false;

                    b.Text = "O";

                    controle.Plus1Tour();
                    check();
                }
            }
            catch 
            {

               
            }
            
                 
                      
                
            
           
        }

        public void check()
        {
            Controle controle = new Controle();
            //Y'a t-il un winner ?
            bool YaTIlUnGagnant = false;

            if ((btn_Case1Colone1.Text == btn_Case2Colone1.Text) && (btn_Case2Colone1.Text == btn_Case3Colone1.Text) && btn_Case1Colone1.Text != "")
            {
                YaTIlUnGagnant = true;
            }         
            else if ((btn_Case1Colone2.Text == btn_Case2Colone2.Text) && (btn_Case2Colone2.Text == btn_Case3Colone2.Text) && btn_Case1Colone2.Text != "")
            {
                YaTIlUnGagnant = true;
            } 
                
            else if ((btn_Case1Colone3.Text == btn_Case2Colone3.Text) && (btn_Case2Colone3.Text == btn_Case3Colone3.Text) && btn_Case1Colone3.Text != "")
            {
                YaTIlUnGagnant = true;
            } 
                

            else if ((btn_Case1Colone1.Text == btn_Case1Colone2.Text) && (btn_Case1Colone2.Text == btn_Case1Colone3.Text) && btn_Case1Colone2.Text != "")
            {
                YaTIlUnGagnant = true;
            }  
                
            else if ((btn_Case2Colone1.Text == btn_Case2Colone2.Text) && (btn_Case2Colone2.Text == btn_Case2Colone3.Text) && btn_Case2Colone2.Text != "")
            {
                YaTIlUnGagnant = true;
            } 
               
            else if ((btn_Case3Colone1.Text == btn_Case3Colone2.Text) && (btn_Case3Colone2.Text == btn_Case3Colone3.Text) && btn_Case3Colone2.Text != "")
            {
                YaTIlUnGagnant = true;
            }
                

            else if ((btn_Case1Colone1.Text == btn_Case2Colone2.Text) && (btn_Case2Colone2.Text == btn_Case3Colone3.Text) && btn_Case1Colone1.Text != "")
            {
                YaTIlUnGagnant = true;
            }
                
            else if ((btn_Case3Colone1.Text == btn_Case2Colone2.Text) && (btn_Case2Colone2.Text == btn_Case1Colone3.Text) && btn_Case2Colone2.Text != "")
            {
                YaTIlUnGagnant = true;
            } 
                

            if (YaTIlUnGagnant)  
            {
                string LettreGagnante = "";
                if (controle.ValeurTour())
                    LettreGagnante = "O";
                else LettreGagnante = "X";
                MessageBox.Show("Gagnant: " + LettreGagnante);
                restart();
            }
            else if (controle.ValeurCompteur() == 9)
            {
                MessageBox.Show("Égalité");
                restart();
            }
        }

        private void restart()
        {
            Controle controle = new Controle();
            //Redémarré les controles des Buttons
            foreach (Control b in Controls.OfType<Button>())
            {

                b.Enabled = true;
                b.Text = "";
                
            }
            controle.ClearTour();
            btn_Restart.Text = "Restart";

        }

        private void ButtonRestart(object sender, EventArgs e)
        {
            //Le nom l'indique
            restart();
            btn_Restart.Text = "Restart";
        }

        private void _3x3_Load(object sender, EventArgs e)
        {

        }
    }
}
    
