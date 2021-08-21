using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_department
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            WebDev dev = new WebDev();
            Designer designer = new Designer();
            DataScientist ds = new DataScientist();
            

            decimal salary;
            string name;
            try
            {
                salary = Convert.ToDecimal(txtSalary.Text);
                name = txtName.Text.ToUpper();

                if (rdDev.Checked)
                {
                    dev.Salary = salary;
                    dev.Name = name;
                    dev.Adjust();
                    lblResult.Text = "Result:" + dev.Salary.ToString();
                }
                else if (rdDesigner.Checked)
                {
                    designer.Salary = salary;
                    designer.Name = name;
                    designer.Adjust();
                    lblResult.Text = "Result:" + designer.Salary.ToString();

                }
                else if(rdDataS.Checked) 
                {
                    ds.Salary = salary;
                    ds.Name = name;
                    ds.Adjust();
                    lblResult.Text = "Result: " + ds.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Choose one of the options!");
                }

            }
            catch
            {
                MessageBox.Show("Please, fill out the required fields!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
