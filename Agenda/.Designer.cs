namespace Agenda
{
    partial class wMain
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
            this.titileName = new System.Windows.Forms.Label();
            this.titleTel = new System.Windows.Forms.Label();
            this.titleObs = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_telefone = new System.Windows.Forms.TextBox();
            this.txtbox_observacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.titlewMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titileName
            // 
            this.titileName.AutoSize = true;
            this.titileName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titileName.Location = new System.Drawing.Point(12, 142);
            this.titileName.Name = "titileName";
            this.titileName.Size = new System.Drawing.Size(52, 23);
            this.titileName.TabIndex = 0;
            this.titileName.Text = "Nome";
            // 
            // titleTel
            // 
            this.titleTel.AutoSize = true;
            this.titleTel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTel.Location = new System.Drawing.Point(329, 145);
            this.titleTel.Name = "titleTel";
            this.titleTel.Size = new System.Drawing.Size(70, 23);
            this.titleTel.TabIndex = 1;
            this.titleTel.Text = "Telefone";
            // 
            // titleObs
            // 
            this.titleObs.AutoSize = true;
            this.titleObs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleObs.Location = new System.Drawing.Point(253, 204);
            this.titleObs.Name = "titleObs";
            this.titleObs.Size = new System.Drawing.Size(95, 23);
            this.titleObs.TabIndex = 2;
            this.titleObs.Text = "Observação";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(72, 145);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(245, 22);
            this.txtbox_name.TabIndex = 3;
            this.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_telefone
            // 
            this.txtbox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telefone.Location = new System.Drawing.Point(402, 145);
            this.txtbox_telefone.Name = "txtbox_telefone";
            this.txtbox_telefone.Size = new System.Drawing.Size(183, 22);
            this.txtbox_telefone.TabIndex = 4;
            this.txtbox_telefone.Tag = "";
            this.txtbox_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_observacao
            // 
            this.txtbox_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_observacao.Location = new System.Drawing.Point(16, 245);
            this.txtbox_observacao.Multiline = true;
            this.txtbox_observacao.Name = "txtbox_observacao";
            this.txtbox_observacao.Size = new System.Drawing.Size(572, 129);
            this.txtbox_observacao.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlewMain
            // 
            this.titlewMain.AutoSize = true;
            this.titlewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlewMain.Location = new System.Drawing.Point(49, 47);
            this.titlewMain.Name = "titlewMain";
            this.titlewMain.Size = new System.Drawing.Size(268, 31);
            this.titlewMain.TabIndex = 8;
            this.titlewMain.Text = "Cadastro de Clientes";
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.titlewMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_observacao);
            this.Controls.Add(this.txtbox_telefone);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.titleObs);
            this.Controls.Add(this.titleTel);
            this.Controls.Add(this.titileName);
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.Text = "Registro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titileName;
        private System.Windows.Forms.Label titleTel;
        private System.Windows.Forms.Label titleObs;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_telefone;
        private System.Windows.Forms.TextBox txtbox_observacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titlewMain;
    }
}

