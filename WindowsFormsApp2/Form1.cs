using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] answers=new string[5];
        void uncheck()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            answers[0] = "0";
            if (radioButton1.Checked == true) { answers[0] = "1"; }
            if (radioButton2.Checked == true) { answers[0] = "2"; }
            if (radioButton3.Checked == true) { answers[0] = "3"; }
            if (radioButton4.Checked == true) { answers[0] = "4"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (checkBox1.Checked == true) { temp+=" 1 "; }
            if (checkBox2.Checked == true) { temp += " 2 "; }
            if (checkBox3.Checked == true) { temp += " 3 "; }
            if (checkBox4.Checked == true) { temp += " 4 "; }
            answers[1] = temp == "" ? "0" : temp; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answers[2] = "0";
            if (radioButton5.Checked == true) { answers[2] = "1"; }
            if (radioButton6.Checked == true) { answers[2] = "2"; }
            if (radioButton7.Checked == true) { answers[2] = "3"; }
            if (radioButton8.Checked == true) { answers[2] = "4"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (checkBox5.Checked == true) { temp += " 1 "; }
            if (checkBox6.Checked == true) { temp += " 2 "; }
            if (checkBox7.Checked == true) { temp += " 3 "; }
            if (checkBox8.Checked == true) { temp += " 4 "; }
            answers[3] = temp == "" ? "0" : temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            answers[4] = "0";
            if (radioButton9.Checked == true) { answers[4] = "1"; }
            if (radioButton10.Checked == true) { answers[4] = "2"; }
            if (radioButton11.Checked == true) { answers[4] = "3"; }
            if (radioButton12.Checked == true) { answers[4] = "4"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (answers[0] == "3") { c++; }
            if (answers[1]==" 2  3 ") { c++; }
            if (answers[2] == "4") { c++; }
            if (answers[3] == " 1  4 ") { c++; }
            if (answers[4] == "1") { c++; }
            for(int i = 0; i < 5; i++) { answers[i] = "0"; }
            uncheck();
            MessageBox.Show($"% правильных ответов :{(10-(10-(c*2)))*10}%");

        }
        Dictionary<string, string> map = new Dictionary<string, string>(){};
        private void button7_Click(object sender, EventArgs e)
        {
            map.Add(textBox1.Text.ToLower(), textBox2.Text.ToLower());
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = "";
            map.TryGetValue(listBox1.SelectedItem.ToString().ToLower(), out temp);
            MessageBox.Show(listBox1.SelectedItem.ToString() + " это " + temp);
        }
    }
}
