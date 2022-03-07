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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        

        private void Form5_Load(object sender, EventArgs e)
        {
            blogContext bg = new blogContext();
            Writer writer = new Writer();

            var values = from write in bg.Writers
                         select new { Writer_Name = write.WriterName, Writer_About = write.WriterAbout, Writer_Email = write.WriterMail, Writer_Status = write.WriterStatus };

            var listValues = values.ToList();

            dataGridView1.DataSource = listValues;
        }
    }
}
