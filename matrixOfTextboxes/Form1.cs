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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string currentTextBoxeName = "";
        public int currenti = 0;
        public int currentj = 0;

      

        public bool setCurrentTextBoxeName(string s)
        {
            this.currentTextBoxeName = s;
            this.Text = s;
            return true;
        }
        public bool setCurrentIndexOfTextBoxesIJ(int i , int j)
        {
            this.currenti = i;
            this.currentj = j;
            
            return true;
        }


        public textboxmatrix t; 

        public class textboxmatrix
        { 
            public List<List<cellTextBox>> cellsMatrix = new List<List<cellTextBox>>();
            public textboxmatrix( Form f)
            {
                int counter = f.Controls.Count;
                for (int i = 0; i < 10; i++)
                { 
                    cellsMatrix.Add(new List<cellTextBox>());
                    for (int j = 0; j < 10; j++)
                    {
                        cellsMatrix[i].Add(new cellTextBox());
                     
                        f.Controls.Add(cellsMatrix[i][j]);
                        f.Controls[counter].Top = 1+i*22;
                        f.Controls[counter].Left = 1+j*100;
                        f.Controls[counter].Visible = true;
                        f.Controls[counter].Name = counter.ToString();
                        //f.Controls[counter].Name = ("TB:"+i.ToString()+":"+j.ToString());
                        cellsMatrix[i][j].setsisj(i,j);
                        counter++;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new textboxmatrix(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.cellsMatrix[currenti][currentj].setValue(this.textBox1.Text);
            this.Controls[t.cellsMatrix[currenti][currentj].Name].Text = t.cellsMatrix[currenti][currentj].value;
            this.Controls[t.cellsMatrix[currenti][currentj].Name].Text = this.textBox1.Text;


        }
    }
}
