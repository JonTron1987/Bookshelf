﻿namespace BookShelfReader
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
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.Location = new System.Drawing.Point(184, 120);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(120, 95);
            this.listBoxCollection.TabIndex = 0;
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.Location = new System.Drawing.Point(184, 253);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(120, 95);
            this.listBoxSorted.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(184, 13);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author\'s last Name & Title of Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.listBoxSorted);
            this.Controls.Add(this.listBoxCollection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}

