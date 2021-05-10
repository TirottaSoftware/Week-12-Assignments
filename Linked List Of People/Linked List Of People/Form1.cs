using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_List_Of_People
{
    public partial class Form1 : Form
    {
        private LinkedList<string> names;
        public Form1()
        {
            names = new LinkedList<string>();
            InitializeComponent();
        }

        private void UpdateList()
        {
            lbxNames.Items.Clear();
            foreach (var name in this.names)
            {
                lbxNames.Items.Add(name);
            }
            lblAmount.Text = names.Count.ToString();
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            if (names.Count == 0)
            {
                names.AddFirst(name);
            }
            else
            {
                names.AddAfter(names.Last, name);
            }
            tbxName.Text = "";
            UpdateList();
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            names.RemoveFirst();
            UpdateList();
        }

        private void btnSelectName_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)nudIndex.Value;
                if (n == 0)
                {
                    lblSelectedNameValue.Text = names.First.Value;
                }
                else if (n == this.names.Count - 1)
                {
                    lblSelectedNameValue.Text = names.Last.Value;
                }
                else
                {
                    LinkedList<string> namesCopy = new LinkedList<string>();
                    foreach (var name in this.names)
                    {
                        namesCopy.AddLast(name);
                    }
                    for (int i = 0; i < n; i++)
                    {
                        namesCopy.RemoveFirst();
                    }
                    lblSelectedNameValue.Text = namesCopy.First.Value;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid index");
            }
        }
    }
}
