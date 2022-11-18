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
            
            for (int i = 0; i < 5; i++)
            {
                dgvMozos.Rows.Add();
            }
            dgvMozos.Rows[0].Cells[0].Value = "Julio";
            dgvMozos.Rows[1].Cells[0].Value = "Esteban";
            dgvMozos.Rows[2].Cells[0].Value = "Javier";
            dgvMozos.Rows[3].Cells[0].Value = "Gonzalo";
            dgvMozos.Rows[4].Cells[0].Value = "Alberto";
            dgvMozos.Columns[0].ReadOnly = true;
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
                    if (dgvMozos.Rows[fila].Cells[columna].Value == null || dgvMozos.Rows[fila].Cells[columna].Value=="")
                    {
                        i++;
                    }

                }
            }
            if (i == 0)
            {
                fila = 0;
                columna = 1;
                while (fila<= 4)
                {
                    while (columna<=4 && colmat<=matMozos.GetLength(1))
                    {
                        matMozos[fila, colmat] = Convert.ToInt32(dgvMozos.Rows[fila].Cells[columna].Value);
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
            while (fila<matMozos.GetLength(0))
            {
                while (columna<matMozos.GetLength(1))
                {
                    suma = suma + matMozos[fila, columna];
                    columna++;
                }
                columna = 0;
                fila++;
                suma = 0;
                vecTotales[fila] = suma;

            }
            fila = 0;
            mayor = vecTotales[0];
            for (fila = 0;fila < 4; fila++)
            {
                if (vecTotales[fila]>=mayor)
                {
                    mayor = vecTotales[fila];
                    mozo = fila;
                }
            }
            if (mozo==0)
            {
                lblMozo.Text = "Julio";
                lblTotal.Text=mayor.ToString();
            }
            else
            {
                if (mozo==1)
                {
                    lblMozo.Text = "Esteban";
                    lblTotal.Text = mayor.ToString();
                }
                else
                {
                    if (mozo==2)
                    {
                        lblMozo.Text = "Javier";
                        lblTotal.Text = mayor.ToString();
                    }
                    else
                    {
                        if (mozo==3)
                        {
                            lblMozo.Text = "Gonzalo";
                            lblTotal.Text = mayor.ToString();
                        }
                        else
                        {
                            if (mozo==4)
                            {
                                lblMozo.Text = "Alberto";
                                lblTotal.Text = mayor.ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
