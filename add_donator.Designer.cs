namespace IS_PROJECT
{
    partial class add_donator
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
            this.first_name = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.E_mail = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new IS_PROJECT.projectDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter = new IS_PROJECT.projectDataSetTableAdapters.departmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(39, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD Donation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(36, 22);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(62, 13);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "first name :";
            // 
            // middle_name
            // 
            this.middle_name.AutoSize = true;
            this.middle_name.Location = new System.Drawing.Point(36, 54);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(73, 13);
            this.middle_name.TabIndex = 2;
            this.middle_name.Text = "middle name :";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(36, 85);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(60, 13);
            this.last_name.TabIndex = 3;
            this.last_name.Text = "last name :";
            // 
            // E_mail
            // 
            this.E_mail.AutoSize = true;
            this.E_mail.Location = new System.Drawing.Point(36, 117);
            this.E_mail.Name = "E_mail";
            this.E_mail.Size = new System.Drawing.Size(42, 13);
            this.E_mail.TabIndex = 4;
            this.E_mail.Text = "E-mail :";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(36, 150);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(44, 13);
            this.Phone.TabIndex = 5;
            this.Phone.Text = "Phone :";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(36, 181);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(53, 13);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 178);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "dep_type", true));
            this.comboBox1.DataSource = this.departmentBindingSource;
            this.comboBox1.DisplayMember = "dep_type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "dep_type";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 16;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // add_donator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 358);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.E_mail);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.button1);
            this.Name = "add_donator";
            this.Text = "add_donator";
            this.Load += new System.EventHandler(this.add_donator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label middle_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label E_mail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private projectDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
    }
}