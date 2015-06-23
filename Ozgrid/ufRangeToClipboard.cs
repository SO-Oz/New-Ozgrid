using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Vbe.Interop;



namespace Ozgrid
{
    public partial class ufRangeToClipboard : Form
    {
        public ufRangeToClipboard()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            VBAtoUDF myFuncs = new VBAtoUDF();

            Excel.Application xlApp = Globals.ThisAddIn.Application as Microsoft.Office.Interop.Excel.Application;
            Excel.Range xlSelection = xlApp.Selection as Excel.Range;

            Ret arg2 = Globals.ThisAddIn.IIf(optA1, Ret.eA1, Ret.eR1);

            myFuncs.RangeToClipboard(xlSelection, Globals.ThisAddIn.IIf(optValues, Ret.eVal, arg2));

            Console.Beep(); // note: beep() not supported on x64 architecture


            

        }
    }
}
