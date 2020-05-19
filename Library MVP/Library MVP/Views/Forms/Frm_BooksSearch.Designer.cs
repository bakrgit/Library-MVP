namespace Library_MVP.Views.Forms
{
    partial class Frm_BooksSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BooksSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.DGVSEARCH = new System.Windows.Forms.DataGridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnOneBook = new System.Windows.Forms.RadioButton();
            this.cbxBooks = new System.Windows.Forms.ComboBox();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSEARCH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(510, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "البحث عن الكتب";
            // 
            // DGVSEARCH
            // 
            this.DGVSEARCH.AllowUserToAddRows = false;
            this.DGVSEARCH.AllowUserToDeleteRows = false;
            this.DGVSEARCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSEARCH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSEARCH.BackgroundColor = System.Drawing.Color.White;
            this.DGVSEARCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSEARCH.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSEARCH.Location = new System.Drawing.Point(6, 128);
            this.DGVSEARCH.Name = "DGVSEARCH";
            this.DGVSEARCH.ReadOnly = true;
            this.DGVSEARCH.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DGVSEARCH.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVSEARCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSEARCH.Size = new System.Drawing.Size(1181, 428);
            this.DGVSEARCH.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1036, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 60);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "بحث";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(2, 83);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(82, 29);
            this.rbtnAll.TabIndex = 12;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "كل الكتب";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnOneBook
            // 
            this.rbtnOneBook.AutoSize = true;
            this.rbtnOneBook.Location = new System.Drawing.Point(80, 83);
            this.rbtnOneBook.Name = "rbtnOneBook";
            this.rbtnOneBook.Size = new System.Drawing.Size(88, 29);
            this.rbtnOneBook.TabIndex = 13;
            this.rbtnOneBook.Text = "كتاب محدد";
            this.rbtnOneBook.UseVisualStyleBackColor = true;
            // 
            // cbxBooks
            // 
            this.cbxBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBooks.FormattingEnabled = true;
            this.cbxBooks.Location = new System.Drawing.Point(174, 82);
            this.cbxBooks.Name = "cbxBooks";
            this.cbxBooks.Size = new System.Drawing.Size(216, 33);
            this.cbxBooks.TabIndex = 46;
            // 
            // cbxCat
            // 
            this.cbxCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(509, 82);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(182, 33);
            this.cbxCat.TabIndex = 48;
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Location = new System.Drawing.Point(396, 82);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(108, 29);
            this.rbtnCat.TabIndex = 49;
            this.rbtnCat.Text = "التصنيف العام";
            this.rbtnCat.UseVisualStyleBackColor = true;
            // 
            // Frm_BooksSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1196, 568);
            this.Controls.Add(this.rbtnCat);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.cbxBooks);
            this.Controls.Add(this.rbtnOneBook);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGVSEARCH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_BooksSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن الكتب";
            this.Load += new System.EventHandler(this.Frm_BooksSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSEARCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVSEARCH;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnOneBook;
        private System.Windows.Forms.ComboBox cbxBooks;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.RadioButton rbtnCat;
    }
}