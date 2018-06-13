using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Form3 : Form
    {
        Form2 parent;
        public Form3(Form2 parent)
        {
            this.parent = parent;
            InitializeComponent();
            if (Clases.Controller.ReturnDecicion2() == 0)
            {
                label1.Text = "Peliculas";
                Apellido.Visible = false;
                Direccion.Visible = false;
                foreach (Clases.Pelicula a in Clases.Controller.ReturnPeliculas())
                {
                    dataGridView1.Rows.Add(a.nombre, a.director, null, null);
                }
            }
            else if (Clases.Controller.ReturnDecicion2() == 1)
            {
                label1.Text = "Actores";
                Director.Visible = false;
                Direccion.Visible = false;
                foreach (Clases.Actor a in Clases.Controller.ReturnActores())
                {
                    dataGridView1.Rows.Add(a.nombre, null, a.apellido, null);
                }
            }
            else if (Clases.Controller.ReturnDecicion2() == 2)
            {
                label1.Text = "Directores";
                Director.Visible = false;
                Direccion.Visible = false;
                foreach (Clases.Director a in Clases.Controller.ReturnDirector())
                {
                    dataGridView1.Rows.Add(a.nombre, null, a.apellido, null);
                }
            }
            else if (Clases.Controller.ReturnDecicion2() == 3)
            {
                label1.Text = "Productores";
                Director.Visible = false;
                Direccion.Visible = false;
                foreach (Clases.Productor a in Clases.Controller.ReturnProductores())
                {
                    dataGridView1.Rows.Add(a.nombre, null, a.apellido, null);
                }
            }
            else if (Clases.Controller.ReturnDecicion2() == 4)
            {
                label1.Text = "Estudios";
                Director.Visible = false;
                Apellido.Visible = false;
                foreach (Clases.Estudio a in Clases.Controller.ReturnEstudioS())
                {
                    dataGridView1.Rows.Add(a.nombre, "", "", a.direccion);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
