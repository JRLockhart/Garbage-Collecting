using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garbageCollecting
{
    class Elephant
    {

        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My name is " + Name + " and my ear size is " + EarSize + " inches wide!");
        }
    }
}
