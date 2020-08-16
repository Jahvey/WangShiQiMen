using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using waDemo01.utils;


namespace waDemo01
{
    public partial class Form1 : Form
    {
        private String messageInfoBoxStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //首先初始化界面 右边一些基础属性信息
            InitQiMengPan initQiMengPan = new InitQiMengPan();
            DateTime dt = DateTime.Now.ToLocalTime();
            Dictionary<String,String> disc = initQiMengPan.initQiMengPage(dt);
            this.jieqi1.Text = disc["上一个节气"];
            this.jieqi2.Text = disc["下一个节气"];

            this.gonglilabel.Text = disc["阳历"];
            this.ganzhilabel.Text = disc["干支"]+disc["干支历时辰"] +"时";
            this.xunshoulabel.Text =disc["旬首"] ;
            this.xunkonglabel.Text = disc["旬空"];


        }

        private void absolutely_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           String fileName= @"../../keying/克应速查.txt";
            StreamReader sr = new StreamReader(fileName, Encoding.Default);
            StringBuilder sb = new StringBuilder();
            String line;
            while ((line = sr.ReadLine()) != null) {
                sb.Append(line.ToString()+"\n");
              
            }
            //RichTextBox richbox = new RichTextBox();
            // richbox.AppendText("王氏奇门遁甲排盘 \n by.三丰道人 QQ;2807867265\n");
            // richbox.Visible = true;
            // richbox.Show();
            keying.AppendText("王氏奇门遁甲排盘 \n by.三丰道人 QQ;2807867265\n" + sb.ToString());
            keying.Focus();
            keying.Multiline = true;   //将Multiline属性设为true，实现显示多行
            keying.ScrollBars = RichTextBoxScrollBars.Vertical;   //设置ScrollBars属性实现只显示垂直滚动条

           // MessageBox.Show("王氏奇门遁甲排盘 \n by.三丰道人 QQ;2807867265\n"+sb.ToString(),"王氏奇门遁甲", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void QimengCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("奇门局已复制到剪切板，可以愉快的去粘贴分享了！！");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "4";
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "9";
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            
            MessageInfoBox.Text = messageInfoBoxStr;

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "2";

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "3";
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "5";
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "7";
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "8";
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "1";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            messageInfoBoxStr = MessageInfoBox.Text;
            MessageInfoBox.Text = "6";
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            MessageInfoBox.Text = messageInfoBoxStr;
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prev");
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("next");
        }
    }
}
