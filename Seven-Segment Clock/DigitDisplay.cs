using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seven_Segment_Clock
{
    public partial class DigitDisplay : UserControl
    {
        char firstDigit;
        char secondDigit;
        public DigitDisplay(char firstDigitTemp, char secondDigitTemp)
        {
            InitializeComponent();
            firstDigit = firstDigitTemp;
            secondDigit = secondDigitTemp;
            this.Load += new EventHandler(this.DigitDisplay_Load);
        }
        public DigitDisplay()
        {
            InitializeComponent();
        }
        private void ResetColor()
        {
            //First digit
            picSegmentA1.BackColor = Main.DefaultBackColor;
            picSegmentB1.BackColor = Main.DefaultBackColor;
            picSegmentC1.BackColor = Main.DefaultBackColor;
            picSegmentD1.BackColor = Main.DefaultBackColor;
            picSegmentE1.BackColor = Main.DefaultBackColor;
            picSegmentF1.BackColor = Main.DefaultBackColor;
            picSegmentG1.BackColor = Main.DefaultBackColor;
            //Second digit
            picSegmentA2.BackColor = Main.DefaultBackColor;
            picSegmentB2.BackColor = Main.DefaultBackColor;
            picSegmentC2.BackColor = Main.DefaultBackColor;
            picSegmentD2.BackColor = Main.DefaultBackColor;
            picSegmentE2.BackColor = Main.DefaultBackColor;
            picSegmentF2.BackColor = Main.DefaultBackColor;
            picSegmentG2.BackColor = Main.DefaultBackColor;
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
        {
            ;
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

        private void DigitDisplay_Load(object sender, EventArgs e)
        {
            ResetColor();
            DrawFirstDigit(firstDigit);
            DrawSecondDigit(secondDigit);
        }
        protected override void OnLoad(EventArgs e)
        {
            ResetColor();
            DrawFirstDigit(firstDigit);
            DrawSecondDigit(secondDigit);
            base.OnLoad(e);
        }
    }
}
