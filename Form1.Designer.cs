namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masks2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masks3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masks4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasksDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Networks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.octetBox1 = new System.Windows.Forms.TextBox();
            this.octetBox1R2 = new System.Windows.Forms.TextBox();
            this.octetBox1R3 = new System.Windows.Forms.TextBox();
            this.octetBox1R4 = new System.Windows.Forms.TextBox();
            this.octetBox2 = new System.Windows.Forms.TextBox();
            this.octetBox2R2 = new System.Windows.Forms.TextBox();
            this.octetBox2R3 = new System.Windows.Forms.TextBox();
            this.octetBox2R4 = new System.Windows.Forms.TextBox();
            this.octetBox3 = new System.Windows.Forms.TextBox();
            this.octetBox3R2 = new System.Windows.Forms.TextBox();
            this.octetBox3R3 = new System.Windows.Forms.TextBox();
            this.octetBox3R4 = new System.Windows.Forms.TextBox();
            this.octetBox4 = new System.Windows.Forms.TextBox();
            this.octetBox4R2 = new System.Windows.Forms.TextBox();
            this.octetBox4R3 = new System.Windows.Forms.TextBox();
            this.octetBox4R4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masks,
            this.Masks2,
            this.Masks3,
            this.Masks4,
            this.MasksDecimal,
            this.Networks,
            this.Addresses});
            this.dataGridView1.Location = new System.Drawing.Point(291, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Masks
            // 
            this.Masks.HeaderText = "Masks";
            this.Masks.Name = "Masks";
            this.Masks.ReadOnly = true;
            // 
            // Masks2
            // 
            this.Masks2.HeaderText = "Masks2";
            this.Masks2.Name = "Masks2";
            this.Masks2.ReadOnly = true;
            // 
            // Masks3
            // 
            this.Masks3.HeaderText = "Masks3";
            this.Masks3.Name = "Masks3";
            this.Masks3.ReadOnly = true;
            // 
            // Masks4
            // 
            this.Masks4.HeaderText = "Masks4";
            this.Masks4.Name = "Masks4";
            this.Masks4.ReadOnly = true;
            // 
            // MasksDecimal
            // 
            this.MasksDecimal.HeaderText = "MasksDecimal";
            this.MasksDecimal.Name = "MasksDecimal";
            this.MasksDecimal.ReadOnly = true;
            // 
            // Networks
            // 
            this.Networks.HeaderText = "Networks";
            this.Networks.Name = "Networks";
            this.Networks.ReadOnly = true;
            // 
            // Addresses
            // 
            this.Addresses.HeaderText = "Addresses";
            this.Addresses.Name = "Addresses";
            this.Addresses.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 334);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(502, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(502, 387);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(502, 414);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // octetBox1
            // 
            this.octetBox1.Location = new System.Drawing.Point(618, 335);
            this.octetBox1.Name = "octetBox1";
            this.octetBox1.Size = new System.Drawing.Size(100, 20);
            this.octetBox1.TabIndex = 7;
            this.octetBox1.TextChanged += new System.EventHandler(this.octetBox1_TextChanged);
            // 
            // octetBox1R2
            // 
            this.octetBox1R2.Location = new System.Drawing.Point(618, 361);
            this.octetBox1R2.Name = "octetBox1R2";
            this.octetBox1R2.Size = new System.Drawing.Size(100, 20);
            this.octetBox1R2.TabIndex = 8;
            this.octetBox1R2.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // octetBox1R3
            // 
            this.octetBox1R3.Location = new System.Drawing.Point(618, 387);
            this.octetBox1R3.Name = "octetBox1R3";
            this.octetBox1R3.Size = new System.Drawing.Size(100, 20);
            this.octetBox1R3.TabIndex = 9;
            // 
            // octetBox1R4
            // 
            this.octetBox1R4.Location = new System.Drawing.Point(618, 414);
            this.octetBox1R4.Name = "octetBox1R4";
            this.octetBox1R4.Size = new System.Drawing.Size(100, 20);
            this.octetBox1R4.TabIndex = 10;
            // 
            // octetBox2
            // 
            this.octetBox2.Location = new System.Drawing.Point(724, 335);
            this.octetBox2.Name = "octetBox2";
            this.octetBox2.Size = new System.Drawing.Size(100, 20);
            this.octetBox2.TabIndex = 11;
            // 
            // octetBox2R2
            // 
            this.octetBox2R2.Location = new System.Drawing.Point(724, 359);
            this.octetBox2R2.Name = "octetBox2R2";
            this.octetBox2R2.Size = new System.Drawing.Size(100, 20);
            this.octetBox2R2.TabIndex = 12;
            // 
            // octetBox2R3
            // 
            this.octetBox2R3.Location = new System.Drawing.Point(724, 387);
            this.octetBox2R3.Name = "octetBox2R3";
            this.octetBox2R3.Size = new System.Drawing.Size(100, 20);
            this.octetBox2R3.TabIndex = 13;
            // 
            // octetBox2R4
            // 
            this.octetBox2R4.Location = new System.Drawing.Point(724, 414);
            this.octetBox2R4.Name = "octetBox2R4";
            this.octetBox2R4.Size = new System.Drawing.Size(100, 20);
            this.octetBox2R4.TabIndex = 13;
            // 
            // octetBox3
            // 
            this.octetBox3.Location = new System.Drawing.Point(830, 335);
            this.octetBox3.Name = "octetBox3";
            this.octetBox3.Size = new System.Drawing.Size(100, 20);
            this.octetBox3.TabIndex = 13;
            this.octetBox3.TextChanged += new System.EventHandler(this.octectBox3_TextChanged);
            // 
            // octetBox3R2
            // 
            this.octetBox3R2.Location = new System.Drawing.Point(830, 361);
            this.octetBox3R2.Name = "octetBox3R2";
            this.octetBox3R2.Size = new System.Drawing.Size(100, 20);
            this.octetBox3R2.TabIndex = 13;
            // 
            // octetBox3R3
            // 
            this.octetBox3R3.Location = new System.Drawing.Point(830, 387);
            this.octetBox3R3.Name = "octetBox3R3";
            this.octetBox3R3.Size = new System.Drawing.Size(100, 20);
            this.octetBox3R3.TabIndex = 13;
            // 
            // octetBox3R4
            // 
            this.octetBox3R4.Location = new System.Drawing.Point(830, 413);
            this.octetBox3R4.Name = "octetBox3R4";
            this.octetBox3R4.Size = new System.Drawing.Size(100, 20);
            this.octetBox3R4.TabIndex = 13;
            // 
            // octetBox4
            // 
            this.octetBox4.Location = new System.Drawing.Point(936, 336);
            this.octetBox4.Name = "octetBox4";
            this.octetBox4.Size = new System.Drawing.Size(100, 20);
            this.octetBox4.TabIndex = 13;
            // 
            // octetBox4R2
            // 
            this.octetBox4R2.Location = new System.Drawing.Point(936, 362);
            this.octetBox4R2.Name = "octetBox4R2";
            this.octetBox4R2.Size = new System.Drawing.Size(100, 20);
            this.octetBox4R2.TabIndex = 13;
            // 
            // octetBox4R3
            // 
            this.octetBox4R3.Location = new System.Drawing.Point(936, 388);
            this.octetBox4R3.Name = "octetBox4R3";
            this.octetBox4R3.Size = new System.Drawing.Size(100, 20);
            this.octetBox4R3.TabIndex = 13;
            // 
            // octetBox4R4
            // 
            this.octetBox4R4.Location = new System.Drawing.Point(936, 414);
            this.octetBox4R4.Name = "octetBox4R4";
            this.octetBox4R4.Size = new System.Drawing.Size(100, 20);
            this.octetBox4R4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 810);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.octetBox4R4);
            this.Controls.Add(this.octetBox4R3);
            this.Controls.Add(this.octetBox4R2);
            this.Controls.Add(this.octetBox4);
            this.Controls.Add(this.octetBox3R4);
            this.Controls.Add(this.octetBox3R3);
            this.Controls.Add(this.octetBox3R2);
            this.Controls.Add(this.octetBox3);
            this.Controls.Add(this.octetBox2R4);
            this.Controls.Add(this.octetBox2R3);
            this.Controls.Add(this.octetBox2R2);
            this.Controls.Add(this.octetBox2);
            this.Controls.Add(this.octetBox1R4);
            this.Controls.Add(this.octetBox1R3);
            this.Controls.Add(this.octetBox1R2);
            this.Controls.Add(this.octetBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masks2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masks3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masks4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasksDecimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Networks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addresses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox octetBox1;
        private System.Windows.Forms.TextBox octetBox1R2;
        private System.Windows.Forms.TextBox octetBox1R3;
        private System.Windows.Forms.TextBox octetBox1R4;
        private System.Windows.Forms.TextBox octetBox2;
        private System.Windows.Forms.TextBox octetBox2R2;
        private System.Windows.Forms.TextBox octetBox2R3;
        private System.Windows.Forms.TextBox octetBox2R4;
        private System.Windows.Forms.TextBox octetBox3;
        private System.Windows.Forms.TextBox octetBox3R2;
        private System.Windows.Forms.TextBox octetBox3R3;
        private System.Windows.Forms.TextBox octetBox3R4;
        private System.Windows.Forms.TextBox octetBox4;
        private System.Windows.Forms.TextBox octetBox4R2;
        private System.Windows.Forms.TextBox octetBox4R3;
        private System.Windows.Forms.TextBox octetBox4R4;
        private System.Windows.Forms.Button button1;
    }
}

