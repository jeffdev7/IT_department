
namespace IT_department
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.rdDev = new System.Windows.Forms.RadioButton();
            this.rdDesigner = new System.Windows.Forms.RadioButton();
            this.rdDataS = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(32, 105);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 16);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(32, 375);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 15);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(35, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(35, 141);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 7;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust.Location = new System.Drawing.Point(35, 330);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 8;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // rdDev
            // 
            this.rdDev.AutoSize = true;
            this.rdDev.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDev.Location = new System.Drawing.Point(35, 193);
            this.rdDev.Name = "rdDev";
            this.rdDev.Size = new System.Drawing.Size(109, 19);
            this.rdDev.TabIndex = 9;
            this.rdDev.TabStop = true;
            this.rdDev.Text = "Web developer";
            this.rdDev.UseVisualStyleBackColor = true;
            // 
            // rdDesigner
            // 
            this.rdDesigner.AutoSize = true;
            this.rdDesigner.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDesigner.Location = new System.Drawing.Point(35, 238);
            this.rdDesigner.Name = "rdDesigner";
            this.rdDesigner.Size = new System.Drawing.Size(76, 19);
            this.rdDesigner.TabIndex = 10;
            this.rdDesigner.TabStop = true;
            this.rdDesigner.Text = "Designer";
            this.rdDesigner.UseVisualStyleBackColor = true;
            // 
            // rdDataS
            // 
            this.rdDataS.AutoSize = true;
            this.rdDataS.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDataS.Location = new System.Drawing.Point(35, 283);
            this.rdDataS.Name = "rdDataS";
            this.rdDataS.Size = new System.Drawing.Size(106, 19);
            this.rdDataS.TabIndex = 11;
            this.rdDataS.TabStop = true;
            this.rdDataS.Text = "Data Scientist";
            this.rdDataS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.rdDataS);
            this.Controls.Add(this.rdDesigner);
            this.Controls.Add(this.rdDev);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.RadioButton rdDev;
        private System.Windows.Forms.RadioButton rdDesigner;
        private System.Windows.Forms.RadioButton rdDataS;
    }
}

