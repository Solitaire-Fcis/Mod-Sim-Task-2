namespace NewspaperSellerSimulation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeOfNewsday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiniRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodRanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairRanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoorRanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Newspapers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scrap Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(311, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(426, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(544, 9);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfNewsday,
            this.Probability,
            this.CumulativeProbability,
            this.MiniRange,
            this.MaxRange});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 122);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Good,
            this.Fair,
            this.Poor,
            this.GoodRanges,
            this.FairRanges,
            this.PoorRanges});
            this.dataGridView2.Location = new System.Drawing.Point(12, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(464, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeOfNewsday
            // 
            this.TypeOfNewsday.HeaderText = "Type of Newsday";
            this.TypeOfNewsday.Name = "TypeOfNewsday";
            this.TypeOfNewsday.ReadOnly = true;
            this.TypeOfNewsday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeOfNewsday.Width = 65;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            this.Probability.ReadOnly = true;
            this.Probability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Probability.Width = 60;
            // 
            // CumulativeProbability
            // 
            this.CumulativeProbability.HeaderText = "Cumulative Probability";
            this.CumulativeProbability.Name = "CumulativeProbability";
            this.CumulativeProbability.ReadOnly = true;
            this.CumulativeProbability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CumulativeProbability.Width = 65;
            // 
            // MiniRange
            // 
            this.MiniRange.HeaderText = "Mini Range";
            this.MiniRange.Name = "MiniRange";
            this.MiniRange.ReadOnly = true;
            this.MiniRange.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MiniRange.Width = 50;
            // 
            // MaxRange
            // 
            this.MaxRange.HeaderText = "Max Range";
            this.MaxRange.Name = "MaxRange";
            this.MaxRange.ReadOnly = true;
            this.MaxRange.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaxRange.Width = 50;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            this.Demand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Demand.Width = 60;
            // 
            // Good
            // 
            this.Good.HeaderText = "Good";
            this.Good.Name = "Good";
            this.Good.ReadOnly = true;
            this.Good.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Good.Width = 60;
            // 
            // Fair
            // 
            this.Fair.HeaderText = "Fair";
            this.Fair.Name = "Fair";
            this.Fair.ReadOnly = true;
            this.Fair.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fair.Width = 60;
            // 
            // Poor
            // 
            this.Poor.HeaderText = "Poor";
            this.Poor.Name = "Poor";
            this.Poor.ReadOnly = true;
            this.Poor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Poor.Width = 60;
            // 
            // GoodRanges
            // 
            this.GoodRanges.HeaderText = "Good Ranges";
            this.GoodRanges.Name = "GoodRanges";
            this.GoodRanges.ReadOnly = true;
            this.GoodRanges.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodRanges.Width = 60;
            // 
            // FairRanges
            // 
            this.FairRanges.HeaderText = "Fair Ranges";
            this.FairRanges.Name = "FairRanges";
            this.FairRanges.ReadOnly = true;
            this.FairRanges.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FairRanges.Width = 60;
            // 
            // PoorRanges
            // 
            this.PoorRanges.HeaderText = "Poor Ranges";
            this.PoorRanges.Name = "PoorRanges";
            this.PoorRanges.ReadOnly = true;
            this.PoorRanges.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PoorRanges.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfNewsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiniRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodRanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn FairRanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoorRanges;
    }
}