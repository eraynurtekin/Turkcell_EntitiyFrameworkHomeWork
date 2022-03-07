using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turkcell_EntitiyFrameworkHomeWork.Data;
using Turkcell_EntitiyFrameworkHomeWork.Models;

namespace Turkcell_EntitiyFrameworkHomeWork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        blogContext bc = new blogContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryStatus = true,
                CategoryName = textBoxCategoryName.Text,
                CategoryDescription = textBoxDescription.Text,
            };
            bc.Categories.Add(category);
            int result = bc.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
