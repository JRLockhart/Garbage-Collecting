using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garbageCollecting
{
    public partial class Form1 : Form
    {

        //declare object fields
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();

            //add values to objects
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 33 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 40 };
        }

        //display results when button is clicked
        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        //swap the objects
        private void swap_Click(object sender, EventArgs e)
        {
            Elephant swap = new Elephant();
            swap = lloyd;
            lloyd = lucinda;
            lucinda = swap;
            MessageBox.Show("Objects Swapped");
        }
    }
}
