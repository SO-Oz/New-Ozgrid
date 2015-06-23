using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Vbe.Interop;

namespace Ozgrid
{
    public class VBAtoUDF
    {
        public string s1;
        public string s2;
        public static bool bInit;

        

        public void ShowRangeToClipboardForm()
        { 

        }

        public void RangeToClipboard(Excel.Range r, Ret iMode = Ret.eVal)
        {
            return;
        }

        public string sText(Excel.Range r)
        {
            return "incomplete!";
        }

        public string Pad(string s, int iLen, Excel.XlHAlign iAlign, string sPad = " ")
        {
            return "Incomplete!";
        }

        private int FormulaType(Excel.Range cell)
        {
            return 0;
        }

        public string Col2Ltrs(long i)
        {
            return "Incomplete!";
        }

    }
}
