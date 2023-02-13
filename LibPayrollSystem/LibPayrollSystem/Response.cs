using System;

namespace LibPayrollSystem
{
    public class Response
    {
        public string getMessageResponseOk(Employee employee, double netToPay) {
            return "El valor neto a pagar a " + employee.Name + " con número de identificación " + employee.Id + " es, $" + netToPay;
        }

        public string getMessageValidateError()
        {
            return "Error al validar. Por favor verifique las cantidades ingresadas. Dias laborados menor o igual a 30";
        }
    }
}

