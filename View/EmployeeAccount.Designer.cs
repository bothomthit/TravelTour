namespace TravelTour.View
{
    partial class EmployeeAccount
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
            label5 = new Label();
            textBoxid = new TextBox();
            textBoxname = new TextBox();
            textBoxpw = new TextBox();
            radioButtonmanager = new RadioButton();
            radioButtonemployee = new RadioButton();
            dataGridView1 = new DataGridView();
            btsave = new Button();
            btdelete = new Button();
            btclose = new Button();
            radioButtonguide = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 0;
            label1.Text = "EMPOYEE ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 117);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "EmployeeName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 157);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 194);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Role";
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(253, 69);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(310, 27);
            textBoxid.TabIndex = 5;
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(253, 110);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(310, 27);
            textBoxname.TabIndex = 6;
            // 
            // textBoxpw
            // 
            textBoxpw.Location = new Point(253, 150);
            textBoxpw.Name = "textBoxpw";
            textBoxpw.Size = new Size(310, 27);
            textBoxpw.TabIndex = 7;
            // 
            // radioButtonmanager
            // 
            radioButtonmanager.AutoSize = true;
            radioButtonmanager.Location = new Point(359, 194);
            radioButtonmanager.Name = "radioButtonmanager";
            radioButtonmanager.Size = new Size(89, 24);
            radioButtonmanager.TabIndex = 8;
            radioButtonmanager.TabStop = true;
            radioButtonmanager.Text = "Manager";
            radioButtonmanager.UseVisualStyleBackColor = true;
            // 
            // radioButtonemployee
            // 
            radioButtonemployee.AutoSize = true;
            radioButtonemployee.Location = new Point(467, 194);
            radioButtonemployee.Name = "radioButtonemployee";
            radioButtonemployee.Size = new Size(96, 24);
            radioButtonemployee.TabIndex = 9;
            radioButtonemployee.TabStop = true;
            radioButtonemployee.Text = "Employee";
            radioButtonemployee.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 145);
            dataGridView1.TabIndex = 10;
            // 
            // btsave
            // 
            btsave.Location = new Point(401, 407);
            btsave.Name = "btsave";
            btsave.Size = new Size(104, 31);
            btsave.TabIndex = 11;
            btsave.Text = "Save";
            btsave.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(536, 407);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(104, 31);
            btdelete.TabIndex = 12;
            btdelete.Text = "Delete";
            btdelete.UseVisualStyleBackColor = true;
            // 
            // btclose
            // 
            btclose.Location = new Point(671, 407);
            btclose.Name = "btclose";
            btclose.Size = new Size(104, 31);
            btclose.TabIndex = 13;
            btclose.Text = "Close";
            btclose.UseVisualStyleBackColor = true;
            // 
            // radioButtonguide
            // 
            radioButtonguide.AutoSize = true;
            radioButtonguide.Location = new Point(274, 194);
            radioButtonguide.Name = "radioButtonguide";
            radioButtonguide.Size = new Size(69, 24);
            radioButtonguide.TabIndex = 14;
            radioButtonguide.TabStop = true;
            radioButtonguide.Text = "Guide";
            radioButtonguide.UseVisualStyleBackColor = true;
            // 
            // EmployeeAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonguide);
            Controls.Add(btclose);
            Controls.Add(btdelete);
            Controls.Add(btsave);
            Controls.Add(dataGridView1);
            Controls.Add(radioButtonemployee);
            Controls.Add(radioButtonmanager);
            Controls.Add(textBoxpw);
            Controls.Add(textBoxname);
            Controls.Add(textBoxid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeAccount";
            Text = "EmployeeAccount";
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
        private TextBox textBoxid;
        private TextBox textBoxname;
        private TextBox textBoxpw;
        private RadioButton radioButtonmanager;
        private RadioButton radioButtonemployee;
        private DataGridView dataGridView1;
        private Button btsave;
        private Button btdelete;
        private Button btclose;
        private RadioButton radioButtonguide;
    }
}