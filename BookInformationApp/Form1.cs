using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private Hashtable tables=new Hashtable();

         private string isbn;

       private string bookDetails;
        private void addButton_Click(object sender, EventArgs e)
        {
            isbn = isbnTextBox.Text;

            bookDetails = bookdetaillsTextBox.Text;
            
            tables.Add(isbn, bookDetails);
            
            isbnTextBox.Text = "";
            bookdetaillsTextBox.Text = "";

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string search = textBox3.Text;

 if (tables.ContainsKey(search))
 {
     bookdeatilsTextBox.Text = tables[search].ToString();

 }
 else
 {
 MessageBox.Show("Book Not Found");
 bookdeatilsTextBox.Text = "";
 }

        }
    }
}
