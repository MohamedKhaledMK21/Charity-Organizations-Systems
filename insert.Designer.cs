﻿namespace IS_PROJECT
{
    partial class insert
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
            this.button1 = new System.Windows.Forms.Button();
            this.department_Name = new System.Windows.Forms.TextBox();
            this.drpartmet_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(85, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // department_Name
            // 
            this.department_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department_Name.Location = new System.Drawing.Point(130, 68);
            this.department_Name.Name = "department_Name";
            this.department_Name.Size = new System.Drawing.Size(100, 20);
            this.department_Name.TabIndex = 1;
            this.department_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drpartmet_ID
            // 
            this.drpartmet_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drpartmet_ID.Location = new System.Drawing.Point(130, 33);
            this.drpartmet_ID.Name = "drpartmet_ID";
            this.drpartmet_ID.Size = new System.Drawing.Size(100, 20);
            this.drpartmet_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpartmet_ID);
            this.Controls.Add(this.department_Name);
            this.Controls.Add(this.button1);
            this.Name = "insert";
            this.Text = "insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox department_Name;
        private System.Windows.Forms.TextBox drpartmet_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}