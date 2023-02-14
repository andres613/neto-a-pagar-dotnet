using LibPayrollSystem;
using System;

namespace PayrollSystemUI
{
    class PayrollSystemHandler
    {
        private string isValidate;
        private int workingDays;
        private double netToPay;
        private string messageResponse;

        public string getServiceResponse(string id, string name, string basicSalary, string loanInstallment, string comission, string workingDayCaptures)
        {
            try
            {
                Employee employee = new Seller(id, name, Convert.ToDouble(basicSalary), Convert.ToDouble(loanInstallment), Convert.ToDouble(comission));
                Validate validate = new Validate();
                PayrollSystem payrollSystem = new PayrollSystem();
                Response response = new Response();

                workingDays = Convert.ToInt32(workingDayCaptures);

                isValidate = validate.validate(employee, workingDays);

                if (isValidate == "OK")
                {
                    netToPay = payrollSystem.calculateNetToPay(employee, workingDays);
                    messageResponse = response.getMessageResponseOk(employee, netToPay);
                }
                else
                {
                    messageResponse = response.getMessageValidateError();
                }
            }
            catch (Exception exception)
            {
                messageResponse = exception.Message;
            }

            return messageResponse;
        }
    }
}
