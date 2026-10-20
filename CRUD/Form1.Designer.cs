namespace CRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NOME = new TextBox();
            SOBRENOME = new TextBox();
            CURSO = new TextBox();
            ANO = new TextBox();
            IDADE = new TextBox();
            RM = new TextBox();
            SALVAR = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "SOBRENOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 82);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "CURSO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 139);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "IDADE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 163);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 4;
            label5.Text = "RM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 111);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 5;
            label6.Text = "ANO";
            // 
            // NOME
            // 
            NOME.BackColor = Color.FromArgb(255, 192, 255);
            NOME.Location = new Point(170, 15);
            NOME.Name = "NOME";
            NOME.Size = new Size(170, 23);
            NOME.TabIndex = 6;
            NOME.TextChanged += textBox1_TextChanged;
            // 
            // SOBRENOME
            // 
            SOBRENOME.BackColor = Color.FromArgb(255, 192, 255);
            SOBRENOME.Location = new Point(184, 48);
            SOBRENOME.Name = "SOBRENOME";
            SOBRENOME.Size = new Size(210, 23);
            SOBRENOME.TabIndex = 7;
            // 
            // CURSO
            // 
            CURSO.BackColor = Color.FromArgb(255, 192, 255);
            CURSO.Location = new Point(152, 74);
            CURSO.Name = "CURSO";
            CURSO.Size = new Size(136, 23);
            CURSO.TabIndex = 8;
            // 
            // ANO
            // 
            ANO.BackColor = Color.FromArgb(255, 192, 255);
            ANO.Location = new Point(152, 103);
            ANO.Name = "ANO";
            ANO.Size = new Size(100, 23);
            ANO.TabIndex = 9;
            // 
            // IDADE
            // 
            IDADE.BackColor = Color.FromArgb(255, 192, 255);
            IDADE.Location = new Point(149, 131);
            IDADE.Name = "IDADE";
            IDADE.Size = new Size(78, 23);
            IDADE.TabIndex = 10;
            IDADE.TextChanged += textBox5_TextChanged;
            // 
            // RM
            // 
            RM.BackColor = Color.FromArgb(255, 192, 255);
            RM.ForeColor = SystemColors.InactiveCaption;
            RM.Location = new Point(136, 155);
            RM.Name = "RM";
            RM.Size = new Size(100, 23);
            RM.TabIndex = 11;
            RM.TextChanged += textBox6_TextChanged;
            // 
            // SALVAR
            // 
            SALVAR.AccessibleName = "";
            SALVAR.BackColor = Color.MediumSlateBlue;
            SALVAR.ForeColor = SystemColors.ControlLight;
            SALVAR.Location = new Point(101, 208);
            SALVAR.Name = "SALVAR";
            SALVAR.Size = new Size(122, 68);
            SALVAR.TabIndex = 12;
            SALVAR.Text = "SALVAR";
            SALVAR.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SALVAR);
            Controls.Add(RM);
            Controls.Add(IDADE);
            Controls.Add(ANO);
            Controls.Add(CURSO);
            Controls.Add(SOBRENOME);
            Controls.Add(NOME);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NOME;
        private TextBox SOBRENOME;
        private TextBox CURSO;
        private TextBox ANO;
        private TextBox IDADE;
        private TextBox RM;
        private Button SALVAR;
    }
}
