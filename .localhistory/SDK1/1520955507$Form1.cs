using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            int rowAmount = Convert.ToInt32(tBxRow.Text);
            int columnAmount = Convert.ToInt32(tBxColumn.Text);
            for (int i = 0; i < rowAmount; i++)
            {

                for (int f = 0; f < columnAmount*3; f++)
                {   

                }
            }
        }
    }
}
