using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * Program logic for the Bookmarker Application
 * Author: pshelb
 */
namespace Bookmarker
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter listListBooksColumnSorter = new ListViewColumnSorter();
        private ListViewColumnSorter listToReadColumnSorter = new ListViewColumnSorter();

        public Form1()
        {
            InitializeComponent();
            this.listViewListBooks.ListViewItemSorter = listListBooksColumnSorter;
            this.listViewToRead.ListViewItemSorter = listToReadColumnSorter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads data into the 'booksDBDataSet.BooksRead' table.
            this.booksReadTableAdapter.Fill(this.booksDBDataSet.BooksRead);
            this.LoadListListBooks();
            this.LoadListToRead();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog(this);
        }

        #region Code for the List Books tab
        // Load Data from the DataSet into the ListView
        private void LoadListListBooks()
        {
            switch (comboBoxSort.Text.ToString())
            {
                case "Title":
                    this.booksReadTableAdapter.FillSortByTitle(this.booksDBDataSet.BooksRead);
                    break;
                case "Author":
                    this.booksReadTableAdapter.FillSortByAuthor(this.booksDBDataSet.BooksRead);
                    break;
                case "Year Published":
                    this.booksReadTableAdapter.FillSortByYearPublished(this.booksDBDataSet.BooksRead);
                    break;
                case "Word Count":
                    this.booksReadTableAdapter.FillSortByWordCount(this.booksDBDataSet.BooksRead);
                    break;
                case "Year Read":
                    this.booksReadTableAdapter.FillSortByYearRead(this.booksDBDataSet.BooksRead);
                    break;
                case "Format":
                    this.booksReadTableAdapter.FillSortByFormat(this.booksDBDataSet.BooksRead);
                    break;
                case "Rating":
                    this.booksReadTableAdapter.FillSortByRating(this.booksDBDataSet.BooksRead);
                    break;
                default:
                    // Loads data into the 'booksDBDataSet.BooksToRead' table.
                    this.booksReadTableAdapter.Fill(this.booksDBDataSet.BooksRead);
                    break;
            }

            // Get the table from the data set
            DataTable dtable = this.booksDBDataSet.Tables["BooksRead"];

            // Clear the ListView control
            this.listViewListBooks.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["Title"].ToString());
                    lvi.SubItems.Add(drow["Author"].ToString());
                    lvi.SubItems.Add(drow["Year_published"].ToString());
                    lvi.SubItems.Add(drow["Number_of_words"].ToString());
                    lvi.SubItems.Add(drow["Year_read"].ToString());
                    lvi.SubItems.Add(drow["Format"].ToString());
                    lvi.SubItems.Add(drow["Rating"].ToString());

                    // Add the list items to the ListView
                    listViewListBooks.Items.Add(lvi);
                }
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListListBooks();
        }
        #endregion

        #region Code for the Find Books tab
        private void SearchForBooks()
        {
            String searchType = comboBoxSearch.Text.ToString();
            
            String searchValue = textBoxSearchValue.Text;

            if (!validateSearchBooksInput(searchType, searchValue))
            {
                ClearListSearchBooks();
                return;
            }

            switch (searchType)
            {
                case "Title":
                    searchValue = "%" + searchValue + "%";
                    this.booksReadTableAdapter.FillSearchByTitle(this.booksDBDataSet.BooksRead, searchValue);
                    break;
                case "Author":
                    searchValue = "%" + searchValue + "%";
                    this.booksReadTableAdapter.FillSearchByAuthor(this.booksDBDataSet.BooksRead, searchValue);
                    break;
                case "Year Published":
                    this.booksReadTableAdapter.FillSearchByYearPublished(this.booksDBDataSet.BooksRead, (short)Convert.ToInt32(searchValue));
                    break;
                case "Year Read":
                    this.booksReadTableAdapter.FillSearchByYearRead(this.booksDBDataSet.BooksRead, Convert.ToInt32(searchValue));
                    break;
                case "Format":
                    this.booksReadTableAdapter.FillSearchByFormat(this.booksDBDataSet.BooksRead, searchValue);
                    break;
                case "Rating":
                    this.booksReadTableAdapter.FillSearchByRating(this.booksDBDataSet.BooksRead, Convert.ToDecimal(searchValue));
                    break;
                default:
                    ClearListSearchBooks();
                    return;
            }
            // Get the table from the data set
            DataTable dtable = this.booksDBDataSet.Tables["BooksRead"];

            // Clear the ListView control
            ClearListSearchBooks();

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["Title"].ToString());
                    lvi.SubItems.Add(drow["Author"].ToString());
                    lvi.SubItems.Add(drow["Year_published"].ToString());
                    lvi.SubItems.Add(drow["Number_of_words"].ToString());
                    lvi.SubItems.Add(drow["Year_read"].ToString());
                    lvi.SubItems.Add(drow["Format"].ToString());
                    lvi.SubItems.Add(drow["Rating"].ToString());

                    // Add the list items to the ListView
                    listViewSearchBooks.Items.Add(lvi);
                }
            }
        }

        private Boolean validateSearchBooksInput(String searchType, String searchValue)
        {
            if (searchValue == "")
            {
                return false;
            }
            if (searchType == "Year Published")
            {
                Int32 y = new Int32();
                try
                {
                    y = Convert.ToInt32(searchValue);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            if (searchType == "Year Read")
            {
                int y;
                try
                {
                    y = Convert.ToInt32(searchValue);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            if (searchType == "Rating")
            {
                double y;
                try
                {
                    y = Convert.ToDouble(searchValue);
                }
                catch (Exception e)
                {
                    return false;
                }
                if (y > 5 || y < 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        private void ClearListSearchBooks()
        {
            this.listViewSearchBooks.Items.Clear();
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForBooks();
        }
        #endregion

        #region Code for the Add Books tab
        private void addToBooksRead(String title, String author,
            String yearPubl, String wordCount, String yearRead,
            String rating, String format)
        {
            try
            {
                this.booksReadTableAdapter.Insert(
                    title, author,
                    (short)Convert.ToInt32(yearPubl),
                    Convert.ToInt32(wordCount),
                    Convert.ToInt32(yearRead),
                    Convert.ToDouble(rating),
                    format);
                this.booksReadTableAdapter.Update(this.booksDBDataSet.BooksRead);
                this.booksDBDataSet.AcceptChanges();
            }
            catch (Exception e)
            {
                displayAddBooksError("Problem saving data.");
            }
            this.LoadListListBooks();
        }

        private Boolean validateAddBooksInput(String title, String author,
            String yearPubl, String wordCount, String yearRead,
            String rating, String format)
        {
            if (title == "" || title.Length > 100)
            {
                displayAddBooksError("Invalid Title.");
                return false;
            }
            if (author == "" || author.Length > 50)
            {
                displayAddBooksError("Invalid Author.");
                return false;
            }
            if (yearPubl == "")
            {
                displayAddBooksError("Invalid Year Published.");
                return false;
            }
            if (yearPubl != "")
            {
                Int32 y = new Int32();
                try
                {
                    y = Convert.ToInt32(yearPubl);
                }
                catch (Exception e)
                {
                    displayAddBooksError("Invalid Year Published.");
                    return false;
                }
                if (y > 9999 || y < -9999)
                {
                    displayAddBooksError("Invalid Year Published.");
                    return false;
                }
            }
            if (wordCount == "")
            {
                displayAddBooksError("Invalid Number of Words.");
                return false;
            }
            if (wordCount != "")
            {
                int y;
                try
                {
                    y = Convert.ToInt32(wordCount);
                }
                catch (Exception e)
                {
                    displayAddBooksError("Invalid Number of Words.");
                    return false;
                }
                if (y > Int32.MaxValue || y < 0)
                {
                    displayAddBooksError("Invalid Number of Words.");
                    return false;
                }
            }
            if (yearRead == "")
            {
                displayAddBooksError("Invalid Year Read.");
                return false;
            }
            if (yearRead != "")
            {
                int y;
                try
                {
                    y = Convert.ToInt32(yearRead);
                }
                catch (Exception e)
                {
                    displayAddBooksError("Invalid Year Read.");
                    return false;
                }
                if (y > 9999 || y < 1900)
                {
                    displayAddBooksError("Invalid Year Read.");
                    return false;
                }
            }
            if (rating == "")
            {
                displayAddBooksError("Invalid Rating.");
                return false;
            }
            if (rating != "")
            {
                double y;
                try
                {
                    y = Convert.ToDouble(rating);
                }
                catch (Exception e)
                {
                    displayAddBooksError("Invalid Rating.");
                    return false;
                }
                if (y > 5 || y < 0)
                {
                    displayAddBooksError("Invalid Rating.");
                    return false;
                }
            }
            if (format == "")
            {
                displayAddBooksError("Invalid Format.");
                return false;
            }
            return true;
        }
        
        private void displayAddBooksError(String message)
        {
            labelAddBooksErrorIcon.Visible = true;
            labelAddBooksError.Visible = true;
            labelAddBooksError.Text = "Error: " + message;
        }

        void clearAddBooksError()
        {
            labelAddBooksErrorIcon.Visible = false;
            labelAddBooksError.Visible = false;
        }

        private void buttonClearFieldsAdd_Click(object sender, EventArgs e)
        {
            textBoxAddTitle.Text = "";
            textBoxAddAuthor.Text = "";
            textBoxAddPublish.Text = "";
            textBoxAddWordCount.Text = "";
            textBoxAddYearRead.Text = "";
            comboBoxAddFormat.Text = "";
            comboBoxAddRating.Text = "";
        }

        private void buttonAddBookDetails_Click(object sender, EventArgs e)
        {
            clearAddBooksError();
            String title = textBoxAddTitle.Text.ToString();
            String author = textBoxAddAuthor.Text.ToString();
            String yearPubl = textBoxAddPublish.Text.ToString();
            String wordCount = textBoxAddWordCount.Text.ToString();
            String yearRead = textBoxAddYearRead.Text.ToString();
            String rating = comboBoxAddRating.Text.ToString();
            String format = comboBoxAddFormat.Text.ToString();
            if (validateAddBooksInput(title, author, yearPubl, wordCount,
                                      yearRead, rating, format))
            {
                addToBooksRead(title, author, yearPubl, wordCount,
                                      yearRead, rating, format);
            }
        }
        #endregion

        #region Code for the Books to Read tab
        // Load Data from the DataSet into the ListView
        private void LoadListToRead()
        {
            // Loads data into the 'booksDBDataSet.BooksToRead' table.
            this.booksToReadTableAdapter.Fill(this.booksDBDataSet.BooksToRead);
            
            // Get the table from the data set
            DataTable dtable = this.booksDBDataSet.Tables["BooksToRead"];

            // Clear the ListView control
            this.listViewToRead.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["Book_title"].ToString());
                    lvi.SubItems.Add(drow["Book Author"].ToString());

                    // Add the list items to the ListView
                    listViewToRead.Items.Add(lvi);
                }
            }
            SortListToRead();
        }

        private void listViewToRead_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == listToReadColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (listToReadColumnSorter.Order == SortOrder.Ascending)
                {
                    listToReadColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    listToReadColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                listToReadColumnSorter.SortColumn = e.Column;
                listToReadColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            SortListToRead();
        }
        
        private void SortListToRead()
        {
            this.listViewToRead.Sort();
        }

        private void addToListToRead(String title, String author)
        {
            this.booksToReadTableAdapter.Insert(title, author);
            this.booksToReadTableAdapter.Update(this.booksDBDataSet.BooksToRead);
            this.booksDBDataSet.AcceptChanges();
            LoadListToRead();
        }

        private void removeFromListToRead(String title, String author)
        {
            this.booksToReadTableAdapter.Delete(title, author);
            this.booksToReadTableAdapter.Update(this.booksDBDataSet.BooksToRead);
            this.booksDBDataSet.AcceptChanges();
            LoadListToRead();
        }

        private void displayToReadError(String message)
        {
            labelToReadErrorIcon.Visible = true;
            labelToReadError.Visible = true;
            labelToReadError.Text = "Error: " + message;
        }

        void clearToReadError()
        {
            labelToReadErrorIcon.Visible = false;
            labelToReadError.Visible = false;
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            clearToReadError();
            String title = textBoxTitle.Text.ToString();
            String author = textBoxAuthor.Text.ToString();
            if (title != "" && author != "")
            {
                addToListToRead(title, author);
            }
            else
            {
                displayToReadError("Please enter a title and author.");
            }
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (listViewToRead.SelectedItems.Count == 1)
            {
                clearToReadError();
                String title = listViewToRead.SelectedItems[0].SubItems[0].Text;
                String author = listViewToRead.SelectedItems[0].SubItems[1].Text;
                removeFromListToRead(title, author);
            }
            else if (listViewToRead.SelectedItems.Count == 0)
            {
                displayToReadError("Please select a book to remove.");
            }
            else
            {
                displayToReadError("Please select one book at a time.");
            }
        }

        private void buttonReadBook_Click(object sender, EventArgs e)
        {
            if (listViewToRead.SelectedItems.Count == 1)
            {
                clearToReadError();
                // get title and author
                String title = listViewToRead.SelectedItems[0].SubItems[0].Text;
                String author = listViewToRead.SelectedItems[0].SubItems[1].Text;
                // remove from to read list and refresh
                removeFromListToRead(title, author);
                //populate add book fields and change tab
                this.mainTabControl.SelectTab(tabAddBooks);
                textBoxAddTitle.Text = title;
                textBoxAddAuthor.Text = author;
            }
            else if (listViewToRead.SelectedItems.Count == 0)
            {
                displayToReadError("Please select a book to read.");
            }
            else
            {
                displayToReadError("Please select one book at a time.");
            }
        }
        #endregion

    }
}
