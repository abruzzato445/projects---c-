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
            this.button1 = new System.Windows.Forms.Button();
            this.tabAgenda = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.tabList = new System.Windows.Forms.TabPage();
            this.txtbox_observacao = new System.Windows.Forms.TextBox();
            this.txtbox_telefone = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.titleObs = new System.Windows.Forms.Label();
            this.titleTel = new System.Windows.Forms.Label();
            this.titileName = new System.Windows.Forms.Label();
            this.tabAgenda.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabAgenda
            // 
            this.tabAgenda.Controls.Add(this.tabCadastro);
            this.tabAgenda.Controls.Add(this.tabList);
            this.tabAgenda.Location = new System.Drawing.Point(1, 4);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Drawing.Point(10, 10);
            this.tabAgenda.SelectedIndex = 0;
            this.tabAgenda.Size = new System.Drawing.Size(592, 408);
            this.tabAgenda.TabIndex = 10;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.Color.Transparent;
            this.tabCadastro.Controls.Add(this.txtbox_observacao);
            this.tabCadastro.Controls.Add(this.txtbox_telefone);
            this.tabCadastro.Controls.Add(this.txtbox_name);
            this.tabCadastro.Controls.Add(this.titleObs);
            this.tabCadastro.Controls.Add(this.titleTel);
            this.tabCadastro.Controls.Add(this.titileName);
            this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastro.Location = new System.Drawing.Point(4, 36);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(584, 368);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro de Clientes";
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.Transparent;
            this.tabList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabList.Location = new System.Drawing.Point(4, 36);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(573, 360);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Lista";
            // 
            // txtbox_observacao
            // 
            this.txtbox_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_observacao.Location = new System.Drawing.Point(7, 130);
            this.txtbox_observacao.Multiline = true;
            this.txtbox_observacao.Name = "txtbox_observacao";
            this.txtbox_observacao.Size = new System.Drawing.Size(559, 67);
            this.txtbox_observacao.TabIndex = 15;
            // 
            // txtbox_telefone
            // 
            this.txtbox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telefone.Location = new System.Drawing.Point(361, 54);
            this.txtbox_telefone.Name = "txtbox_telefone";
            this.txtbox_telefone.Size = new System.Drawing.Size(205, 22);
            this.txtbox_telefone.TabIndex = 14;
            this.txtbox_telefone.Tag = "";
            this.txtbox_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(7, 54);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(245, 22);
            this.txtbox_name.TabIndex = 13;
            this.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleObs
            // 
            this.titleObs.AutoSize = true;
            this.titleObs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleObs.Location = new System.Drawing.Point(239, 95);
            this.titleObs.Name = "titleObs";
            this.titleObs.Size = new System.Drawing.Size(95, 23);
            this.titleObs.TabIndex = 12;
            this.titleObs.Text = "Observação";
            // 
            // titleTel
            // 
            this.titleTel.AutoSize = true;
            this.titleTel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTel.Location = new System.Drawing.Point(431, 28);
            this.titleTel.Name = "titleTel";
            this.titleTel.Size = new System.Drawing.Size(70, 23);
            this.titleTel.TabIndex = 11;
            this.titleTel.Text = "Telefone";
            // 
            // titileName
            // 
            this.titileName.AutoSize = true;
            this.titileName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titileName.Location = new System.Drawing.Point(108, 28);
            this.titileName.Name = "titileName";
            this.titileName.Size = new System.Drawing.Size(52, 23);
            this.titileName.TabIndex = 10;
            this.titileName.Text = "Nome";
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.tabAgenda);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.Text = "Agenda";
            this.tabAgenda.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabAgenda;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TextBox txtbox_observacao;
        private System.Windows.Forms.TextBox txtbox_telefone;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label titleObs;
        private System.Windows.Forms.Label titleTel;
        private System.Windows.Forms.Label titileName;
    }
}

