using System;

namespace LibPayrollSystem
{
    public class PayrollSystem
    {
        
        public PayrollSystem() {}
        
        public double calculateNetToPay(Employee employee, int workingDays) {
            return (employee.BasicSalary / 30 * workingDays) + employee.Comission - employee.LoanInstallment;
        }               

    }
}
