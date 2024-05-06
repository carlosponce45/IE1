namespace IE1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstClinica = new System.Windows.Forms.ListBox();
            this.lstPediatria = new System.Windows.Forms.ListBox();
            this.lstGuardia = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cmdLlamar = new System.Windows.Forms.Button();
            this.optGuardia = new System.Windows.Forms.RadioButton();
            this.optPediatria = new System.Windows.Forms.RadioButton();
            this.optClinica = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(235, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 29);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(472, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(24, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(179, 29);
            this.txtDNI.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clínica",
            "Pediatría",
            "Guardia"});
            this.comboBox1.Location = new System.Drawing.Point(684, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 29);
            this.comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Espera Clínica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Espera Peditría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Espera Guardia";
            // 
            // lstClinica
            // 
            this.lstClinica.FormattingEnabled = true;
            this.lstClinica.ItemHeight = 21;
            this.lstClinica.Location = new System.Drawing.Point(28, 114);
            this.lstClinica.Name = "lstClinica";
            this.lstClinica.Size = new System.Drawing.Size(275, 319);
            this.lstClinica.TabIndex = 11;
            // 
            // lstPediatria
            // 
            this.lstPediatria.FormattingEnabled = true;
            this.lstPediatria.ItemHeight = 21;
            this.lstPediatria.Location = new System.Drawing.Point(325, 114);
            this.lstPediatria.Name = "lstPediatria";
            this.lstPediatria.Size = new System.Drawing.Size(275, 319);
            this.lstPediatria.TabIndex = 12;
            // 
            // lstGuardia
            // 
            this.lstGuardia.FormattingEnabled = true;
            this.lstGuardia.ItemHeight = 21;
            this.lstGuardia.Location = new System.Drawing.Point(620, 114);
            this.lstGuardia.Name = "lstGuardia";
            this.lstGuardia.Size = new System.Drawing.Size(275, 319);
            this.lstGuardia.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdLlamar);
            this.groupBox1.Controls.Add(this.optGuardia);
            this.groupBox1.Controls.Add(this.optPediatria);
            this.groupBox1.Controls.Add(this.optClinica);
            this.groupBox1.Location = new System.Drawing.Point(24, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 89);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llamar a consultorio";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEjecutar.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEjecutar.Location = new System.Drawing.Point(613, 461);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(250, 46);
            this.btnEjecutar.TabIndex = 15;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            // 
            // cmdLlamar
            // 
            this.cmdLlamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdLlamar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdLlamar.Location = new System.Drawing.Point(589, 26);
            this.cmdLlamar.Name = "cmdLlamar";
            this.cmdLlamar.Size = new System.Drawing.Size(250, 52);
            this.cmdLlamar.TabIndex = 3;
            this.cmdLlamar.Text = "L L A M A R";
            this.cmdLlamar.UseVisualStyleBackColor = false;
            this.cmdLlamar.Click += new System.EventHandler(this.cmdLlamar_Click);
            // 
            // optGuardia
            // 
            this.optGuardia.AutoSize = true;
            this.optGuardia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optGuardia.Location = new System.Drawing.Point(366, 42);
            this.optGuardia.Name = "optGuardia";
            this.optGuardia.Size = new System.Drawing.Size(114, 36);
            this.optGuardia.TabIndex = 2;
            this.optGuardia.TabStop = true;
            this.optGuardia.Text = "Guardia";
            this.optGuardia.UseVisualStyleBackColor = true;
            // 
            // optPediatria
            // 
            this.optPediatria.AutoSize = true;
            this.optPediatria.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optPediatria.Location = new System.Drawing.Point(187, 42);
            this.optPediatria.Name = "optPediatria";
            this.optPediatria.Size = new System.Drawing.Size(123, 36);
            this.optPediatria.TabIndex = 1;
            this.optPediatria.TabStop = true;
            this.optPediatria.Text = "Pediatría";
            this.optPediatria.UseVisualStyleBackColor = true;
            // 
            // optClinica
            // 
            this.optClinica.AutoSize = true;
            this.optClinica.Checked = true;
            this.optClinica.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optClinica.Location = new System.Drawing.Point(26, 42);
            this.optClinica.Name = "optClinica";
            this.optClinica.Size = new System.Drawing.Size(102, 36);
            this.optClinica.TabIndex = 0;
            this.optClinica.TabStop = true;
            this.optClinica.Text = "Clínica";
            this.optClinica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(937, 614);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstGuardia);
            this.Controls.Add(this.lstPediatria);
            this.Controls.Add(this.lstClinica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Carga de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstClinica;
        private ListBox lstPediatria;
        private ListBox lstGuardia;
        private GroupBox groupBox1;
        private Button cmdLlamar;
        private RadioButton optGuardia;
        private RadioButton optPediatria;
        private RadioButton optClinica;
        private Button btnEjecutar;
    }
}