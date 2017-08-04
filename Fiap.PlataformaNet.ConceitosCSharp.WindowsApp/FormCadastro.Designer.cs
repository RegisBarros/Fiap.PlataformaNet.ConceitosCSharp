namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp
{
    partial class FormCadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incluirEventoButton = new System.Windows.Forms.Button();
            this.responsavelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listarPorEventoButton = new System.Windows.Forms.Button();
            this.convidadosListBox = new System.Windows.Forms.ListBox();
            this.incluirConvidadoButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecharButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.incluirEventoButton);
            this.groupBox1.Controls.Add(this.responsavelTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataMaskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // incluirEventoButton
            // 
            this.incluirEventoButton.Location = new System.Drawing.Point(358, 20);
            this.incluirEventoButton.Name = "incluirEventoButton";
            this.incluirEventoButton.Size = new System.Drawing.Size(116, 24);
            this.incluirEventoButton.TabIndex = 6;
            this.incluirEventoButton.Text = "Incluir Evento";
            this.incluirEventoButton.UseVisualStyleBackColor = true;
            this.incluirEventoButton.Click += new System.EventHandler(this.incluirEventoButton_Click);
            // 
            // responsavelTextBox
            // 
            this.responsavelTextBox.Location = new System.Drawing.Point(99, 77);
            this.responsavelTextBox.Name = "responsavelTextBox";
            this.responsavelTextBox.Size = new System.Drawing.Size(202, 20);
            this.responsavelTextBox.TabIndex = 5;
            this.responsavelTextBox.Leave += new System.EventHandler(this.responsavelTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Responsável:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(99, 51);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(202, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.Location = new System.Drawing.Point(99, 25);
            this.dataMaskedTextBox.Mask = "00/00/0000";
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.dataMaskedTextBox.TabIndex = 1;
            this.dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listarPorEventoButton);
            this.groupBox2.Controls.Add(this.convidadosListBox);
            this.groupBox2.Controls.Add(this.incluirConvidadoButton);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.eventoComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convidados";
            // 
            // listarPorEventoButton
            // 
            this.listarPorEventoButton.Location = new System.Drawing.Point(357, 72);
            this.listarPorEventoButton.Name = "listarPorEventoButton";
            this.listarPorEventoButton.Size = new System.Drawing.Size(116, 24);
            this.listarPorEventoButton.TabIndex = 11;
            this.listarPorEventoButton.Text = "Listar por Evento";
            this.listarPorEventoButton.UseVisualStyleBackColor = true;
            this.listarPorEventoButton.Click += new System.EventHandler(this.listarPorEventoButton_Click);
            // 
            // convidadosListBox
            // 
            this.convidadosListBox.FormattingEnabled = true;
            this.convidadosListBox.Location = new System.Drawing.Point(17, 111);
            this.convidadosListBox.Name = "convidadosListBox";
            this.convidadosListBox.Size = new System.Drawing.Size(456, 108);
            this.convidadosListBox.TabIndex = 12;
            // 
            // incluirConvidadoButton
            // 
            this.incluirConvidadoButton.Location = new System.Drawing.Point(357, 46);
            this.incluirConvidadoButton.Name = "incluirConvidadoButton";
            this.incluirConvidadoButton.Size = new System.Drawing.Size(116, 24);
            this.incluirConvidadoButton.TabIndex = 10;
            this.incluirConvidadoButton.Text = "Incluir Convidado";
            this.incluirConvidadoButton.UseVisualStyleBackColor = true;
            this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(99, 72);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(99, 46);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(223, 20);
            this.nomeTextBox.TabIndex = 7;
            this.nomeTextBox.Leave += new System.EventHandler(this.nomeTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome:";
            // 
            // eventoComboBox
            // 
            this.eventoComboBox.FormattingEnabled = true;
            this.eventoComboBox.Location = new System.Drawing.Point(99, 19);
            this.eventoComboBox.Name = "eventoComboBox";
            this.eventoComboBox.Size = new System.Drawing.Size(374, 21);
            this.eventoComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Evento:";
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(410, 373);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(86, 24);
            this.fecharButton.TabIndex = 13;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Eventos e Convidados";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button incluirEventoButton;
        private System.Windows.Forms.TextBox responsavelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button listarPorEventoButton;
        private System.Windows.Forms.ListBox convidadosListBox;
        private System.Windows.Forms.Button incluirConvidadoButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox eventoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fecharButton;
    }
}

