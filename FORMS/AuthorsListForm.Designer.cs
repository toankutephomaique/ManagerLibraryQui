﻿
namespace QuanlythuvienDHCNQN.FORMS
{
    partial class AuthorsListForm
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
            this.label_close = new System.Windows.Forms.Label();
            this.listBox_authors = new System.Windows.Forms.ListBox();
            this.button_selectAndClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Adobe Fangsong Std R", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gold;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.Location = new System.Drawing.Point(445, 3);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(56, 36);
            this.label_close.TabIndex = 2;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // listBox_authors
            // 
            this.listBox_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_authors.FormattingEnabled = true;
            this.listBox_authors.ItemHeight = 29;
            this.listBox_authors.Location = new System.Drawing.Point(2, 110);
            this.listBox_authors.Name = "listBox_authors";
            this.listBox_authors.Size = new System.Drawing.Size(499, 439);
            this.listBox_authors.TabIndex = 3;
            // 
            // button_selectAndClose
            // 
            this.button_selectAndClose.BackColor = System.Drawing.Color.White;
            this.button_selectAndClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_selectAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectAndClose.Location = new System.Drawing.Point(2, 555);
            this.button_selectAndClose.Name = "button_selectAndClose";
            this.button_selectAndClose.Size = new System.Drawing.Size(499, 52);
            this.button_selectAndClose.TabIndex = 50;
            this.button_selectAndClose.Text = "Select & Close";
            this.button_selectAndClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_selectAndClose.UseVisualStyleBackColor = false;
            this.button_selectAndClose.Click += new System.EventHandler(this.button_selectAndClose_Click);
            // 
            // AuthorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(505, 612);
            this.Controls.Add(this.button_selectAndClose);
            this.Controls.Add(this.listBox_authors);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsListForm";
            this.Load += new System.EventHandler(this.AuthorsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.ListBox listBox_authors;
        private System.Windows.Forms.Button button_selectAndClose;
    }
}