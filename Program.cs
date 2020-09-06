using System;
using System.IO;
using DNBMarketsAAParser.Services;

namespace DNBMarketsAAParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parse PDF");
            ParsePdf(@"C:\Users\eivin\OneDrive\Documents\DNB Markets anbefalinger\AA200831.pdf");
        }

        private static void ParsePdf(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            if (!file.Exists) throw new FileNotFoundException("File not found", fileName);
            IPdfReader pdfReader = new PdfReader();
            pdfReader.ReadStockAdvice(file);
        }
        
    }
}
