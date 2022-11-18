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
        public int[,] matMozos = new int[5, 4];
        public int[] vecTotales = new int[10];
        

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
            int fila = 0;
            int columna = 0;
            int i = 0;
            int colmat = 0;
            for (fila = 0; fila < 4; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {
                    if (dgvMozos.Rows[fila].Cells[columna].Value == null)
                    {
                        i++;
                    }

                }
            }
            if (i == 0)
            {
                fila = 0;
                columna = 1;
                while (columna<= 4)
                {
                    while (fila<=4 && colmat<=matMozos.GetLength(1))
                    {
                        matMozos[fila, colmat] = Int32.Parse((string)dgvMozos.Rows[fila].Cells[columna].Value);
                        colmat++;
                        columna++;
                    }
                    columna = 1;
                    colmat = 0;
                    fila++;
                }
                btnMozo.Enabled = true;
                btnTotales.Enabled = true;
            }
            else
            {
                btnTotales.Enabled = false;
                btnMozo.Enabled = false;
                MessageBox.Show("solo números", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            int fila = 0;
            int columna = 0;
            int suma = 0;
            int mozo = 0;
            int mayor = 0;
            for (fila = 0; fila < 4; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {

                }
            }
        }
    }
}
