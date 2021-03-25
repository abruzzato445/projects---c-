
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
            this.lName = new System.Windows.Forms.Label();
            this.tIdade = new System.Windows.Forms.Label();
            this.lIdade = new System.Windows.Forms.Label();
            this.tService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDayAtnd = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aName.Location = new System.Drawing.Point(60, 47);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(116, 16);
            this.aName.TabIndex = 4;
            this.aName.Text = "Nome cliente aqui";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(12, 47);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 16);
            this.lName.TabIndex = 3;
            this.lName.Text = "Nome";
            // 
            // tIdade
            // 
            this.tIdade.AutoSize = true;
            this.tIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdade.Location = new System.Drawing.Point(278, 47);
            this.tIdade.Name = "tIdade";
            this.tIdade.Size = new System.Drawing.Size(43, 16);
            this.tIdade.TabIndex = 6;
            this.tIdade.Text = "Idade";
            // 
            // lIdade
            // 
            this.lIdade.AutoSize = true;
            this.lIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdade.Location = new System.Drawing.Point(327, 47);
            this.lIdade.Name = "lIdade";
            this.lIdade.Size = new System.Drawing.Size(72, 16);
            this.lIdade.TabIndex = 7;
            this.lIdade.Text = "idade aqui";
            // 
            // tService
            // 
            this.tService.AutoSize = true;
            this.tService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tService.Location = new System.Drawing.Point(12, 141);
            this.tService.Name = "tService";
            this.tService.Size = new System.Drawing.Size(54, 16);
            this.tService.TabIndex = 8;
            this.tService.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // lDayAtnd
            // 
            this.lDayAtnd.AutoSize = true;
            this.lDayAtnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDayAtnd.Location = new System.Drawing.Point(267, 141);
            this.lDayAtnd.Name = "lDayAtnd";
            this.lDayAtnd.Size = new System.Drawing.Size(126, 16);
            this.lDayAtnd.TabIndex = 10;
            this.lDayAtnd.Text = "Dia do Atendimento";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(270, 176);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 322);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lDayAtnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tService);
            this.Controls.Add(this.lIdade);
            this.Controls.Add(this.tIdade);
            this.Controls.Add(this.aName);
            this.Controls.Add(this.lName);
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
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label tIdade;
        private System.Windows.Forms.Label lIdade;
        private System.Windows.Forms.Label tService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDayAtnd;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}