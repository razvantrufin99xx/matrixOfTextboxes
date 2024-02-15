using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixOfTextboxes
{
    public partial class cellTextBox : UserControl
    {
        public cellTextBox()
        {
            InitializeComponent();
        }
        public Form1 f;
        public int si = 0;
        public int sj = 0;
        public string value = "";
        public void setsisj(int i, int j)
        {
           this.si = i;
           this.sj = j;
        }
        private void cellTextBox_Load(object sender, EventArgs e)
        {
            try { this.f = (Form1)Parent; }
            catch { }
        }
        public bool GetName()
        {
            
             f.setCurrentTextBoxeName(this.Name);
            f.setCurrentIndexOfTextBoxesIJ(si,sj);
            return true;
        }
        public void setValue(string s) { this.value = s;this.textBox1.Text = value;  }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.GetName();
        }
    }
}
