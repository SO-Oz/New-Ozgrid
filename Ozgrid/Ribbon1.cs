using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ozgrid
{
    [ComVisible(true)]
    public class OzgridRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public OzgridRibbon()
        {
        }

        public void CreateUploadableWorkbook(Office.IRibbonControl control)
        {
            //System.Windows.Forms.MessageBox.Show("Button pressed");

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

        public void InitializeUDFWorkbook(Office.IRibbonControl control)
        {
            // XLA LOCATION:
            string fileLoc = Environment.ExpandEnvironmentVariables("%APPDATA%") + "\\Microsoft\\AddIns\\UDF.xlam";

            try
            {
                Globals.ThisAddIn.Application.ScreenUpdating = false;
                Excel.Workbook UDFWorkbook = Globals.ThisAddIn.Application.Workbooks.Open(fileLoc);
                //UDFWorkbook.Windows[1].Visible = false;
                //UDFWorkbook.Saved = true;
                System.Windows.Forms.MessageBox.Show("UDFs initialized successfully!","Ozgrid",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);

            }
            catch (Exception fail)
            {
                // Debug purposes, remove after testing:
                    System.Windows.Forms.MessageBox.Show(fail.ToString());
            }
            finally
            {
                Globals.ThisAddIn.Application.ScreenUpdating = true;

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
