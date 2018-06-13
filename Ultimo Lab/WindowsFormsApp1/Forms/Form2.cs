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
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            textBox1.AutoCompleteCustomSource = DataCollection;
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            foreach (Clases.Actor a in Clases.Controller.ReturnActores())
            {
                col.Add(a.nombre);
            }
            foreach (Clases.Director d in Clases.Controller.ReturnDirector())
            {
                col.Add(d.nombre);
            }
            foreach (Clases.Productor p in Clases.Controller.ReturnProductores())
            {
                col.Add(p.nombre);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Controller.ReturnDecicion(0);
            Form3 openform3 = new Form3(this);
            openform3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.Controller.ReturnDecicion(1);
            Form3 openform3 = new Form3(this);
            openform3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Controller.ReturnDecicion(2);
            Form3 openform3 = new Form3(this);
            openform3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clases.Controller.ReturnDecicion(3);
            Form3 openform3 = new Form3(this);
            openform3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clases.Controller.ReturnDecicion(4);
            Form3 openform3 = new Form3(this);
            openform3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 openform4 = new Form4(this);
            openform4.Show();
            this.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            Clases.Controller.Serializar();
            base.OnClosed(e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
