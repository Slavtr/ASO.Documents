using Microsoft.Office.Interop.Word;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace ASO.Documents
{
    public class WordDocument : IDisposable
    {
        private Application _app;
        public WordDocument()
        {
            _app = new Application();
        }
        public void CreateDocument(object document, string templatePath, string documentPath, bool isOpen = true)
        {
            if (document != null)
            {
                Document doc = _app.Documents.Open(templatePath);
                foreach(PropertyInfo i in document.GetType().GetProperties())
                {
                    foreach (Bookmark b in doc.Bookmarks)
                    {
                        if (b.Name == i.Name)
                        {
                            b.Range.Text = i.GetValue(document, null).ToString();
                        }
                    }
                }
                if (isOpen)
                {
                    doc.SaveAs2(documentPath, WdSaveFormat.wdFormatDocumentDefault);
                    _app.Visible = true;
                }
                else
                {
                    doc.SaveAs2(documentPath, WdSaveFormat.wdFormatDocumentDefault);
                }
            }
        }
        public void Dispose()
        {
            if(_app.ActiveDocument != null) _app.ActiveDocument.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_app);
        }
    }
}