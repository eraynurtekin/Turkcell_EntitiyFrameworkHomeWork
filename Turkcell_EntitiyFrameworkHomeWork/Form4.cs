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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
                
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        blogContext bc = new blogContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Writer writer = new Writer()
            {
                WriterStatus = true,
                WriterName = textBoxName.Text,
                WriterAbout = textBoxAbout.Text,
                WriterMail = textBoxEmail.Text,
                WriterPassword = textBoxPassword.Text,
                WriterConfirmPassword=textBoxCPassword.Text,
            };
            bc.Writers.Add(writer);
            int result = bc.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }
    }
}
