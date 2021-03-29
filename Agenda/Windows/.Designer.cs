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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAgenda = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRegister = new System.Windows.Forms.DateTimePicker();
            this.titleIdade = new System.Windows.Forms.Label();
            this.cbxAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.ListClient = new System.Windows.Forms.ListBox();
            this.txtbox_observacao = new System.Windows.Forms.TextBox();
            this.txtbox_telefone = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.titleObs = new System.Windows.Forms.Label();
            this.titleTel = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.bttnCheck = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Agenda.dbDataSet();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnDelet = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.lblab2t1 = new System.Windows.Forms.Label();
            this.tBoxFilterClient = new System.Windows.Forms.TextBox();
            this.clientesTableAdapter = new Agenda.dbDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Agenda.dbDataSetTableAdapters.TableAdapterManager();
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
            this.button1.Location = new System.Drawing.Point(809, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabAgenda
            // 
            this.tabAgenda.Controls.Add(this.tabCadastro);
            this.tabAgenda.Controls.Add(this.tabList);
            this.tabAgenda.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAgenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabAgenda.Location = new System.Drawing.Point(-3, 0);
            this.tabAgenda.Multiline = true;
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Drawing.Point(10, 10);
            this.tabAgenda.SelectedIndex = 0;
            this.tabAgenda.Size = new System.Drawing.Size(987, 580);
            this.tabAgenda.TabIndex = 10;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.dtpRegister);
            this.tabCadastro.Controls.Add(this.titleIdade);
            this.tabCadastro.Controls.Add(this.cbxAge);
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
            this.tabCadastro.Controls.Add(this.titleName);
            this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastro.Location = new System.Drawing.Point(4, 41);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(979, 535);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data Registro";
            // 
            // dtpRegister
            // 
            this.dtpRegister.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegister.Location = new System.Drawing.Point(407, 75);
            this.dtpRegister.Name = "dtpRegister";
            this.dtpRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpRegister.Size = new System.Drawing.Size(124, 24);
            this.dtpRegister.TabIndex = 22;
            // 
            // titleIdade
            // 
            this.titleIdade.AutoSize = true;
            this.titleIdade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleIdade.Location = new System.Drawing.Point(19, 76);
            this.titleIdade.Name = "titleIdade";
            this.titleIdade.Size = new System.Drawing.Size(71, 22);
            this.titleIdade.TabIndex = 21;
            this.titleIdade.Text = "* Idade";
            // 
            // cbxAge
            // 
            this.cbxAge.FormattingEnabled = true;
            this.cbxAge.Items.AddRange(new object[] {
            "Adulto",
            "Crianca"});
            this.cbxAge.Location = new System.Drawing.Point(106, 74);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(121, 26);
            this.cbxAge.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clientes Adicionados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 61);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(809, 157);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(160, 61);
            this.bttn_Add.TabIndex = 17;
            this.bttn_Add.Text = "Adicionar";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // ListClient
            // 
            this.ListClient.FormattingEnabled = true;
            this.ListClient.ItemHeight = 18;
            this.ListClient.Location = new System.Drawing.Point(10, 326);
            this.ListClient.Name = "ListClient";
            this.ListClient.Size = new System.Drawing.Size(780, 166);
            this.ListClient.TabIndex = 16;
            // 
            // txtbox_observacao
            // 
            this.txtbox_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_observacao.Location = new System.Drawing.Point(154, 133);
            this.txtbox_observacao.Multiline = true;
            this.txtbox_observacao.Name = "txtbox_observacao";
            this.txtbox_observacao.Size = new System.Drawing.Size(630, 99);
            this.txtbox_observacao.TabIndex = 15;
            // 
            // txtbox_telefone
            // 
            this.txtbox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_telefone.Location = new System.Drawing.Point(674, 29);
            this.txtbox_telefone.Name = "txtbox_telefone";
            this.txtbox_telefone.Size = new System.Drawing.Size(276, 22);
            this.txtbox_telefone.TabIndex = 14;
            this.txtbox_telefone.Tag = "";
            this.txtbox_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(106, 31);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(425, 22);
            this.txtbox_name.TabIndex = 13;
            this.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleObs
            // 
            this.titleObs.AutoSize = true;
            this.titleObs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleObs.Location = new System.Drawing.Point(19, 175);
            this.titleObs.Name = "titleObs";
            this.titleObs.Size = new System.Drawing.Size(113, 22);
            this.titleObs.TabIndex = 12;
            this.titleObs.Text = "Observação";
            // 
            // titleTel
            // 
            this.titleTel.AutoSize = true;
            this.titleTel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTel.Location = new System.Drawing.Point(572, 29);
            this.titleTel.Name = "titleTel";
            this.titleTel.Size = new System.Drawing.Size(84, 22);
            this.titleTel.TabIndex = 11;
            this.titleTel.Text = "Telefone";
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(19, 29);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(73, 22);
            this.titleName.TabIndex = 10;
            this.titleName.Text = "* Nome";
            // 
            // tabList
            // 
            this.tabList.AutoScroll = true;
            this.tabList.BackColor = System.Drawing.Color.Gainsboro;
            this.tabList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabList.Controls.Add(this.bttnCheck);
            this.tabList.Controls.Add(this.dgv_Clientes);
            this.tabList.Controls.Add(this.cbxFilter);
            this.tabList.Controls.Add(this.bttnEdit);
            this.tabList.Controls.Add(this.bttnDelet);
            this.tabList.Controls.Add(this.bttnRefresh);
            this.tabList.Controls.Add(this.lblab2t1);
            this.tabList.Controls.Add(this.tBoxFilterClient);
            this.tabList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabList.Location = new System.Drawing.Point(4, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(979, 535);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Lista de Clientes";
            // 
            // bttnCheck
            // 
            this.bttnCheck.Location = new System.Drawing.Point(874, 491);
            this.bttnCheck.Name = "bttnCheck";
            this.bttnCheck.Size = new System.Drawing.Size(87, 28);
            this.bttnCheck.TabIndex = 7;
            this.bttnCheck.Text = "Check";
            this.bttnCheck.UseVisualStyleBackColor = true;
            this.bttnCheck.Visible = false;
            this.bttnCheck.Click += new System.EventHandler(this.bttnCheck_Click);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AutoGenerateColumns = false;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgv_Clientes.DataSource = this.clientesBindingSource;
            this.dgv_Clientes.Location = new System.Drawing.Point(12, 57);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.Size = new System.Drawing.Size(951, 419);
            this.dgv_Clientes.TabIndex = 6;
            this.dgv_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contato";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataregistro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "observacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
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
            // cbxFilter
            // 
            this.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFilter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "Cliente",
            "Telefone"});
            this.cbxFilter.Location = new System.Drawing.Point(197, 16);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(121, 26);
            this.cbxFilter.TabIndex = 6;
            this.cbxFilter.Tag = "";
            this.cbxFilter.Text = "Selecione...";
            this.cbxFilter.SelectedValueChanged += new System.EventHandler(this.cbxFilter_SelectedValueChanged);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(770, 491);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(87, 28);
            this.bttnEdit.TabIndex = 5;
            this.bttnEdit.Text = "Editar";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Visible = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnDelet
            // 
            this.bttnDelet.Location = new System.Drawing.Point(667, 491);
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
            this.bttnRefresh.Location = new System.Drawing.Point(851, 14);
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
            this.lblab2t1.Location = new System.Drawing.Point(96, 17);
            this.lblab2t1.Name = "lblab2t1";
            this.lblab2t1.Size = new System.Drawing.Size(95, 22);
            this.lblab2t1.TabIndex = 2;
            this.lblab2t1.Text = "Filtrar por:";
            // 
            // tBoxFilterClient
            // 
            this.tBoxFilterClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tBoxFilterClient.Location = new System.Drawing.Point(422, 16);
            this.tBoxFilterClient.Name = "tBoxFilterClient";
            this.tBoxFilterClient.Size = new System.Drawing.Size(414, 24);
            this.tBoxFilterClient.TabIndex = 1;
            this.tBoxFilterClient.TextChanged += new System.EventHandler(this.tBoxFilterClient_TextChanged);
            this.tBoxFilterClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxFilterClient_KeyPress);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agenda.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tabAgenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.ListBox ListClient;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button button2;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblab2t1;
        private System.Windows.Forms.TextBox tBoxFilterClient;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnDelet;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label titleIdade;
        private System.Windows.Forms.ComboBox cbxAge;
        private System.Windows.Forms.DateTimePicker dtpRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bttnCheck;
    }
}

