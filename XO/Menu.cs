//Auteur: Dereck Beaudoin
//Date: 2020-03-12
//Description : TikTakToe


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
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
        }

        private void Button3x3(object sender, EventArgs e)   
        {
            _3x3 Tableau3 = new _3x3();
            
            Tableau3.Show();
        }

        private void Button4x4(object sender, EventArgs e)  
        {
            _4x4 Tableau4X4 = new _4x4();
            Tableau4X4.Show();
        }

        
        
    }
}
