using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubclassConstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baseClassButton_Click(object sender, EventArgs e)
        {
            MyBaseClass baseClass = new MyBaseClass("Hello, base class");
        }

        private void subclassButton_Click(object sender, EventArgs e)
        {
            MySubclass subclass = new MySubclass("Hello, base class", "Hello, subclass");
        }
    }
}
