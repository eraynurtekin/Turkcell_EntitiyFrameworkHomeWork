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

namespace Turkcell_EntitiyFrameworkHomeWork
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        blogContext bc = new blogContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            var list = bc.Categories.ToList();

            dataGridView1.DataSource = list;
        }
    }
}
