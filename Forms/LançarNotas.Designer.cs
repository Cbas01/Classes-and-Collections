namespace Alunos_e_Notas
{
    partial class LançarNotas
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
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.cbbDiscip = new System.Windows.Forms.ComboBox();
            this.lblDisc = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAlunos
            // 
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.ItemHeight = 16;
            this.lstAlunos.Location = new System.Drawing.Point(16, 15);
            this.lstAlunos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(268, 436);
            this.lstAlunos.TabIndex = 0;
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
            this.cbbDiscip.Location = new System.Drawing.Point(316, 34);
            this.cbbDiscip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDiscip.Name = "cbbDiscip";
            this.cbbDiscip.Size = new System.Drawing.Size(219, 24);
            this.cbbDiscip.TabIndex = 1;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(312, 15);
            this.lblDisc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(68, 17);
            this.lblDisc.TabIndex = 2;
            this.lblDisc.Text = "Disciplina";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(316, 117);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(87, 22);
            this.txtModulo.TabIndex = 3;
            this.txtModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulo_KeyPress);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(449, 117);
            this.txtNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(87, 22);
            this.txtNota.TabIndex = 3;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(445, 97);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 17);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Nota";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 263);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LançarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.cbbDiscip);
            this.Controls.Add(this.lstAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LançarNotas";
            this.Text = "LançarNotas";
            this.Activated += new System.EventHandler(this.LançarNotas_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LançarNotas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.ComboBox cbbDiscip;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button button1;
    }
}