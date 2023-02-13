using LibPayrollSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void tbBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void tbWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbLoanInstallment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void tbComission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string isValidate;
            int workingDays;
            double netToPay;
            
            string messageResponse = "";
            
            try
            {
                Employee employee = new Seller(tbId.Text, tbName.Text, Convert.ToDouble(tbBasicSalary.Text), Convert.ToDouble(tbLoanInstallment.Text), Convert.ToDouble(tbComission.Text));
                Validate validate = new Validate();
                PayrollSystem payrollSystem = new PayrollSystem();
                Response response = new Response(); 
                
                workingDays = Convert.ToInt32(tbWorkingDays.Text);

                isValidate = validate.validate(employee, workingDays);
                
                if(isValidate == "OK") {
                    netToPay = payrollSystem.calculateNetToPay(employee, workingDays);
                    messageResponse = response.getMessageResponseOk(employee, netToPay);
                } else {
                    messageResponse = response.getMessageValidateError();
                }
            }
            catch (Exception exception)
            {
                messageResponse = exception.Message;
            }

            tbResponse.Text = messageResponse;
        }

    }
}
