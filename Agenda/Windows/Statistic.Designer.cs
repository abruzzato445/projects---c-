
namespace Agenda
{
    partial class statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lName = new System.Windows.Forms.Label();
            this.ctMoveClient = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctMoveClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(12, 34);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 16);
            this.lName.TabIndex = 0;
            this.lName.Text = "Nome";
            // 
            // ctMoveClient
            // 
            this.ctMoveClient.BackColor = System.Drawing.Color.Transparent;
            this.ctMoveClient.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ctMoveClient.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ctMoveClient.Legends.Add(legend1);
            this.ctMoveClient.Location = new System.Drawing.Point(2, 151);
            this.ctMoveClient.Name = "ctMoveClient";
            this.ctMoveClient.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ctMoveClient.Series.Add(series1);
            this.ctMoveClient.Size = new System.Drawing.Size(809, 300);
            this.ctMoveClient.TabIndex = 1;
            this.ctMoveClient.Text = "chart1";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aName.Location = new System.Drawing.Point(63, 34);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(116, 16);
            this.aName.TabIndex = 2;
            this.aName.Text = "Nome cliente aqui";
            // 
            // statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.aName);
            this.Controls.Add(this.ctMoveClient);
            this.Controls.Add(this.lName);
            this.Name = "statistic";
            this.Text = "Movimentação do Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ctMoveClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctMoveClient;
        private System.Windows.Forms.Label aName;
    }
}