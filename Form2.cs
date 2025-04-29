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
    public partial class Form2 : Form
    {
        public Model1 db {  get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (gruppaTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            int id;
            bool b = int.TryParse(iDTextBox.Text, out id);
            if (b == false)
            {
                MessageBox.Show("Неверный формат ID - " + iDTextBox.Text);
                return;
            }
            int vozract;
            b = int.TryParse(iDTextBox.Text, out vozract);
            if (b == false)
            {
                MessageBox.Show("Неверный формат ID - " + iDTextBox.Text);
                return;
            }
            Students students = new Students();
            students.ID = id;
            students.Name = nameTextBox.Text;
            students.Gruppa = gruppaTextBox.Text;
            students.Vozract = vozract;

            db.Students.Add(students);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

    }
}
