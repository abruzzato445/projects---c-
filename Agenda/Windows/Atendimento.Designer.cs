
namespace Agenda
{
    partial class Atendimento
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
            this.aName = new System.Windows.Forms.Label();
            this.aIdade = new System.Windows.Forms.Label();
            this.tService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDayAtnd = new System.Windows.Forms.Label();
            this.dtpDAT = new System.Windows.Forms.DateTimePicker();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aName.Location = new System.Drawing.Point(12, 9);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(180, 24);
            this.aName.TabIndex = 4;
            this.aName.Text = "Nome cliente aqui";
            // 
            // aIdade
            // 
            this.aIdade.AutoSize = true;
            this.aIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aIdade.Location = new System.Drawing.Point(13, 50);
            this.aIdade.Name = "aIdade";
            this.aIdade.Size = new System.Drawing.Size(72, 16);
            this.aIdade.TabIndex = 7;
            this.aIdade.Text = "idade aqui";
            // 
            // tService
            // 
            this.tService.AutoSize = true;
            this.tService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tService.Location = new System.Drawing.Point(12, 108);
            this.tService.Name = "tService";
            this.tService.Size = new System.Drawing.Size(61, 20);
            this.tService.TabIndex = 8;
            this.tService.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // lDayAtnd
            // 
            this.lDayAtnd.AutoSize = true;
            this.lDayAtnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDayAtnd.Location = new System.Drawing.Point(173, 108);
            this.lDayAtnd.Name = "lDayAtnd";
            this.lDayAtnd.Size = new System.Drawing.Size(150, 20);
            this.lDayAtnd.TabIndex = 10;
            this.lDayAtnd.Text = "Dia do Atendimento";
            // 
            // dtpDAT
            // 
            this.dtpDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDAT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDAT.Location = new System.Drawing.Point(182, 142);
            this.dtpDAT.Name = "dtpDAT";
            this.dtpDAT.Size = new System.Drawing.Size(121, 22);
            this.dtpDAT.TabIndex = 11;
            // 
            // cbxServico
            // 
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Items.AddRange(new object[] {
            "CABELO",
            "BARBA",
            "MÁQUINA",
            "PÉZINHO",
            "C/B",
            "M/B"});
            this.cbxServico.Location = new System.Drawing.Point(8, 142);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(140, 21);
            this.cbxServico.TabIndex = 12;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(208, 226);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(95, 37);
            this.bttnSave.TabIndex = 13;
            this.bttnSave.Text = "Salvar";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.cbxServico);
            this.Controls.Add(this.dtpDAT);
            this.Controls.Add(this.lDayAtnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tService);
            this.Controls.Add(this.aIdade);
            this.Controls.Add(this.aName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Atendimento";
            this.ShowIcon = false;
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label aIdade;
        private System.Windows.Forms.Label tService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDayAtnd;
        private System.Windows.Forms.DateTimePicker dtpDAT;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button button1;
    }
}