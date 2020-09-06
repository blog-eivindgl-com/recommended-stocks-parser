using System.Collections.Generic;
using System.IO;
using System.Text;
using DNBMarketsAAParser.Model;

namespace DNBMarketsAAParser.Services
{
    public class PdfReader : IPdfReader
    {
        public IEnumerable<StockAdvice> ReadStockAdvice(FileInfo file)
        {
            var stockAdvices = new List<StockAdvice>();
            var reader = new iText.Kernel.Pdf.PdfReader(file);
            var doc = new iText.Kernel.Pdf.PdfDocument(reader);
            var pageCount = doc.GetNumberOfPages();

            if (pageCount > 0)
            {
                for (int pageNum = 1; pageNum < pageCount; pageNum++)
                {
                    var page = doc.GetPage(pageNum);
                    var pageData = page.GetContentBytes();
                    string pageContent = Encoding.UTF8.GetString(pageData);
                    var folder = file.Directory;
                    var fileName = Path.Combine(folder.FullName, file.Name + "_Page_" + pageNum + ".txt");
                    WritePageContentToFile(fileName, pageContent);
                }
            }

            doc.Close();
            reader.Close();

            return stockAdvices;
        }

        public void WritePageContentToFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }
    }
}