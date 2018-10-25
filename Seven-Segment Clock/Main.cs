using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seven_Segment_Clock
{
    public partial class Main : Form
    {
        Timer clockTimer = new Timer();
        public Main()
        {
            InitializeComponent();
        }

        private void ResetColor()
        {
            //First digit
            picSegmentA1.BackColor = ActiveControl.BackColor;
            picSegmentB1.BackColor = ActiveControl.BackColor;
            picSegmentC1.BackColor = ActiveControl.BackColor;
            picSegmentD1.BackColor = ActiveControl.BackColor;
            picSegmentE1.BackColor = ActiveControl.BackColor;
            picSegmentF1.BackColor = ActiveControl.BackColor;
            picSegmentG1.BackColor = ActiveControl.BackColor;
            //Second digit
            picSegmentA2.BackColor = ActiveControl.BackColor;
            picSegmentB2.BackColor = ActiveControl.BackColor;
            picSegmentC2.BackColor = ActiveControl.BackColor;
            picSegmentD2.BackColor = ActiveControl.BackColor;
            picSegmentE2.BackColor = ActiveControl.BackColor;
            picSegmentF2.BackColor = ActiveControl.BackColor;
            picSegmentG2.BackColor = ActiveControl.BackColor;
        }
        private void DrawSecondDigit(char digit)
        {
            switch (digit)
            {
                case '0':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    picSegmentE2.BackColor = Color.Red;
                    picSegmentF2.BackColor = Color.Red;
                    break;
                case '1':
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    break;
                case '2':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    picSegmentE2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    break;
                case '3':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    break;
                case '4':
                    picSegmentF2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    break;
                case '5':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentF2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    break;
                case '6':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentF2.BackColor = Color.Red;
                    picSegmentE2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    break;
                case '7':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    break;
                case '8':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    picSegmentE2.BackColor = Color.Red;
                    picSegmentF2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    break;
                case '9':
                    picSegmentA2.BackColor = Color.Red;
                    picSegmentB2.BackColor = Color.Red;
                    picSegmentC2.BackColor = Color.Red;
                    picSegmentD2.BackColor = Color.Red;
                    picSegmentF2.BackColor = Color.Red;
                    picSegmentG2.BackColor = Color.Red;
                    break;
            }
        }
        private void DrawFirstDigit(char digit)
        {;
            switch (digit)
            {
                case '0':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    picSegmentE1.BackColor = Color.Red;
                    picSegmentF1.BackColor = Color.Red;
                    break;
                case '1':
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    break;
                case '2':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    picSegmentE1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    break;
                case '3':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    break;
                case '4':
                    picSegmentF1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    break;
                case '5':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentF1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    break;
                case '6':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentF1.BackColor = Color.Red;
                    picSegmentE1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    break;
                case '7':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    break;
                case '8':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    picSegmentE1.BackColor = Color.Red;
                    picSegmentF1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    break;
                case '9':
                    picSegmentA1.BackColor = Color.Red;
                    picSegmentB1.BackColor = Color.Red;
                    picSegmentC1.BackColor = Color.Red;
                    picSegmentD1.BackColor = Color.Red;
                    picSegmentF1.BackColor = Color.Red;
                    picSegmentG1.BackColor = Color.Red;
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            clockTimer.Interval = 1000;
            clockTimer.Tick += new EventHandler(this.clockTimer_Tick);
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            ResetColor();

            int clockSeconds = DateTime.Now.Second;
            string clockSecondsString = clockSeconds.ToString();
            char num0 = '0';
            char onlyDigit;
            char firstDigit;
            char secondDigit;

            if(clockSeconds < 10)
            {
                onlyDigit = clockSecondsString[0];
                DrawFirstDigit(num0);
                DrawSecondDigit(onlyDigit);
            }
            if (clockSeconds > 9)
            {
                firstDigit = clockSecondsString[0];
                secondDigit = clockSecondsString[1];
                DrawFirstDigit(firstDigit);
                DrawSecondDigit(secondDigit);
            }
        }
    }
}
