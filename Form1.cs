﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp_Danilkina
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = db.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.db = db;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                studentsBindingSource.DataSource = db.Students.ToList();
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Students students = (Students)studentsBindingSource.Current;
            DialogResult dr = MessageBox.Show(
           "Вы действительно хотите удалить роль - " + students.ID.ToString(),
           "Удаление роли", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Students.Remove(students);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                studentsBindingSource.DataSource = db.Students.ToList();
            }
        }
    }
}
