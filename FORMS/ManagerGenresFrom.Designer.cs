
namespace QuanlythuvienDHCNQN.FORMS
{
    partial class ManagerGenresFrom
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
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_genres = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.OrangeRed;
            this.label_header.Font = new System.Drawing.Font("Adobe Fangsong Std R", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(106, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(284, 100);
            this.label_header.TabIndex = 1;
            this.label_header.Text = " Genres";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.dataGridView_genres);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 405);
            this.panel1.TabIndex = 2;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Aquamarine;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(256, 316);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(150, 40);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Aquamarine;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(462, 316);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(150, 40);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Aquamarine;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(44, 316);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(150, 40);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_genres
            // 
            this.dataGridView_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_genres.Location = new System.Drawing.Point(650, 51);
            this.dataGridView_genres.Name = "dataGridView_genres";
            this.dataGridView_genres.RowHeadersWidth = 51;
            this.dataGridView_genres.RowTemplate.Height = 24;
            this.dataGridView_genres.Size = new System.Drawing.Size(498, 265);
            this.dataGridView_genres.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(175, 121);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(347, 38);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(175, 51);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(190, 38);
            this.textBox_id.TabIndex = 4;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(57, 51);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(53, 32);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(38, 124);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(94, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.OrangeRed;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.Location = new System.Drawing.Point(1127, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(57, 47);
            this.label_close.TabIndex = 2;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 100);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.ImageLocation = "../../IMAGES/genres.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerGenresFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerGenresFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerGenresFrom";
            this.Load += new System.EventHandler(this.ManagerGenresFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_genres;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
    }
}