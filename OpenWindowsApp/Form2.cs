using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int _colOpen = 0;
        List<int> _numOpen;
        Form1 _form;
        public void showWin(int colOpen, List<int> numOpen, Form1 form1)
        {
            _form = form1;
            _colOpen = colOpen;
            _numOpen = numOpen;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form.OpenWindow(_colOpen, _numOpen);
        }
    }
}
