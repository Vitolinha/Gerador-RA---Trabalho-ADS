namespace Gerador_de_RA
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
            lblGeradorRA = new Label();
            btnGerar = new Button();
            lblInsiraCampus = new Label();
            lblInsiraPeriodo = new Label();
            lblInsiraCurso = new Label();
            cboxPeriodo = new ComboBox();
            cboxCampus = new ComboBox();
            cboxCurso = new ComboBox();
            lblRA = new Label();
            SuspendLayout();
            // 
            // lblGeradorRA
            // 
            lblGeradorRA.AutoSize = true;
            lblGeradorRA.Font = new Font("Cascadia Mono", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeradorRA.Location = new Point(174, 30);
            lblGeradorRA.Name = "lblGeradorRA";
            lblGeradorRA.Size = new Size(308, 49);
            lblGeradorRA.TabIndex = 0;
            lblGeradorRA.Text = "GERADOR DE RA";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(135, 273);
            btnGerar.Name = "btnGerar";
            btnGerar.RightToLeft = RightToLeft.No;
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "GERAR";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lblInsiraCampus
            // 
            lblInsiraCampus.AutoSize = true;
            lblInsiraCampus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsiraCampus.Location = new Point(456, 126);
            lblInsiraCampus.Name = "lblInsiraCampus";
            lblInsiraCampus.Size = new Size(122, 21);
            lblInsiraCampus.TabIndex = 3;
            lblInsiraCampus.Text = "Insira o Campus";
            lblInsiraCampus.Click += lblInsiraCampus_Click;
            // 
            // lblInsiraPeriodo
            // 
            lblInsiraPeriodo.AutoSize = true;
            lblInsiraPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsiraPeriodo.Location = new Point(36, 126);
            lblInsiraPeriodo.Name = "lblInsiraPeriodo";
            lblInsiraPeriodo.Size = new Size(118, 21);
            lblInsiraPeriodo.TabIndex = 4;
            lblInsiraPeriodo.Text = "Insira o Período";
            // 
            // lblInsiraCurso
            // 
            lblInsiraCurso.AutoSize = true;
            lblInsiraCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsiraCurso.Location = new Point(258, 126);
            lblInsiraCurso.Name = "lblInsiraCurso";
            lblInsiraCurso.Size = new Size(106, 21);
            lblInsiraCurso.TabIndex = 5;
            lblInsiraCurso.Text = "Insira o Curso";
            // 
            // cboxPeriodo
            // 
            cboxPeriodo.FormattingEnabled = true;
            cboxPeriodo.Items.AddRange(new object[] { "Manhã", "Noite" });
            cboxPeriodo.Location = new Point(36, 150);
            cboxPeriodo.Name = "cboxPeriodo";
            cboxPeriodo.Size = new Size(121, 23);
            cboxPeriodo.TabIndex = 6;
            cboxPeriodo.SelectedIndexChanged += cboxPeriodo_SelectedIndexChanged;
            // 
            // cboxCampus
            // 
            cboxCampus.FormattingEnabled = true;
            cboxCampus.Items.AddRange(new object[] { "Sorocaba", "Itapetininga", "São Roque" });
            cboxCampus.Location = new Point(457, 150);
            cboxCampus.Name = "cboxCampus";
            cboxCampus.Size = new Size(121, 23);
            cboxCampus.TabIndex = 7;
            // 
            // cboxCurso
            // 
            cboxCurso.FormattingEnabled = true;
            cboxCurso.Items.AddRange(new object[] { "Ciência da Computação", "Análise e Desenvolvimento de Sistema", "Engenharia da Computação" });
            cboxCurso.Location = new Point(197, 150);
            cboxCurso.Name = "cboxCurso";
            cboxCurso.Size = new Size(228, 23);
            cboxCurso.TabIndex = 8;
            // 
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Location = new Point(357, 277);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(143, 15);
            lblRA.TabIndex = 9;
            lblRA.Text = "SEU RA APARECERÁ AQUI";
            lblRA.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 357);
            Controls.Add(lblRA);
            Controls.Add(cboxCurso);
            Controls.Add(cboxCampus);
            Controls.Add(cboxPeriodo);
            Controls.Add(lblInsiraCurso);
            Controls.Add(lblInsiraPeriodo);
            Controls.Add(lblInsiraCampus);
            Controls.Add(btnGerar);
            Controls.Add(lblGeradorRA);
            Name = "Form1";
            Text = "Gerador de RA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGeradorRA;
        private Button btnGerar;
        private Label lblInsiraCampus;
        private Label lblInsiraPeriodo;
        private Label lblInsiraCurso;
        private ComboBox cboxPeriodo;
        private ComboBox cboxCampus;
        private ComboBox cboxCurso;
        private Label lblRA;
    }
}
