using System;

namespace LibPayrollSystem {
	public class Seller : Employee
	{
		#region ATRIBUTOS
		private string id;
		private string name;
		private double basicSalary;
		private double loanInstallment;
		private double comission;
		#endregion


		public Seller(string id, string name, double basicSalary, double loanInstallment, double comission)
		{
			this.id = id;
			this.name = name;
			this.basicSalary = basicSalary;
			this.loanInstallment = loanInstallment;
			this.comission = comission;
		}

		#region PROPIEDADES
		
		public string Id { get => id; set => id = value; }
		
		public string Name { get => name; set => name = value; }
        
		public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        
		public double LoanInstallment { get => loanInstallment; set => loanInstallment = value; }
        
		public double Comission { get => comission; set => comission = value; }

        #endregion
    }
}

