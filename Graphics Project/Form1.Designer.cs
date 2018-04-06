namespace Graphics_Project
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnlGraphics = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.Xe = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Ye = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Xs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Ys = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ye)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ys)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Transparent;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDraw.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDraw.Location = new System.Drawing.Point(526, 3);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(87, 31);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnlGraphics
            // 
            this.pnlGraphics.BackColor = System.Drawing.Color.Snow;
            this.pnlGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGraphics.Location = new System.Drawing.Point(0, 243);
            this.pnlGraphics.Name = "pnlGraphics";
            this.pnlGraphics.Size = new System.Drawing.Size(741, 353);
            this.pnlGraphics.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(526, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 31);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Xe
            // 
            this.Xe.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Xe.Location = new System.Drawing.Point(44, 23);
            this.Xe.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Xe.Name = "Xe";
            this.Xe.Size = new System.Drawing.Size(65, 27);
            this.Xe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xe";
            // 
            // Ye
            // 
            this.Ye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Ye.Location = new System.Drawing.Point(158, 25);
            this.Ye.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Ye.Name = "Ye";
            this.Ye.Size = new System.Drawing.Size(65, 27);
            this.Ye.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(121, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ye";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Xe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ye);
            this.groupBox1.Location = new System.Drawing.Point(276, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End Point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Xs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Ys);
            this.groupBox2.Location = new System.Drawing.Point(27, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(121, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ys";
            // 
            // Xs
            // 
            this.Xs.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Xs.Location = new System.Drawing.Point(44, 23);
            this.Xs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Xs.Name = "Xs";
            this.Xs.Size = new System.Drawing.Size(65, 27);
            this.Xs.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xs";
            // 
            // Ys
            // 
            this.Ys.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Ys.Location = new System.Drawing.Point(158, 25);
            this.Ys.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Ys.Name = "Ys";
            this.Ys.Size = new System.Drawing.Size(65, 27);
            this.Ys.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 84);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.K,
            this.xInc,
            this.yInc,
            this.RoundX,
            this.RoundY});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(741, 159);
            this.dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(619, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "dx =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(619, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "dy = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(668, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(668, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "0";
            // 
            // X
            // 
            this.X.Frozen = true;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.Frozen = true;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // K
            // 
            this.K.Frozen = true;
            this.K.HeaderText = "K";
            this.K.Name = "K";
            this.K.ReadOnly = true;
            // 
            // xInc
            // 
            this.xInc.Frozen = true;
            this.xInc.HeaderText = "xInc";
            this.xInc.Name = "xInc";
            this.xInc.ReadOnly = true;
            // 
            // yInc
            // 
            this.yInc.Frozen = true;
            this.yInc.HeaderText = "yInc";
            this.yInc.Name = "yInc";
            this.yInc.ReadOnly = true;
            // 
            // RoundX
            // 
            this.RoundX.Frozen = true;
            this.RoundX.HeaderText = "Round(X)";
            this.RoundX.Name = "RoundX";
            this.RoundX.ReadOnly = true;
            // 
            // RoundY
            // 
            this.RoundY.Frozen = true;
            this.RoundY.HeaderText = "Round(X)";
            this.RoundY.Name = "RoundY";
            this.RoundY.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGraphics);
            this.Name = "Form1";
            this.Text = "Digital Deffrence Anlyser (DDA)";
            ((System.ComponentModel.ISupportInitialize)(this.Xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ye)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ys)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnlGraphics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown Xe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Ye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Xs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Ys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn xInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn yInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundY;
    }
}

