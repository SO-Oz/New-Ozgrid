using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using VBA = Microsoft.VisualBasic;
using Regex = System.Text.RegularExpressions.Regex;

namespace Ozgrid
{
    [ComVisible(true)]
    public class OzgridRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public OzgridRibbon()
        {
        }

        public void ScrambleWorkbook(Office.IRibbonControl control)
        {          
            string msg = "Would you like to exclude any ranges from this process?";
            
            if (MessageBox.Show(msg, "Sanitize Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Set initial range here.
                if (MessageBox.Show("Add more cells?", "Sanitize Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // New range = Union(initRange, new Range)
                }
            }
        }

        private void Scramble(Excel.Range cell)
        {
            string cellType;

            cellType = VBA.Information.TypeName(cell.Value);
            MessageBox.Show(cellType);
        }
        public void CreateUploadableWorkbook(Office.IRibbonControl control)
        {
            
            if (Globals.ThisAddIn.Application.Workbooks.Count == 1)
            {
                
            }
            WorkbookList wbForm = new WorkbookList();
            var workbookNames = new List<string> { };

            foreach (Excel.Workbook wb in Globals.ThisAddIn.Application.Workbooks)
            {
                workbookNames.Add(wb.Name);
            }

            wbForm.lbWorkbooks.DataSource = workbookNames.ToArray();

            wbForm.Show();        
        }

        public void CheckWorkbookForUpload(Office.IRibbonControl control)
        {   
            // required variables
            Excel.Workbook checkBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            FileInfo checkBookLen = new FileInfo(checkBook.FullName);
            string output = "";
            long maxFileSize = 100000;
            long actualFileSize;

            try
            {
                actualFileSize = checkBookLen.Length;
            } 
            catch(Exception e)
            {
                Console.WriteLine("Exception Found:\n\t{0}", e.Message);
                actualFileSize = 0;
            }

            if (actualFileSize > 0 && actualFileSize <= maxFileSize)
            {
                output += "File Size:\tOK\r\n";
            }


        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("Ozgrid.Ribbon1.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
