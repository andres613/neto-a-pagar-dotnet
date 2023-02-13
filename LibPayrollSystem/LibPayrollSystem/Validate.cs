using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPayrollSystem
{
    public class Validate
    {
        #region VALIDATE
        public string validate(Employee employee, int workingDays)
        {
            if (employee.BasicSalary < 0 || employee.LoanInstallment < 0 || employee.Comission < 0 || workingDays < 0 || workingDays > 30)
                return "error";

            return "OK";
        }
        #endregion
    }
}
