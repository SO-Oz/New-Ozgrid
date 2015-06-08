using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
//using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;

namespace Ozgrid
{
    public partial class ThisAddIn
    {
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new OzgridRibbon();
        }

        //public int VBAWorkbookSet = 0;
        //public string VBAworkbookName;
        public Excel.Workbook VBA_Workbook;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            VBA_Workbook = Application.Workbooks.Add(missing);
            //VBAWorkbookSet = 1;
            //VBAworkbookName = VBA_Workbook.Name;
            VBA_Workbook.Windows[1].Visible = false;
            try
            {
            VBComponent tempModule = VBA_Workbook.VBProject.VBComponents.Add(vbext_ComponentType.vbext_ct_StdModule);
            
            tempModule.Name = "UDFs";
            
            //test adding a UDF
            UDFstrings.VBA UDFs = new UDFstrings.VBA();

            tempModule.CodeModule.AddFromString(UDFs.testFunction);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("This add-in requires programattic access to the VBProject object model. \n\n" +
                "Please allow access in order to continue using this add-in \n\n" +
                "(ノಠ益ಠ)ノ彡┻━┻");
            }

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            if (VBA_Workbook != null)
            {
                VBA_Workbook.Close(false);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Workbook doesn't exist!");
            }
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
    }
}
