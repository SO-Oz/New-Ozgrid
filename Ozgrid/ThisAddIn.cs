using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Vbe.Interop;

namespace Ozgrid
{
    public enum Ret { eVal, eA1, eR1 };

    public partial class ThisAddIn
    {   
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new OzgridRibbon();
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
           
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

        internal Ret IIf(System.Windows.Forms.RadioButton optA1, Ret ret1, Ret ret2)
        {
            throw new NotImplementedException();
        }
    }
}
