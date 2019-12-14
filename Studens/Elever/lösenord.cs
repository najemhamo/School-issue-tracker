using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elever
{
    public partial class lösenord : Form
    {

        public string Elev;
        public DataCenter DT;

        public lösenord()

        {
            InitializeComponent();
        }

        private void Bytt_btn_Click(object sender, EventArgs e)
        {
            if (DT.Check(Elev, Cerent_pass.Text))
            {
                if (New_pass.Text.Equals(New_pass_again.Text))
                {
                    DT.AddStudent(Elev, New_pass.Text);
                    MessageBox.Show("Lösenordet har ändrat!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Lösenordet matchar inte!", "Fel lösenord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Ditt gamla lösenord är fel!", "Fel lösenord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
        }

    }
}
