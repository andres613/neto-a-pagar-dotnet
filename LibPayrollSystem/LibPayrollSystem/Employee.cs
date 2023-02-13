using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPayrollSystem
{
    public interface Employee
    {
        string Id { get; set; }

        string Name { get; set; }

        double BasicSalary { get; set; }

        //double LoanInstallment { get; set; }

        double Comission { get; set; }
    }
}
