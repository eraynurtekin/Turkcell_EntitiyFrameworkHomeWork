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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blogContext bc = new blogContext();

            Blog blog = new Blog()
            {
                BlogStatıs = true,
                BlogContent = textBoxContent.Text,
                BlogTitle = textBoxTitle.Text,
                CategoryID = Convert.ToInt32(textBoxCategory.Text),
                WriterID = Convert.ToInt32(textBoxWriter.Text)
            };
            bc.Blogs.Add(blog);
            int result = bc.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}
