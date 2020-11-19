
namespace Agenda.Entities
{
    partial class WindowEdit
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxTel = new System.Windows.Forms.TextBox();
            this.tBoxObs = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(137, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NOME";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(119, 99);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(101, 20);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "TELEFONE";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(104, 183);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(132, 20);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "OBSERVAÇÃO";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(50, 48);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(231, 22);
            this.tBoxName.TabIndex = 3;
            this.tBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxTel
            // 
            this.tBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxTel.Location = new System.Drawing.Point(68, 134);
            this.tBoxTel.Name = "tBoxTel";
            this.tBoxTel.Size = new System.Drawing.Size(195, 22);
            this.tBoxTel.TabIndex = 4;
            this.tBoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxObs
            // 
            this.tBoxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxObs.Location = new System.Drawing.Point(14, 215);
            this.tBoxObs.Multiline = true;
            this.tBoxObs.Name = "tBoxObs";
            this.tBoxObs.Size = new System.Drawing.Size(303, 81);
            this.tBoxObs.TabIndex = 5;
            this.tBoxObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(121, 312);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(105, 29);
            this.bttnSave.TabIndex = 7;
            this.bttnSave.Text = "Salvar";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // WindowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 350);
            this.ControlBox = false;
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.tBoxObs);
            this.Controls.Add(this.tBoxTel);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowEdit";
            this.ShowIcon = false;
            this.Text = "Editar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxTel;
        private System.Windows.Forms.TextBox tBoxObs;
        private System.Windows.Forms.Button bttnSave;
    }
}