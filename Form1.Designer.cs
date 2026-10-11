namespace VarakGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            varnev = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nev = new DataGridViewTextBoxColumn();
            Telepules = new DataGridViewTextBoxColumn();
            Megye = new DataGridViewTextBoxColumn();
            Latogato2023 = new DataGridViewTextBoxColumn();
            Latogato2024 = new DataGridViewTextBoxColumn();
            Jegyar = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2024 = new TextBox();
            textBox4 = new TextBox();
            textBox2023 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 0;
            label1.Text = "Szűrés név vagy település alapján:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(297, 321);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "2023";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(447, 321);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "jegyár";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(376, 321);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 3;
            label4.Text = "2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(36, 370);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 4;
            label5.Text = "kijelölt vár:";
            // 
            // button1
            // 
            button1.Location = new Point(554, 349);
            button1.Name = "button1";
            button1.Size = new Size(197, 51);
            button1.TabIndex = 5;
            button1.Text = "módosítási javaslat";
            button1.UseVisualStyleBackColor = true;
            // 
            // varnev
            // 
            varnev.AutoSize = true;
            varnev.Location = new Point(208, 372);
            varnev.Name = "varnev";
            varnev.Size = new Size(35, 15);
            varnev.TabIndex = 6;
            varnev.Text = "####";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nev, Telepules, Megye, Latogato2023, Latogato2024, Jegyar });
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 211);
            dataGridView1.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.Name = "Id";
            // 
            // Nev
            // 
            Nev.HeaderText = "vár neve";
            Nev.Name = "Nev";
            // 
            // Telepules
            // 
            Telepules.HeaderText = "település";
            Telepules.Name = "Telepules";
            // 
            // Megye
            // 
            Megye.HeaderText = "megye";
            Megye.Name = "Megye";
            // 
            // Latogato2023
            // 
            Latogato2023.HeaderText = "látogatók 2023";
            Latogato2023.Name = "Latogato2023";
            // 
            // Latogato2024
            // 
            Latogato2024.HeaderText = "látogatók 2024";
            Latogato2024.Name = "Latogato2024";
            // 
            // Jegyar
            // 
            Jegyar.HeaderText = "jegyár (Ft)";
            Jegyar.Name = "Jegyar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2024
            // 
            textBox2024.Location = new Point(376, 364);
            textBox2024.Name = "textBox2024";
            textBox2024.Size = new Size(70, 23);
            textBox2024.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(463, 364);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(70, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox2023
            // 
            textBox2023.Location = new Point(286, 364);
            textBox2023.Name = "textBox2023";
            textBox2023.Size = new Size(70, 23);
            textBox2023.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2023);
            Controls.Add(textBox4);
            Controls.Add(textBox2024);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(varnev);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Magyar várak látogatottsága";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label varnev;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Telepules;
        private DataGridViewTextBoxColumn Megye;
        private DataGridViewTextBoxColumn Latogato2023;
        private DataGridViewTextBoxColumn Latogato2024;
        private DataGridViewTextBoxColumn Jegyar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox2024;
        private TextBox textBox4;
        private TextBox textBox2023;
    }
}
