using System.Text;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
namespace Lib.Utils
{
    public class CsvDataExporter<T> : IDataExporter<T> where T : IParsable
    {
        private string _csvSeperator;
        private string _newLineSeperator;

        public CsvDataExporter(string csvSeperator = ",", string newLineSeperator = "\n")
        {
            _csvSeperator = csvSeperator;
            _newLineSeperator = newLineSeperator;
        }


        public List<T> Export(string source){
            var csvStr = ReadCsvFile(source);
            var lines = csvStr.Split(_newLineSeperator);
            var results = new List<T>();
            foreach (string line in lines)
            {
                T parsedLine = new T();
                parsedLine = parsedLine.Parse(line.Split(_csvSeperator));    
                if(parsedLine != null)
                    results.Add(parsedLine);
            } 
            return results;
        }

        private string ReadCsvFile(string filePath){
            var stringBuilder = new StringBuilder();
            using(StreamReader reader = new StreamReader(filePath));
            while((line = reader.ReadLine()) != null){
                stringBuilder.Append(line);
                stringBuilder.Append(_newLineSeperator);
            }      
            return stringBuilder.ToString();
        }
    }
}