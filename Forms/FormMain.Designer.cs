namespace Alunos_e_Notas
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotatodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médias1AlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstvAlunos = new System.Windows.Forms.ListView();
            this.ColNro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDisc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNotas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.retirarAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // retirarAlunoToolStripMenuItem
            // 
            this.retirarAlunoToolStripMenuItem.Name = "retirarAlunoToolStripMenuItem";
            this.retirarAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.retirarAlunoToolStripMenuItem.Text = "Retirar aluno";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarNotaToolStripMenuItem,
            this.lançarNotatodosToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // lançarNotaToolStripMenuItem
            // 
            this.lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            this.lançarNotaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lançarNotaToolStripMenuItem.Text = "Lançar nota (1 aluno)";
            this.lançarNotaToolStripMenuItem.Click += new System.EventHandler(this.lançarNotaToolStripMenuItem_Click);
            // 
            // lançarNotatodosToolStripMenuItem
            // 
            this.lançarNotatodosToolStripMenuItem.Name = "lançarNotatodosToolStripMenuItem";
            this.lançarNotatodosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lançarNotatodosToolStripMenuItem.Text = "Lançar nota (todos)";
            this.lançarNotatodosToolStripMenuItem.Click += new System.EventHandler(this.lançarNotatodosToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médias1AlunoToolStripMenuItem,
            this.médiaTurmaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // médias1AlunoToolStripMenuItem
            // 
            this.médias1AlunoToolStripMenuItem.Name = "médias1AlunoToolStripMenuItem";
            this.médias1AlunoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.médias1AlunoToolStripMenuItem.Text = "Média (aluno)";
            // 
            // médiaTurmaToolStripMenuItem
            // 
            this.médiaTurmaToolStripMenuItem.Name = "médiaTurmaToolStripMenuItem";
            this.médiaTurmaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.médiaTurmaToolStripMenuItem.Text = "Média (Turma)";
            // 
            // lstvAlunos
            // 
            this.lstvAlunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNro,
            this.ColDisc,
            this.ColModulo,
            this.ColNotas});
            this.lstvAlunos.Location = new System.Drawing.Point(16, 156);
            this.lstvAlunos.Name = "lstvAlunos";
            this.lstvAlunos.Size = new System.Drawing.Size(396, 251);
            this.lstvAlunos.TabIndex = 1;
            this.lstvAlunos.UseCompatibleStateImageBehavior = false;
            this.lstvAlunos.View = System.Windows.Forms.View.Details;
            // 
            // ColNro
            // 
            this.ColNro.Text = "Nro";
            this.ColNro.Width = 87;
            // 
            // ColDisc
            // 
            this.ColDisc.Text = "Disciplina";
            this.ColDisc.Width = 90;
            // 
            // ColModulo
            // 
            this.ColModulo.Text = "Módulo";
            this.ColModulo.Width = 98;
            // 
            // ColNotas
            // 
            this.ColNotas.Text = "Nota";
            this.ColNotas.Width = 78;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(424, 438);
            this.Controls.Add(this.lstvAlunos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotatodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médias1AlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaTurmaToolStripMenuItem;
        private System.Windows.Forms.ListView lstvAlunos;
        private System.Windows.Forms.ColumnHeader ColNro;
        private System.Windows.Forms.ColumnHeader ColDisc;
        private System.Windows.Forms.ColumnHeader ColModulo;
        private System.Windows.Forms.ColumnHeader ColNotas;
    }
}

