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

namespace BookShelfReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This button will exit the program
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //when this button is clicked the inputs from thetextboxes will be add to the listbox
            string LastNameTitle = txtLastName.Text;
           

            //This adds items to the listboxItems.
            listBoxCollection.Items.Add(LastNameTitle);
         
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //When this button is clicked the program will sort the items alphabetically
            //by last name and book title.
            //var bookself = new string[] { txtBookTitle.Text, txtLastName.Text };
            //Array.Sort(bookself);
            //listBoxSorted.Items.Add(txtLastName.Text);
            //listBoxSorted.Items.Add(txtBookTitle.Text);

            ArrayList bookself = new ArrayList();
            foreach (object a in listBoxCollection.Items)
                bookself.Add(a);
            {
                bookself.Sort();
                listBoxSorted.Items.Clear();
                foreach(object a in bookself)
                {
                    listBoxSorted.Items.Add(a);
                }

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This button will clear the list boxes and text boxes
           
            txtLastName.Text = "";
            listBoxSorted.Items.Clear();
            listBoxCollection.Items.Clear();
        }
    }
}
