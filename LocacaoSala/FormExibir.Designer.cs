
namespace LocacaoSala
{
    partial class FormExibir
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
            this.listBoxSala = new System.Windows.Forms.ListBox();
            this.listBoxHorario = new System.Windows.Forms.ListBox();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxHorasFim = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSala
            // 
            this.listBoxSala.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSala.FormattingEnabled = true;
            this.listBoxSala.ItemHeight = 15;
            this.listBoxSala.Location = new System.Drawing.Point(28, 27);
            this.listBoxSala.Name = "listBoxSala";
            this.listBoxSala.Size = new System.Drawing.Size(307, 139);
            this.listBoxSala.TabIndex = 0;
            this.listBoxSala.SelectedIndexChanged += new System.EventHandler(this.listBoxSala_SelectedIndexChanged);
            // 
            // listBoxHorario
            // 
            this.listBoxHorario.FormattingEnabled = true;
            this.listBoxHorario.ItemHeight = 15;
            this.listBoxHorario.Location = new System.Drawing.Point(28, 195);
            this.listBoxHorario.Name = "listBoxHorario";
            this.listBoxHorario.Size = new System.Drawing.Size(121, 169);
            this.listBoxHorario.TabIndex = 1;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(41, 225);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(227, 23);
            this.dateTimePickerHoraInicio.TabIndex = 2;
            // 
            // dateTimePickerHoraFim
            // 
            this.dateTimePickerHoraFim.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.dateTimePickerHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraFim.Location = new System.Drawing.Point(41, 269);
            this.dateTimePickerHoraFim.Name = "dateTimePickerHoraFim";
            this.dateTimePickerHoraFim.Size = new System.Drawing.Size(227, 23);
            this.dateTimePickerHoraFim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora fim:";
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelCadastro.Controls.Add(this.monthCalendar1);
            this.panelCadastro.Controls.Add(this.buttonExcluir);
            this.panelCadastro.Controls.Add(this.buttonSalvar);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Controls.Add(this.label2);
            this.panelCadastro.Controls.Add(this.dateTimePickerHoraInicio);
            this.panelCadastro.Controls.Add(this.dateTimePickerHoraFim);
            this.panelCadastro.Location = new System.Drawing.Point(384, 12);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(307, 354);
            this.panelCadastro.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(41, 314);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(193, 314);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora Início:";
            // 
            // listBoxHorasFim
            // 
            this.listBoxHorasFim.FormattingEnabled = true;
            this.listBoxHorasFim.ItemHeight = 15;
            this.listBoxHorasFim.Location = new System.Drawing.Point(214, 195);
            this.listBoxHorasFim.Name = "listBoxHorasFim";
            this.listBoxHorasFim.Size = new System.Drawing.Size(121, 169);
            this.listBoxHorasFim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(214, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora Fim:";
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocacaoSala.Properties.Resources.Senac__1_;
            this.ClientSize = new System.Drawing.Size(716, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxHorasFim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.listBoxHorario);
            this.Controls.Add(this.listBoxSala);
            this.Name = "FormExibir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAC";
            this.Load += new System.EventHandler(this.FormExibir_Load);
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSala;
        private System.Windows.Forms.ListBox listBoxHorario;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ListBox listBoxHorasFim;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
    }
}