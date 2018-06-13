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
    public partial class Form4 : Form
    {
        Clases.Actor actor;
        Clases.Pelicula pelicula;
        Clases.Director director;
        Clases.Productor productor;
        Clases.Estudio estudio;
        Form2 parent;
        public Form4(Form2 parent)
        {
            this.parent = parent;
            InitializeComponent(); 

            comboBox1.Items.Add("Pelicula");
            comboBox1.Items.Add("Actor");
            comboBox1.Items.Add("Director");
            comboBox1.Items.Add("Productor");
            comboBox1.Items.Add("Estudio");
            comboBox1.Items.Add("Critica");

            foreach (Clases.Estudio es in Clases.Controller.ReturnEstudioS())
            {
                comboBox2.Items.Add(es.nombre);
            }

            dateTimePicker1.MinDate = new DateTime(1800, 01, 01);
            dateTimePicker1.MaxDate = new DateTime(2017, 12, 31);


            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                label6.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;

                if (comboBox1.SelectedItem.ToString() == "Pelicula")
                {
                    label3.Text = "Fecha Estreno: ";
                    label5.Text = "Director: ";
                    label6.Text = "Descripcion: ";
                    label7.Visible = true;
                    label8.Visible = true;
                    textBox4.Visible = true;
                    comboBox2.Visible = true;
                    label9.Visible = true;
                    textBox5.Visible = true;
                    label10.Visible = true;
                    textBox6.Visible = true;
                    dateTimePicker1.MinDate.AddYears(180);
                    dateTimePicker1.MaxDate.AddYears(5);
                    Clases.Critica critica = new Clases.Critica(textBox6.Text, textBox5.Text);
                    pelicula = new Clases.Pelicula(textBox1.Text, textBox2.Text, dateTimePicker1.ToString(), textBox3.Text, Int32.Parse(textBox4.Text), Clases.Controller.ReturnEstudio(comboBox2.SelectedItem.ToString()), critica);
                }
                else if (comboBox1.SelectedItem.ToString() == "Actor")
                {
                    label3.Text = " Fecha de Nacimiento: ";
                    label5.Text = "Apellido: ";
                    label6.Text = "Biografia: ";
                    actor = new Clases.Actor(textBox1.Text, textBox2.Text, dateTimePicker1.ToString(), textBox3.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "Director")
                {
                    label3.Text = " Fecha de Nacimiento: ";
                    label5.Text = "Apellido: ";
                    label6.Text = "Biografia: ";
                    director = new Clases.Director(textBox1.Text, textBox2.Text, dateTimePicker1.ToString(), textBox3.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "Productor")
                {
                    label3.Text = " Fecha de Nacimiento: ";
                    label5.Text = "Apellido: ";
                    label6.Text = "Biografia: ";
                    productor = new Clases.Productor(textBox1.Text, textBox2.Text, dateTimePicker1.ToString(), textBox3.Text);

                }
                else
                {
                    label3.Text = "Fecha de Apertura: ";
                    label5.Text = "Direccion: ";
                    label6.Visible = false;
                    textBox3.Visible = false;
                    dateTimePicker1.MinDate.AddYears(180);
                    dateTimePicker1.MaxDate.AddYears(5);
                    estudio = new Clases.Estudio(textBox1.Text, textBox2.Text, dateTimePicker1.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (actor != null)
            {
                Clases.Controller.AgregarActor(actor);
            }
            if (productor != null)
            {
                Clases.Controller.AgregarProductor(productor);
            }
            if (director != null)
            {
                Clases.Controller.AgregarDirector(director);
            }
            if (pelicula != null)
            {
                Clases.Controller.AgregarPelicula(pelicula);
            }
            if (estudio != null)
            {
                Clases.Controller.AgregarEstudio(estudio);
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
