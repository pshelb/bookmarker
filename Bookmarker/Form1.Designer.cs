namespace Bookmarker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabListBooks = new System.Windows.Forms.TabPage();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.listViewListBooks = new System.Windows.Forms.ListView();
            this.columnHeaderTitle1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYearPubl1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNumWords1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYearRead1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFormat1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRating1 = new System.Windows.Forms.ColumnHeader();
            this.tabFindBooks = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelSearch2 = new System.Windows.Forms.Label();
            this.labelSearch1 = new System.Windows.Forms.Label();
            this.listViewSearchBooks = new System.Windows.Forms.ListView();
            this.columnHeaderTitle2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYearPubl2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNumWords2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYearRead2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFormat2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRating2 = new System.Windows.Forms.ColumnHeader();
            this.tabAddBooks = new System.Windows.Forms.TabPage();
            this.labelAddBooksError = new System.Windows.Forms.Label();
            this.labelAddBooksErrorIcon = new System.Windows.Forms.Label();
            this.groupBox_3_1 = new System.Windows.Forms.GroupBox();
            this.buttonAddBookDetails = new System.Windows.Forms.Button();
            this.buttonClearFieldsAdd = new System.Windows.Forms.Button();
            this.labelAddRating = new System.Windows.Forms.Label();
            this.labelAddFormat = new System.Windows.Forms.Label();
            this.labelAddYearRead = new System.Windows.Forms.Label();
            this.labelAddPublish = new System.Windows.Forms.Label();
            this.labelAddAuth = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.comboBoxAddRating = new System.Windows.Forms.ComboBox();
            this.comboBoxAddFormat = new System.Windows.Forms.ComboBox();
            this.textBoxAddYearRead = new System.Windows.Forms.TextBox();
            this.textBoxAddWordCount = new System.Windows.Forms.TextBox();
            this.textBoxAddPublish = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabBooksToRead = new System.Windows.Forms.TabPage();
            this.labelToReadError = new System.Windows.Forms.Label();
            this.labelToReadErrorIcon = new System.Windows.Forms.Label();
            this.groupBox_4_2 = new System.Windows.Forms.GroupBox();
            this.buttonReadBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.groupBox_4_1 = new System.Windows.Forms.GroupBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.listViewToRead = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor = new System.Windows.Forms.ColumnHeader();
            this.booksToReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSet = new Bookmarker.booksDBDataSet();
            this.readBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksToReadTableAdapter = new Bookmarker.booksDBDataSetTableAdapters.BooksToReadTableAdapter();
            this.readTableAdapter = new Bookmarker.booksDBDataSetTableAdapters.ReadTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Bookmarker.booksDBDataSetTableAdapters.BookTableAdapter();
            this.booksReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksReadTableAdapter = new Bookmarker.booksDBDataSetTableAdapters.BooksReadTableAdapter();
            this.mainTabControl.SuspendLayout();
            this.tabListBooks.SuspendLayout();
            this.tabFindBooks.SuspendLayout();
            this.tabAddBooks.SuspendLayout();
            this.groupBox_3_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabBooksToRead.SuspendLayout();
            this.groupBox_4_2.SuspendLayout();
            this.groupBox_4_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksToReadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Indigo;
            this.headerLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(760, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Bookmarker";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabListBooks);
            this.mainTabControl.Controls.Add(this.tabFindBooks);
            this.mainTabControl.Controls.Add(this.tabAddBooks);
            this.mainTabControl.Controls.Add(this.tabBooksToRead);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 30);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(760, 393);
            this.mainTabControl.TabIndex = 1;
            // 
            // tabListBooks
            // 
            this.tabListBooks.BackColor = System.Drawing.Color.Maroon;
            this.tabListBooks.Controls.Add(this.labelSort);
            this.tabListBooks.Controls.Add(this.comboBoxSort);
            this.tabListBooks.Controls.Add(this.listViewListBooks);
            this.tabListBooks.Location = new System.Drawing.Point(4, 24);
            this.tabListBooks.Name = "tabListBooks";
            this.tabListBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabListBooks.Size = new System.Drawing.Size(752, 365);
            this.tabListBooks.TabIndex = 0;
            this.tabListBooks.Text = "List Books";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.ForeColor = System.Drawing.Color.White;
            this.labelSort.Location = new System.Drawing.Point(242, 25);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(54, 16);
            this.labelSort.TabIndex = 2;
            this.labelSort.Text = "Sort By:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxSort.ForeColor = System.Drawing.Color.White;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Year Published",
            "Word Count",
            "Year Read",
            "Format",
            "Rating"});
            this.comboBoxSort.Location = new System.Drawing.Point(302, 22);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(203, 23);
            this.comboBoxSort.TabIndex = 1;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // listViewListBooks
            // 
            this.listViewListBooks.AllowColumnReorder = true;
            this.listViewListBooks.BackColor = System.Drawing.Color.Thistle;
            this.listViewListBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle1,
            this.columnHeaderAuthor1,
            this.columnHeaderYearPubl1,
            this.columnHeaderNumWords1,
            this.columnHeaderYearRead1,
            this.columnHeaderFormat1,
            this.columnHeaderRating1});
            this.listViewListBooks.ForeColor = System.Drawing.Color.Black;
            this.listViewListBooks.Location = new System.Drawing.Point(30, 61);
            this.listViewListBooks.Name = "listViewListBooks";
            this.listViewListBooks.Size = new System.Drawing.Size(691, 273);
            this.listViewListBooks.TabIndex = 0;
            this.listViewListBooks.UseCompatibleStateImageBehavior = false;
            this.listViewListBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle1
            // 
            this.columnHeaderTitle1.Text = "Title";
            this.columnHeaderTitle1.Width = 255;
            // 
            // columnHeaderAuthor1
            // 
            this.columnHeaderAuthor1.Text = "Author";
            this.columnHeaderAuthor1.Width = 191;
            // 
            // columnHeaderYearPubl1
            // 
            this.columnHeaderYearPubl1.Text = "Year Published";
            this.columnHeaderYearPubl1.Width = 75;
            // 
            // columnHeaderNumWords1
            // 
            this.columnHeaderNumWords1.Text = "Word Count";
            this.columnHeaderNumWords1.Width = 98;
            // 
            // columnHeaderYearRead1
            // 
            this.columnHeaderYearRead1.Text = "Year Read";
            this.columnHeaderYearRead1.Width = 71;
            // 
            // columnHeaderFormat1
            // 
            this.columnHeaderFormat1.Text = "Format";
            this.columnHeaderFormat1.Width = 64;
            // 
            // columnHeaderRating1
            // 
            this.columnHeaderRating1.Text = "Rating";
            this.columnHeaderRating1.Width = 49;
            // 
            // tabFindBooks
            // 
            this.tabFindBooks.BackColor = System.Drawing.Color.Maroon;
            this.tabFindBooks.Controls.Add(this.buttonSearch);
            this.tabFindBooks.Controls.Add(this.textBoxSearchValue);
            this.tabFindBooks.Controls.Add(this.comboBoxSearch);
            this.tabFindBooks.Controls.Add(this.labelSearch2);
            this.tabFindBooks.Controls.Add(this.labelSearch1);
            this.tabFindBooks.Controls.Add(this.listViewSearchBooks);
            this.tabFindBooks.Location = new System.Drawing.Point(4, 24);
            this.tabFindBooks.Name = "tabFindBooks";
            this.tabFindBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindBooks.Size = new System.Drawing.Size(752, 365);
            this.tabFindBooks.TabIndex = 1;
            this.tabFindBooks.Text = "Find Books";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Thistle;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(593, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.BackColor = System.Drawing.Color.Maroon;
            this.textBoxSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchValue.Location = new System.Drawing.Point(420, 22);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(158, 22);
            this.textBoxSearchValue.TabIndex = 4;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.ForeColor = System.Drawing.Color.White;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Year Published",
            "Year Read",
            "Format",
            "Rating"});
            this.comboBoxSearch.Location = new System.Drawing.Point(169, 22);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(167, 24);
            this.comboBoxSearch.TabIndex = 3;
            // 
            // labelSearch2
            // 
            this.labelSearch2.AutoSize = true;
            this.labelSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch2.ForeColor = System.Drawing.Color.White;
            this.labelSearch2.Location = new System.Drawing.Point(342, 25);
            this.labelSearch2.Name = "labelSearch2";
            this.labelSearch2.Size = new System.Drawing.Size(72, 16);
            this.labelSearch2.TabIndex = 2;
            this.labelSearch2.Text = "is/contains";
            // 
            // labelSearch1
            // 
            this.labelSearch1.AutoSize = true;
            this.labelSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch1.ForeColor = System.Drawing.Color.White;
            this.labelSearch1.Location = new System.Drawing.Point(49, 25);
            this.labelSearch1.Name = "labelSearch1";
            this.labelSearch1.Size = new System.Drawing.Size(114, 16);
            this.labelSearch1.TabIndex = 1;
            this.labelSearch1.Text = "Find books where";
            // 
            // listViewSearchBooks
            // 
            this.listViewSearchBooks.AllowColumnReorder = true;
            this.listViewSearchBooks.BackColor = System.Drawing.Color.Thistle;
            this.listViewSearchBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle2,
            this.columnHeaderAuthor2,
            this.columnHeaderYearPubl2,
            this.columnHeaderNumWords2,
            this.columnHeaderYearRead2,
            this.columnHeaderFormat2,
            this.columnHeaderRating2});
            this.listViewSearchBooks.ForeColor = System.Drawing.Color.Black;
            this.listViewSearchBooks.Location = new System.Drawing.Point(30, 61);
            this.listViewSearchBooks.Name = "listViewSearchBooks";
            this.listViewSearchBooks.Size = new System.Drawing.Size(691, 273);
            this.listViewSearchBooks.TabIndex = 0;
            this.listViewSearchBooks.UseCompatibleStateImageBehavior = false;
            this.listViewSearchBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle2
            // 
            this.columnHeaderTitle2.Text = "Title";
            this.columnHeaderTitle2.Width = 255;
            // 
            // columnHeaderAuthor2
            // 
            this.columnHeaderAuthor2.Text = "Author";
            this.columnHeaderAuthor2.Width = 191;
            // 
            // columnHeaderYearPubl2
            // 
            this.columnHeaderYearPubl2.Text = "Year Published";
            this.columnHeaderYearPubl2.Width = 75;
            // 
            // columnHeaderNumWords2
            // 
            this.columnHeaderNumWords2.Text = "Word Count";
            this.columnHeaderNumWords2.Width = 98;
            // 
            // columnHeaderYearRead2
            // 
            this.columnHeaderYearRead2.Text = "Year Read";
            this.columnHeaderYearRead2.Width = 71;
            // 
            // columnHeaderFormat2
            // 
            this.columnHeaderFormat2.Text = "Format";
            this.columnHeaderFormat2.Width = 64;
            // 
            // columnHeaderRating2
            // 
            this.columnHeaderRating2.Text = "Rating";
            this.columnHeaderRating2.Width = 49;
            // 
            // tabAddBooks
            // 
            this.tabAddBooks.BackColor = System.Drawing.Color.Maroon;
            this.tabAddBooks.Controls.Add(this.labelAddBooksError);
            this.tabAddBooks.Controls.Add(this.labelAddBooksErrorIcon);
            this.tabAddBooks.Controls.Add(this.groupBox_3_1);
            this.tabAddBooks.Controls.Add(this.pictureBox1);
            this.tabAddBooks.Location = new System.Drawing.Point(4, 24);
            this.tabAddBooks.Name = "tabAddBooks";
            this.tabAddBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddBooks.Size = new System.Drawing.Size(752, 365);
            this.tabAddBooks.TabIndex = 2;
            this.tabAddBooks.Text = "Add Books";
            // 
            // labelAddBooksError
            // 
            this.labelAddBooksError.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelAddBooksError.AutoSize = true;
            this.labelAddBooksError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBooksError.ForeColor = System.Drawing.Color.White;
            this.labelAddBooksError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddBooksError.Location = new System.Drawing.Point(303, 325);
            this.labelAddBooksError.Name = "labelAddBooksError";
            this.labelAddBooksError.Size = new System.Drawing.Size(43, 16);
            this.labelAddBooksError.TabIndex = 6;
            this.labelAddBooksError.Text = "Error: ";
            this.labelAddBooksError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddBooksError.Visible = false;
            // 
            // labelAddBooksErrorIcon
            // 
            this.labelAddBooksErrorIcon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelAddBooksErrorIcon.AutoSize = true;
            this.labelAddBooksErrorIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBooksErrorIcon.ForeColor = System.Drawing.Color.White;
            this.labelAddBooksErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelAddBooksErrorIcon.Image")));
            this.labelAddBooksErrorIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddBooksErrorIcon.Location = new System.Drawing.Point(274, 325);
            this.labelAddBooksErrorIcon.Name = "labelAddBooksErrorIcon";
            this.labelAddBooksErrorIcon.Size = new System.Drawing.Size(23, 16);
            this.labelAddBooksErrorIcon.TabIndex = 5;
            this.labelAddBooksErrorIcon.Text = "     ";
            this.labelAddBooksErrorIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddBooksErrorIcon.Visible = false;
            // 
            // groupBox_3_1
            // 
            this.groupBox_3_1.Controls.Add(this.buttonAddBookDetails);
            this.groupBox_3_1.Controls.Add(this.buttonClearFieldsAdd);
            this.groupBox_3_1.Controls.Add(this.labelAddRating);
            this.groupBox_3_1.Controls.Add(this.labelAddFormat);
            this.groupBox_3_1.Controls.Add(this.labelAddYearRead);
            this.groupBox_3_1.Controls.Add(this.labelAddPublish);
            this.groupBox_3_1.Controls.Add(this.labelAddAuth);
            this.groupBox_3_1.Controls.Add(this.labelWordCount);
            this.groupBox_3_1.Controls.Add(this.labelAddTitle);
            this.groupBox_3_1.Controls.Add(this.comboBoxAddRating);
            this.groupBox_3_1.Controls.Add(this.comboBoxAddFormat);
            this.groupBox_3_1.Controls.Add(this.textBoxAddYearRead);
            this.groupBox_3_1.Controls.Add(this.textBoxAddWordCount);
            this.groupBox_3_1.Controls.Add(this.textBoxAddPublish);
            this.groupBox_3_1.Controls.Add(this.textBoxAddAuthor);
            this.groupBox_3_1.Controls.Add(this.textBoxAddTitle);
            this.groupBox_3_1.ForeColor = System.Drawing.Color.White;
            this.groupBox_3_1.Location = new System.Drawing.Point(241, 31);
            this.groupBox_3_1.Name = "groupBox_3_1";
            this.groupBox_3_1.Size = new System.Drawing.Size(481, 271);
            this.groupBox_3_1.TabIndex = 2;
            this.groupBox_3_1.TabStop = false;
            this.groupBox_3_1.Text = "Newly read book details";
            // 
            // buttonAddBookDetails
            // 
            this.buttonAddBookDetails.BackColor = System.Drawing.Color.Thistle;
            this.buttonAddBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBookDetails.ForeColor = System.Drawing.Color.Black;
            this.buttonAddBookDetails.Location = new System.Drawing.Point(338, 219);
            this.buttonAddBookDetails.Name = "buttonAddBookDetails";
            this.buttonAddBookDetails.Size = new System.Drawing.Size(111, 23);
            this.buttonAddBookDetails.TabIndex = 15;
            this.buttonAddBookDetails.Text = "Save Details";
            this.buttonAddBookDetails.UseVisualStyleBackColor = false;
            this.buttonAddBookDetails.Click += new System.EventHandler(this.buttonAddBookDetails_Click);
            // 
            // buttonClearFieldsAdd
            // 
            this.buttonClearFieldsAdd.BackColor = System.Drawing.Color.Thistle;
            this.buttonClearFieldsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFieldsAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonClearFieldsAdd.Location = new System.Drawing.Point(338, 187);
            this.buttonClearFieldsAdd.Name = "buttonClearFieldsAdd";
            this.buttonClearFieldsAdd.Size = new System.Drawing.Size(111, 23);
            this.buttonClearFieldsAdd.TabIndex = 14;
            this.buttonClearFieldsAdd.Text = "Clear Fields";
            this.buttonClearFieldsAdd.UseVisualStyleBackColor = false;
            this.buttonClearFieldsAdd.Click += new System.EventHandler(this.buttonClearFieldsAdd_Click);
            // 
            // labelAddRating
            // 
            this.labelAddRating.AutoSize = true;
            this.labelAddRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRating.ForeColor = System.Drawing.Color.White;
            this.labelAddRating.Location = new System.Drawing.Point(28, 222);
            this.labelAddRating.Name = "labelAddRating";
            this.labelAddRating.Size = new System.Drawing.Size(50, 16);
            this.labelAddRating.TabIndex = 13;
            this.labelAddRating.Text = "Rating:";
            // 
            // labelAddFormat
            // 
            this.labelAddFormat.AutoSize = true;
            this.labelAddFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddFormat.ForeColor = System.Drawing.Color.White;
            this.labelAddFormat.Location = new System.Drawing.Point(28, 190);
            this.labelAddFormat.Name = "labelAddFormat";
            this.labelAddFormat.Size = new System.Drawing.Size(53, 16);
            this.labelAddFormat.TabIndex = 12;
            this.labelAddFormat.Text = "Format:";
            // 
            // labelAddYearRead
            // 
            this.labelAddYearRead.AutoSize = true;
            this.labelAddYearRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddYearRead.ForeColor = System.Drawing.Color.White;
            this.labelAddYearRead.Location = new System.Drawing.Point(28, 160);
            this.labelAddYearRead.Name = "labelAddYearRead";
            this.labelAddYearRead.Size = new System.Drawing.Size(77, 16);
            this.labelAddYearRead.TabIndex = 11;
            this.labelAddYearRead.Text = "Year Read:";
            // 
            // labelAddPublish
            // 
            this.labelAddPublish.AutoSize = true;
            this.labelAddPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPublish.ForeColor = System.Drawing.Color.White;
            this.labelAddPublish.Location = new System.Drawing.Point(28, 100);
            this.labelAddPublish.Name = "labelAddPublish";
            this.labelAddPublish.Size = new System.Drawing.Size(103, 16);
            this.labelAddPublish.TabIndex = 10;
            this.labelAddPublish.Text = "Year Published:";
            // 
            // labelAddAuth
            // 
            this.labelAddAuth.AutoSize = true;
            this.labelAddAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAuth.ForeColor = System.Drawing.Color.White;
            this.labelAddAuth.Location = new System.Drawing.Point(28, 70);
            this.labelAddAuth.Name = "labelAddAuth";
            this.labelAddAuth.Size = new System.Drawing.Size(49, 16);
            this.labelAddAuth.TabIndex = 9;
            this.labelAddAuth.Text = "Author:";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordCount.ForeColor = System.Drawing.Color.White;
            this.labelWordCount.Location = new System.Drawing.Point(28, 130);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(116, 16);
            this.labelWordCount.TabIndex = 8;
            this.labelWordCount.Text = "Number of Words:";
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddTitle.Location = new System.Drawing.Point(28, 40);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(37, 16);
            this.labelAddTitle.TabIndex = 7;
            this.labelAddTitle.Text = "Title:";
            // 
            // comboBoxAddRating
            // 
            this.comboBoxAddRating.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxAddRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddRating.ForeColor = System.Drawing.Color.White;
            this.comboBoxAddRating.FormattingEnabled = true;
            this.comboBoxAddRating.Items.AddRange(new object[] {
            "5",
            "4.5",
            "4",
            "3.5",
            "3",
            "2.5",
            "2",
            "1.5",
            "1",
            "0.5",
            "0"});
            this.comboBoxAddRating.Location = new System.Drawing.Point(150, 219);
            this.comboBoxAddRating.Name = "comboBoxAddRating";
            this.comboBoxAddRating.Size = new System.Drawing.Size(130, 24);
            this.comboBoxAddRating.TabIndex = 6;
            // 
            // comboBoxAddFormat
            // 
            this.comboBoxAddFormat.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxAddFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddFormat.ForeColor = System.Drawing.Color.White;
            this.comboBoxAddFormat.FormattingEnabled = true;
            this.comboBoxAddFormat.Items.AddRange(new object[] {
            "Book",
            "eBook",
            "Audiobook",
            "Printout",
            "Other"});
            this.comboBoxAddFormat.Location = new System.Drawing.Point(150, 187);
            this.comboBoxAddFormat.Name = "comboBoxAddFormat";
            this.comboBoxAddFormat.Size = new System.Drawing.Size(130, 24);
            this.comboBoxAddFormat.TabIndex = 5;
            // 
            // textBoxAddYearRead
            // 
            this.textBoxAddYearRead.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAddYearRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddYearRead.ForeColor = System.Drawing.Color.White;
            this.textBoxAddYearRead.Location = new System.Drawing.Point(150, 157);
            this.textBoxAddYearRead.Name = "textBoxAddYearRead";
            this.textBoxAddYearRead.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddYearRead.TabIndex = 4;
            // 
            // textBoxAddWordCount
            // 
            this.textBoxAddWordCount.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAddWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddWordCount.ForeColor = System.Drawing.Color.White;
            this.textBoxAddWordCount.Location = new System.Drawing.Point(150, 127);
            this.textBoxAddWordCount.Name = "textBoxAddWordCount";
            this.textBoxAddWordCount.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddWordCount.TabIndex = 3;
            // 
            // textBoxAddPublish
            // 
            this.textBoxAddPublish.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAddPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddPublish.ForeColor = System.Drawing.Color.White;
            this.textBoxAddPublish.Location = new System.Drawing.Point(150, 97);
            this.textBoxAddPublish.Name = "textBoxAddPublish";
            this.textBoxAddPublish.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddPublish.TabIndex = 2;
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddAuthor.ForeColor = System.Drawing.Color.White;
            this.textBoxAddAuthor.Location = new System.Drawing.Point(150, 67);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(299, 22);
            this.textBoxAddAuthor.TabIndex = 1;
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxAddTitle.Location = new System.Drawing.Point(150, 37);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(299, 22);
            this.textBoxAddTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabBooksToRead
            // 
            this.tabBooksToRead.AutoScroll = true;
            this.tabBooksToRead.BackColor = System.Drawing.Color.Maroon;
            this.tabBooksToRead.Controls.Add(this.labelToReadError);
            this.tabBooksToRead.Controls.Add(this.labelToReadErrorIcon);
            this.tabBooksToRead.Controls.Add(this.groupBox_4_2);
            this.tabBooksToRead.Controls.Add(this.groupBox_4_1);
            this.tabBooksToRead.Controls.Add(this.listViewToRead);
            this.tabBooksToRead.Location = new System.Drawing.Point(4, 24);
            this.tabBooksToRead.Name = "tabBooksToRead";
            this.tabBooksToRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooksToRead.Size = new System.Drawing.Size(752, 365);
            this.tabBooksToRead.TabIndex = 3;
            this.tabBooksToRead.Text = "Books to Read";
            // 
            // labelToReadError
            // 
            this.labelToReadError.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelToReadError.AutoSize = true;
            this.labelToReadError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToReadError.ForeColor = System.Drawing.Color.White;
            this.labelToReadError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelToReadError.Location = new System.Drawing.Point(434, 320);
            this.labelToReadError.Name = "labelToReadError";
            this.labelToReadError.Size = new System.Drawing.Size(43, 16);
            this.labelToReadError.TabIndex = 4;
            this.labelToReadError.Text = "Error: ";
            this.labelToReadError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToReadError.Visible = false;
            // 
            // labelToReadErrorIcon
            // 
            this.labelToReadErrorIcon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelToReadErrorIcon.AutoSize = true;
            this.labelToReadErrorIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToReadErrorIcon.ForeColor = System.Drawing.Color.White;
            this.labelToReadErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelToReadErrorIcon.Image")));
            this.labelToReadErrorIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelToReadErrorIcon.Location = new System.Drawing.Point(405, 320);
            this.labelToReadErrorIcon.Name = "labelToReadErrorIcon";
            this.labelToReadErrorIcon.Size = new System.Drawing.Size(23, 16);
            this.labelToReadErrorIcon.TabIndex = 3;
            this.labelToReadErrorIcon.Text = "     ";
            this.labelToReadErrorIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToReadErrorIcon.Visible = false;
            // 
            // groupBox_4_2
            // 
            this.groupBox_4_2.Controls.Add(this.buttonReadBook);
            this.groupBox_4_2.Controls.Add(this.buttonRemoveBook);
            this.groupBox_4_2.ForeColor = System.Drawing.Color.White;
            this.groupBox_4_2.Location = new System.Drawing.Point(405, 214);
            this.groupBox_4_2.Name = "groupBox_4_2";
            this.groupBox_4_2.Size = new System.Drawing.Size(316, 82);
            this.groupBox_4_2.TabIndex = 2;
            this.groupBox_4_2.TabStop = false;
            this.groupBox_4_2.Text = "Remove or read selected book";
            // 
            // buttonReadBook
            // 
            this.buttonReadBook.BackColor = System.Drawing.Color.Thistle;
            this.buttonReadBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadBook.ForeColor = System.Drawing.Color.Black;
            this.buttonReadBook.Location = new System.Drawing.Point(172, 34);
            this.buttonReadBook.Name = "buttonReadBook";
            this.buttonReadBook.Size = new System.Drawing.Size(111, 23);
            this.buttonReadBook.TabIndex = 1;
            this.buttonReadBook.Text = "Read Book";
            this.buttonReadBook.UseVisualStyleBackColor = false;
            this.buttonReadBook.Click += new System.EventHandler(this.buttonReadBook_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.BackColor = System.Drawing.Color.Thistle;
            this.buttonRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveBook.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveBook.Location = new System.Drawing.Point(28, 34);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(111, 23);
            this.buttonRemoveBook.TabIndex = 0;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = false;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // groupBox_4_1
            // 
            this.groupBox_4_1.Controls.Add(this.buttonClearFields);
            this.groupBox_4_1.Controls.Add(this.labelTitle);
            this.groupBox_4_1.Controls.Add(this.labelAuthor);
            this.groupBox_4_1.Controls.Add(this.textBoxAuthor);
            this.groupBox_4_1.Controls.Add(this.textBoxTitle);
            this.groupBox_4_1.Controls.Add(this.buttonAddBook);
            this.groupBox_4_1.ForeColor = System.Drawing.Color.White;
            this.groupBox_4_1.Location = new System.Drawing.Point(405, 30);
            this.groupBox_4_1.Name = "groupBox_4_1";
            this.groupBox_4_1.Size = new System.Drawing.Size(316, 164);
            this.groupBox_4_1.TabIndex = 1;
            this.groupBox_4_1.TabStop = false;
            this.groupBox_4_1.Text = "Add a book to the list";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.Color.Thistle;
            this.buttonClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.Color.Black;
            this.buttonClearFields.Location = new System.Drawing.Point(28, 116);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(111, 23);
            this.buttonClearFields.TabIndex = 5;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(37, 16);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(25, 79);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(49, 16);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.Color.Maroon;
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthor.Location = new System.Drawing.Point(81, 76);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(202, 22);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Maroon;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.Location = new System.Drawing.Point(81, 35);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(202, 22);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Thistle;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.Color.Black;
            this.buttonAddBook.Location = new System.Drawing.Point(172, 116);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(111, 23);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // listViewToRead
            // 
            this.listViewToRead.BackColor = System.Drawing.Color.Thistle;
            this.listViewToRead.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderAuthor});
            this.listViewToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewToRead.ForeColor = System.Drawing.Color.Black;
            this.listViewToRead.Location = new System.Drawing.Point(30, 30);
            this.listViewToRead.Name = "listViewToRead";
            this.listViewToRead.Size = new System.Drawing.Size(345, 304);
            this.listViewToRead.TabIndex = 0;
            this.listViewToRead.UseCompatibleStateImageBehavior = false;
            this.listViewToRead.View = System.Windows.Forms.View.Details;
            this.listViewToRead.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewToRead_ColumnClick);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 194;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 147;
            // 
            // booksToReadBindingSource
            // 
            this.booksToReadBindingSource.DataMember = "BooksToRead";
            this.booksToReadBindingSource.DataSource = this.booksDBDataSet;
            // 
            // booksDBDataSet
            // 
            this.booksDBDataSet.DataSetName = "booksDBDataSet";
            this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readBindingSource
            // 
            this.readBindingSource.DataMember = "Read";
            this.readBindingSource.DataSource = this.booksDBDataSet;
            // 
            // booksToReadTableAdapter
            // 
            this.booksToReadTableAdapter.ClearBeforeFill = true;
            // 
            // readTableAdapter
            // 
            this.readTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.booksDBDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // booksReadBindingSource
            // 
            this.booksReadBindingSource.DataMember = "BooksRead";
            this.booksReadBindingSource.DataSource = this.booksDBDataSet;
            // 
            // booksReadTableAdapter
            // 
            this.booksReadTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(760, 423);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bookmarker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabListBooks.ResumeLayout(false);
            this.tabListBooks.PerformLayout();
            this.tabFindBooks.ResumeLayout(false);
            this.tabFindBooks.PerformLayout();
            this.tabAddBooks.ResumeLayout(false);
            this.tabAddBooks.PerformLayout();
            this.groupBox_3_1.ResumeLayout(false);
            this.groupBox_3_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabBooksToRead.ResumeLayout(false);
            this.tabBooksToRead.PerformLayout();
            this.groupBox_4_2.ResumeLayout(false);
            this.groupBox_4_1.ResumeLayout(false);
            this.groupBox_4_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksToReadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabListBooks;
        private System.Windows.Forms.TabPage tabFindBooks;
        private System.Windows.Forms.TabPage tabAddBooks;
        private System.Windows.Forms.TabPage tabBooksToRead;
        private booksDBDataSet booksDBDataSet;
        private System.Windows.Forms.BindingSource booksToReadBindingSource;
        private System.Windows.Forms.BindingSource readBindingSource;
        private Bookmarker.booksDBDataSetTableAdapters.ReadTableAdapter readTableAdapter;
        private System.Windows.Forms.ListView listViewToRead;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private Bookmarker.booksDBDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.GroupBox groupBox_4_1;
        private System.Windows.Forms.GroupBox groupBox_4_2;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonReadBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ListView listViewListBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle1;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor1;
        private System.Windows.Forms.ColumnHeader columnHeaderYearPubl1;
        private System.Windows.Forms.ColumnHeader columnHeaderNumWords1;
        public Bookmarker.booksDBDataSetTableAdapters.BooksToReadTableAdapter booksToReadTableAdapter;
        private System.Windows.Forms.Label labelToReadError;
        private System.Windows.Forms.Label labelToReadErrorIcon;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_3_1;
        private System.Windows.Forms.TextBox textBoxAddTitle;
        private System.Windows.Forms.TextBox textBoxAddPublish;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.TextBox textBoxAddYearRead;
        private System.Windows.Forms.TextBox textBoxAddWordCount;
        private System.Windows.Forms.ComboBox comboBoxAddFormat;
        private System.Windows.Forms.ComboBox comboBoxAddRating;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.Label labelAddAuth;
        private System.Windows.Forms.Label labelAddRating;
        private System.Windows.Forms.Label labelAddFormat;
        private System.Windows.Forms.Label labelAddYearRead;
        private System.Windows.Forms.Label labelAddPublish;
        private System.Windows.Forms.Button buttonClearFieldsAdd;
        private System.Windows.Forms.Label labelAddBooksError;
        private System.Windows.Forms.Label labelAddBooksErrorIcon;
        private System.Windows.Forms.Button buttonAddBookDetails;
        private System.Windows.Forms.BindingSource booksReadBindingSource;
        private Bookmarker.booksDBDataSetTableAdapters.BooksReadTableAdapter booksReadTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeaderYearRead1;
        private System.Windows.Forms.ColumnHeader columnHeaderFormat1;
        private System.Windows.Forms.ColumnHeader columnHeaderRating1;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ListView listViewSearchBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle2;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor2;
        private System.Windows.Forms.ColumnHeader columnHeaderYearPubl2;
        private System.Windows.Forms.ColumnHeader columnHeaderNumWords2;
        private System.Windows.Forms.ColumnHeader columnHeaderYearRead2;
        private System.Windows.Forms.ColumnHeader columnHeaderFormat2;
        private System.Windows.Forms.ColumnHeader columnHeaderRating2;
        private System.Windows.Forms.Label labelSearch1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelSearch2;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Button buttonSearch;
    }
}

