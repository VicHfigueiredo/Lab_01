
namespace Lab_01
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(161, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(468, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Visualizar dados na caixa de tetxo";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurso.Location = new System.Drawing.Point(149, 184);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(56, 20);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(211, 127);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(332, 23);
            this.tbxNome.TabIndex = 3;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "PHP",
            "JAVA",
            "JavaScript",
            "Python",
            "Object_C",
            "CSharp",
            "C++",
            "C"});
            this.cbxCurso.Location = new System.Drawing.Point(211, 181);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(186, 23);
            this.cbxCurso.TabIndex = 4;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(149, 127);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensagem.Location = new System.Drawing.Point(149, 274);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(480, 123);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExibir.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExibir.Location = new System.Drawing.Point(149, 222);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(480, 38);
            this.btnExibir.TabIndex = 7;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Laboratório";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExibir;
    }
}

