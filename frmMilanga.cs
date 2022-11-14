using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP4B
{
    public partial class frmMilanga : Form
    {
        

        public frmMilanga()
        {
            InitializeComponent();
        }

        private void frmMilanga_Load(object sender, EventArgs e)
        {
            
            dgvMozos.Rows.Insert(0, "Julio");
            dgvMozos.Rows.Insert(1, "Esteban");
            dgvMozos.Rows.Insert(2, "Javier");
            dgvMozos.Rows.Insert(3, "Gonzalo");
            dgvMozos.Rows.Insert(4, "Alberto");
            dgvMozos.Columns[0].ReadOnly= true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int i= 0;
            int j = 0;
            for ( i = 0; i < 5; i++)
            {
                for ( j = 0; j < 4; j++)
                {
                    if (dgvMozos[i,j] >=0 && dgvMozos.Rows.Count != -)
                    {

                    }
                }
            }
        }
    }
}
