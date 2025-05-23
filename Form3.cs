using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsApp_Danilkina
{
    public partial class Form3 : Form
    {
        public Model1 db { get; set; }

        public Students students { get; set; }

        Students studentsl;


        public Form3()
        {
            InitializeComponent();
        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gruppaLabel_Click(object sender, EventArgs e)
        {

        }

        private void gruppaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vozractLabel_Click(object sender, EventArgs e)
        {

        }

        private void vozractTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Name = nameTextBox.Text;
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }

               catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Students students = (Students)studentsBindingSource.Current;
            frm.db = db;
            frm.students = students;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            studentsBindingSource.DataSource = db.Students.ToList();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danilkina_RKISDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.danilkina_RKISDataSet1.Students);
            iDTextBox.Text = students.ID.ToString();
            nameTextBox.Text = students.Name;
            gruppaTextBox.Text = students.Gruppa;
            vozractTextBox.Text = students.Vozract.ToString();

        }
    }
}
