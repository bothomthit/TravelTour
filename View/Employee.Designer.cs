namespace TravelTour.View
{
    partial class Employee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btclose = new Button();
            btdelete = new Button();
            btsave = new Button();
            pictureBoxemployee = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxemployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(313, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 95);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 139);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "EmployeeName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 185);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "DateWork";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 114);
            dataGridView1.TabIndex = 9;
            // 
            // btclose
            // 
            btclose.Location = new Point(665, 409);
            btclose.Name = "btclose";
            btclose.Size = new Size(94, 29);
            btclose.TabIndex = 10;
            btclose.Text = "Close";
            btclose.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(554, 409);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(94, 29);
            btdelete.TabIndex = 11;
            btdelete.Text = "Delete";
            btdelete.UseVisualStyleBackColor = true;
            // 
            // btsave
            // 
            btsave.Location = new Point(440, 409);
            btsave.Name = "btsave";
            btsave.Size = new Size(94, 29);
            btsave.TabIndex = 12;
            btsave.Text = "Save";
            btsave.UseVisualStyleBackColor = true;
            // 
            // pictureBoxemployee
            // 
            pictureBoxemployee.Location = new Point(617, 21);
            pictureBoxemployee.Name = "pictureBoxemployee";
            pictureBoxemployee.Size = new Size(142, 94);
            pictureBoxemployee.TabIndex = 13;
            pictureBoxemployee.TabStop = false;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxemployee);
            Controls.Add(btsave);
            Controls.Add(btdelete);
            Controls.Add(btclose);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxemployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btclose;
        private Button btdelete;
        private Button btsave;
        private PictureBox pictureBoxemployee;
    }
}