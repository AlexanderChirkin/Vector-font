using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;

namespace LogicLibrary
{
    public class DataFile
    {
        /// <summary>
        /// открывает символ по пути path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Symbol OpenSymbol(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Symbol symbol;
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                 symbol = (Symbol)formatter.Deserialize(fs);
                fs.Close();
            }
            return symbol;
        }

        /// <summary>
        /// сохраняет символ по указанному пути
        /// </summary>
        /// <param name="path"></param>
        /// <param name="symbol"></param>
        public static void SaveSymbol(string path, Symbol symbol)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, symbol);
                fs.Close();
            }
        }

        /// <summary>
        /// получает из файла список объектов SymbolPath
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<SymbolPath> OpenTablePaths(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);
            List<SymbolPath> result = new List<SymbolPath>();
            while (!reader.EndOfStream)
            {
                result.Add(new SymbolPath(reader.ReadLine()));
            }
            reader.Close();
            fs.Close();
            return result;
        }

        /// <summary>
        /// добавляет в файл объект SymbolPath
        /// </summary>
        /// <param name="line"></param>
        /// <param name="path"></param>
        public static void SaveTablePaths(SymbolPath line, string path)
        {
            FileStream fs = new FileStream(path,FileMode.Append);
            StreamWriter writer = new StreamWriter(fs);
            string result = line.Symbol.ToString() + " " + line.Path;
            writer.WriteLine(result);
            writer.Close();
            fs.Close();
        }
    }
}
