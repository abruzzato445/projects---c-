﻿namespace Agenda
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAgenda = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.ListClient = new System.Windows.Forms.ListBox();
            this.txtbox_observacao = new System.Windows.Forms.TextBox();
            this.txtbox_telefone = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.titleObs = new System.Windows.Forms.Label();
            this.titleTel = new System.Windows.Forms.Label();
            this.titileName = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnDelet = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.lblab2t1 = new System.Windows.Forms.Label();
            this.tBoxFilterClient = new System.Windows.Forms.TextBox();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Agenda.dbDataSet();
            this.clientesTableAdapter = new Agenda.dbDataSetTableAdapters.clientesTableAdapter();
            this.tabAgenda.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 339);
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
            this.tabAgenda.Location = new System.Drawing.Point(2, 3);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Drawing.Point(10, 10);
            this.tabAgenda.SelectedIndex = 0;
            this.tabAgenda.Size = new System.Drawing.Size(700, 426);
            this.tabAgenda.TabIndex = 10;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.Color.Transparent;
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Controls.Add(this.button2);
            this.tabCadastro.Controls.Add(this.bttn_Add);
            this.tabCadastro.Controls.Add(this.ListClient);
            this.tabCadastro.Controls.Add(this.txtbox_observacao);
            this.tabCadastro.Controls.Add(this.button1);
            this.tabCadastro.Controls.Add(this.txtbox_telefone);
            this.tabCadastro.Controls.Add(this.txtbox_name);
            this.tabCadastro.Controls.Add(this.titleObs);
            this.tabCadastro.Controls.Add(this.titleTel);
            this.tabCadastro.Controls.Add(this.titileName);
            this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastro.Location = new System.Drawing.Point(4, 36);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(692, 386);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro de Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clientes Adicionados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(585, 148);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(89, 29);
            this.bttn_Add.TabIndex = 17;
            this.bttn_Add.Text = "Adicionar";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // ListClient
            // 
            this.ListClient.FormattingEnabled = true;
            this.ListClient.ItemHeight = 18;
            this.ListClient.Location = new System.Drawing.Point(6, 238);
            this.ListClient.Name = "ListClient";
            this.ListClient.Size = new System.Drawing.Size(559, 130);
            this.ListClient.TabIndex = 16;
            // 
            // txtbox_observacao
            // 
            this.txtbox_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_observacao.Location = new System.Drawing.Point(6, 126);
            this.txtbox_observacao.Multiline = true;
            this.txtbox_observacao.Name = "txtbox_observacao";
            this.txtbox_observacao.Size = new System.Drawing.Size(559, 67);
            this.txtbox_observacao.TabIndex = 15;
            // 
            // txtbox_telefone
            // 
            this.txtbox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telefone.Location = new System.Drawing.Point(436, 53);
            this.txtbox_telefone.Name = "txtbox_telefone";
            this.txtbox_telefone.Size = new System.Drawing.Size(205, 22);
            this.txtbox_telefone.TabIndex = 14;
            this.txtbox_telefone.Tag = "";
            this.txtbox_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(17, 54);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(354, 22);
            this.txtbox_name.TabIndex = 13;
            this.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleObs
            // 
            this.titleObs.AutoSize = true;
            this.titleObs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleObs.Location = new System.Drawing.Point(229, 101);
            this.titleObs.Name = "titleObs";
            this.titleObs.Size = new System.Drawing.Size(113, 22);
            this.titleObs.TabIndex = 12;
            this.titleObs.Text = "Observação";
            // 
            // titleTel
            // 
            this.titleTel.AutoSize = true;
            this.titleTel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTel.Location = new System.Drawing.Point(502, 28);
            this.titleTel.Name = "titleTel";
            this.titleTel.Size = new System.Drawing.Size(84, 22);
            this.titleTel.TabIndex = 11;
            this.titleTel.Text = "Telefone";
            // 
            // titileName
            // 
            this.titileName.AutoSize = true;
            this.titileName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titileName.Location = new System.Drawing.Point(168, 28);
            this.titileName.Name = "titileName";
            this.titileName.Size = new System.Drawing.Size(61, 22);
            this.titileName.TabIndex = 10;
            this.titileName.Text = "Nome";
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.Transparent;
            this.tabList.Controls.Add(this.bttnEdit);
            this.tabList.Controls.Add(this.bttnDelet);
            this.tabList.Controls.Add(this.bttnRefresh);
            this.tabList.Controls.Add(this.lblab2t1);
            this.tabList.Controls.Add(this.tBoxFilterClient);
            this.tabList.Controls.Add(this.dgv_Clientes);
            this.tabList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabList.Location = new System.Drawing.Point(4, 36);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(692, 386);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Lista de Clientes";
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(578, 355);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(87, 28);
            this.bttnEdit.TabIndex = 5;
            this.bttnEdit.Text = "Vizualizar";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Visible = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnDelet
            // 
            this.bttnDelet.Location = new System.Drawing.Point(475, 355);
            this.bttnDelet.Name = "bttnDelet";
            this.bttnDelet.Size = new System.Drawing.Size(87, 28);
            this.bttnDelet.TabIndex = 4;
            this.bttnDelet.Text = "Excluir";
            this.bttnDelet.UseVisualStyleBackColor = true;
            this.bttnDelet.Visible = false;
            this.bttnDelet.Click += new System.EventHandler(this.bttnDelet_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Location = new System.Drawing.Point(498, 20);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(87, 28);
            this.bttnRefresh.TabIndex = 3;
            this.bttnRefresh.Text = "Atualizar";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // lblab2t1
            // 
            this.lblab2t1.AutoSize = true;
            this.lblab2t1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblab2t1.Location = new System.Drawing.Point(131, 22);
            this.lblab2t1.Name = "lblab2t1";
            this.lblab2t1.Size = new System.Drawing.Size(69, 22);
            this.lblab2t1.TabIndex = 2;
            this.lblab2t1.Text = "Cliente";
            // 
            // tBoxFilterClient
            // 
            this.tBoxFilterClient.Location = new System.Drawing.Point(206, 22);
            this.tBoxFilterClient.Name = "tBoxFilterClient";
            this.tBoxFilterClient.Size = new System.Drawing.Size(277, 24);
            this.tBoxFilterClient.TabIndex = 1;
            this.tBoxFilterClient.TextChanged += new System.EventHandler(this.tBoxFilterClient_TextChanged);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AutoGenerateColumns = false;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgv_Clientes.DataSource = this.clientesBindingSource;
            this.dgv_Clientes.Location = new System.Drawing.Point(22, 52);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.Size = new System.Drawing.Size(643, 299);
            this.dgv_Clientes.TabIndex = 0;
            this.dgv_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "OBSERVAÇÃO";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 436);
            this.Controls.Add(this.tabAgenda);
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.wMain_Load);
            this.tabAgenda.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
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
        private System.Windows.Forms.ListBox ListClient;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dbDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblab2t1;
        private System.Windows.Forms.TextBox tBoxFilterClient;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnDelet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
    }
}

