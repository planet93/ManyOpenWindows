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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 65; i++)
            {
                listForm.Add(new Form2());
                listForm[i].Text = $"Окно № {i + 1}";
                //listForm[i].Show();
            }
        }
        List<Form2> listForm = new List<Form2>();
        List<int> numberWindow = new List<int>();
        List<int> oldRandom = new List<int>();
        //int count;

        private void button1_Click(object sender, EventArgs e)
        {       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numMax = (int)numericUpDown1.Value;
            Random rnd = new Random();
            int value;
            if(numberWindow != null)
            {
                for (int i = 0; i < numberWindow.Count; i++)
                {
                    oldRandom.Add(numberWindow[i]);
                }
            }
            int index = 0;
            numberWindow = new List<int>();
            while(index < numMax)
            {
                value = rnd.Next(0, 64);
                var check = oldRandom.FirstOrDefault(x => x == value);
                if(check == 0)
                {
                    numberWindow.Add(value);
                    index++;
                }
            }
            //count = 0;
            listForm[numberWindow[0]].showWin(0, numberWindow,this);
        }

        public void OpenWindow(int count, List<int> numWindow)
        {
            count = count + 1;
            if (count > numWindow.Count - 1)
            {
                label1.Text = $"Открыто {numWindow.Count}";
                Show();
                this.Focus();
            }
            else
            {
                int valueWindow = numWindow[count];
                listForm[valueWindow].showWin(count, numWindow, this);
            }
            
        }
    }
}
