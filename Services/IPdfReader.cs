using System.Collections.Generic;
using System.IO;
using DNBMarketsAAParser.Model;

namespace DNBMarketsAAParser.Services
{
    public interface IPdfReader
    {
        IEnumerable<StockAdvice> ReadStockAdvice(FileInfo file);
    }
}