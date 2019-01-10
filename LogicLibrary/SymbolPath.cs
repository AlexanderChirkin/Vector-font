using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    /// <summary>
    /// Представляет собой символ и путь к файлу, в который этот символ записан.
    /// Используется для чтения\записи алфавита в файл
    /// </summary>
    public class SymbolPath
    {
        public char Symbol { get; set; }
        public string Path { get; set; }

        public SymbolPath(string lineFromFile)
        {
            this.Symbol = lineFromFile[0];
            this.Path = lineFromFile.Substring(2);
        }

        public SymbolPath(char c, string path)
        {
            this.Symbol = c;
            this.Path = path;
        }
    }
}
