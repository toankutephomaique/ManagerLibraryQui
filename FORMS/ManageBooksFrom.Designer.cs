
namespace QuanlythuvienDHCNQN.FORMS
{
    partial class ManageBooksFrom
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_header = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.label_author_id = new System.Windows.Forms.Label();
            this.button_selectAuthor = new System.Windows.Forms.Button();
            this.textBox_authorFullName = new System.Windows.Forms.TextBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.button_selectCover = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_cover = new System.Windows.Forms.PictureBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateRecived = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 100);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.pictureBox1.ImageLocation = "../../IMAGES/book-logo-1.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.label_header.Font = new System.Drawing.Font("Adobe Fangsong Std R", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(110, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(288, 100);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "Books";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.Location = new System.Drawing.Point(1478, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(57, 47);
            this.label_close.TabIndex = 2;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 687);
            this.panel3.TabIndex = 8;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(3, 168);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(183, 48);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(3, 103);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(183, 48);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(3, 38);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(183, 48);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_AddBook);
            this.panel1.Controls.Add(this.label_author_id);
            this.panel1.Controls.Add(this.button_selectAuthor);
            this.panel1.Controls.Add(this.textBox_authorFullName);
            this.panel1.Controls.Add(this.numericUpDown_quantity);
            this.panel1.Controls.Add(this.comboBox_genre);
            this.panel1.Controls.Add(this.button_selectCover);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox_cover);
            this.panel1.Controls.Add(this.textBox_publisher);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker_dateRecived);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBox_description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_isbn);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Location = new System.Drawing.Point(195, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 669);
            this.panel1.TabIndex = 9;
            // 
            // button_AddBook
            // 
            this.button_AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.button_AddBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddBook.ForeColor = System.Drawing.Color.White;
            this.button_AddBook.Location = new System.Drawing.Point(232, 601);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(634, 48);
            this.button_AddBook.TabIndex = 51;
            this.button_AddBook.Text = "Add Book";
            this.button_AddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AddBook.UseVisualStyleBackColor = false;
            // 
            // label_author_id
            // 
            this.label_author_id.AutoSize = true;
            this.label_author_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author_id.Location = new System.Drawing.Point(291, 255);
            this.label_author_id.Name = "label_author_id";
            this.label_author_id.Size = new System.Drawing.Size(42, 29);
            this.label_author_id.TabIndex = 50;
            this.label_author_id.Text = "ID:";
            // 
            // button_selectAuthor
            // 
            this.button_selectAuthor.BackColor = System.Drawing.Color.White;
            this.button_selectAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_selectAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectAuthor.Location = new System.Drawing.Point(339, 253);
            this.button_selectAuthor.Name = "button_selectAuthor";
            this.button_selectAuthor.Size = new System.Drawing.Size(129, 38);
            this.button_selectAuthor.TabIndex = 49;
            this.button_selectAuthor.Text = "Select Author";
            this.button_selectAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_selectAuthor.UseVisualStyleBackColor = false;
            this.button_selectAuthor.Click += new System.EventHandler(this.button_selectAuthor_Click);
            // 
            // textBox_authorFullName
            // 
            this.textBox_authorFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_authorFullName.Location = new System.Drawing.Point(121, 252);
            this.textBox_authorFullName.Name = "textBox_authorFullName";
            this.textBox_authorFullName.Size = new System.Drawing.Size(164, 38);
            this.textBox_authorFullName.TabIndex = 48;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(121, 385);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(150, 36);
            this.numericUpDown_quantity.TabIndex = 47;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(119, 315);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(349, 39);
            this.comboBox_genre.TabIndex = 46;
            // 
            // button_selectCover
            // 
            this.button_selectCover.BackColor = System.Drawing.Color.White;
            this.button_selectCover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_selectCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectCover.Location = new System.Drawing.Point(987, 538);
            this.button_selectCover.Name = "button_selectCover";
            this.button_selectCover.Size = new System.Drawing.Size(329, 46);
            this.button_selectCover.TabIndex = 44;
            this.button_selectCover.Text = "Select Cover";
            this.button_selectCover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_selectCover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_selectCover.UseVisualStyleBackColor = false;
            this.button_selectCover.Click += new System.EventHandler(this.button_selectCover_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1099, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 32);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cover:";
            // 
            // pictureBox_cover
            // 
            this.pictureBox_cover.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_cover.Location = new System.Drawing.Point(987, 106);
            this.pictureBox_cover.Name = "pictureBox_cover";
            this.pictureBox_cover.Size = new System.Drawing.Size(329, 425);
            this.pictureBox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cover.TabIndex = 42;
            this.pictureBox_cover.TabStop = false;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_publisher.Location = new System.Drawing.Point(650, 60);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(295, 38);
            this.textBox_publisher.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Publisher:";
            // 
            // dateTimePicker_dateRecived
            // 
            this.dateTimePicker_dateRecived.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateRecived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateRecived.Location = new System.Drawing.Point(650, 129);
            this.dateTimePicker_dateRecived.Name = "dateTimePicker_dateRecived";
            this.dateTimePicker_dateRecived.Size = new System.Drawing.Size(295, 34);
            this.dateTimePicker_dateRecived.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Date Recived:";
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(119, 447);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(349, 38);
            this.textBox_price.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Genre:";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_description.Location = new System.Drawing.Point(650, 184);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(295, 400);
            this.richTextBox_description.TabIndex = 31;
            this.richTextBox_description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Author:";
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(121, 188);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(347, 38);
            this.textBox_title.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Title:";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_isbn.Location = new System.Drawing.Point(121, 121);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(347, 38);
            this.textBox_isbn.TabIndex = 25;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(121, 58);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(190, 38);
            this.textBox_id.TabIndex = 24;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(73, 67);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(42, 29);
            this.label_ID.TabIndex = 23;
            this.label_ID.Text = "ID:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(33, 130);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(75, 29);
            this.label_name.TabIndex = 22;
            this.label_name.Text = "ISBN:";
            // 
            // ManageBooksFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1535, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooksFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooksFrom";
            this.Load += new System.EventHandler(this.ManageBooksFrom_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_cover;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateRecived;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_selectCover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button button_selectAuthor;
        private System.Windows.Forms.Button button_AddBook;
        public System.Windows.Forms.TextBox textBox_authorFullName;
        public System.Windows.Forms.Label label_author_id;
    }
}