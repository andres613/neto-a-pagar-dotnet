
namespace PayrollSystemUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBasicSalary = new System.Windows.Forms.TextBox();
            this.tbWorkingDays = new System.Windows.Forms.TextBox();
            this.tbLoanInstallment = new System.Windows.Forms.TextBox();
            this.tbComission = new System.Windows.Forms.TextBox();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(149, 82);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(172, 20);
            this.tbId.TabIndex = 0;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 118);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 20);
            this.tbName.TabIndex = 1;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbBasicSalary
            // 
            this.tbBasicSalary.Location = new System.Drawing.Point(149, 154);
            this.tbBasicSalary.Name = "tbBasicSalary";
            this.tbBasicSalary.Size = new System.Drawing.Size(172, 20);
            this.tbBasicSalary.TabIndex = 2;
            this.tbBasicSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBasicSalary_KeyPress);
            // 
            // tbWorkingDays
            // 
            this.tbWorkingDays.Location = new System.Drawing.Point(149, 190);
            this.tbWorkingDays.Name = "tbWorkingDays";
            this.tbWorkingDays.Size = new System.Drawing.Size(172, 20);
            this.tbWorkingDays.TabIndex = 3;
            this.tbWorkingDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWorkingDays_KeyPress);
            // 
            // tbLoanInstallment
            // 
            this.tbLoanInstallment.Location = new System.Drawing.Point(149, 226);
            this.tbLoanInstallment.Name = "tbLoanInstallment";
            this.tbLoanInstallment.Size = new System.Drawing.Size(172, 20);
            this.tbLoanInstallment.TabIndex = 4;
            this.tbLoanInstallment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoanInstallment_KeyPress);
            // 
            // tbComission
            // 
            this.tbComission.Location = new System.Drawing.Point(149, 263);
            this.tbComission.Name = "tbComission";
            this.tbComission.Size = new System.Drawing.Size(172, 20);
            this.tbComission.TabIndex = 5;
            this.tbComission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComission_KeyPress);
            // 
            // tbResponse
            // 
            this.tbResponse.Enabled = false;
            this.tbResponse.Location = new System.Drawing.Point(27, 314);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(294, 52);
            this.tbResponse.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(120, 385);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calcular básico";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identificación empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sueldo básico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dias laborados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cuota de préstamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comisión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aplicación para el cálculo de nómina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(353, 435);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.tbComission);
            this.Controls.Add(this.tbLoanInstallment);
            this.Controls.Add(this.tbWorkingDays);
            this.Controls.Add(this.tbBasicSalary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "ACN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBasicSalary;
        private System.Windows.Forms.TextBox tbWorkingDays;
        private System.Windows.Forms.TextBox tbLoanInstallment;
        private System.Windows.Forms.TextBox tbComission;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

