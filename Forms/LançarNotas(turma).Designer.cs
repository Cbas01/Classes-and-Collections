namespace Alunos_e_Notas
{
    partial class LançarNotas_turma_
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
            this.cbbDiscip = new System.Windows.Forms.ComboBox();
            this.lblDisc = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbDiscip
            // 
            this.cbbDiscip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscip.FormattingEnabled = true;
            this.cbbDiscip.Items.AddRange(new object[] {
            "PT",
            "ING",
            "TIC",
            "EF",
            "AI",
            "FQ",
            "MAT",
            "PSI",
            "SO",
            "AC",
            "RC"});
            this.cbbDiscip.Location = new System.Drawing.Point(35, 46);
            this.cbbDiscip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDiscip.Name = "cbbDiscip";
            this.cbbDiscip.Size = new System.Drawing.Size(219, 24);
            this.cbbDiscip.TabIndex = 2;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(31, 26);
            this.lblDisc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(68, 17);
            this.lblDisc.TabIndex = 3;
            this.lblDisc.Text = "Disciplina";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(35, 128);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(87, 22);
            this.txtModulo.TabIndex = 4;
            this.txtModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Módulo";
            // 
            // txtNota
            // 
            this.txtNota.Enabled = false;
            this.txtNota.Location = new System.Drawing.Point(35, 343);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(119, 22);
            this.txtNota.TabIndex = 6;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(29, 273);
            this.lblNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(49, 25);
            this.lblNro.TabIndex = 7;
            this.lblNro.Text = "Nro:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 231);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome: ";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Enabled = false;
            this.btnLaunch.Location = new System.Drawing.Point(192, 343);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(100, 28);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.Text = "Lançar Nota";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(35, 170);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 28);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Seleccionar disciplina e modulo";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // LançarNotas_turma_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 441);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.cbbDiscip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LançarNotas_turma_";
            this.Text = "LançarNotas_turma_";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LançarNotas_turma__FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDiscip;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnSelect;
    }
}