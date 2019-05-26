/// <copyright file="Printer.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// Printer class used to write data to a file
/// </summary>

#region using

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace LibPrinter
{
    public class Printer
    {
        #region Public Fields

        private string _fileName;
        private StreamWriter _fileWriter;

        #endregion

        #region Public Methods

        /// <function>Printer</function>
        /// <param name="fileName">The name of the file</param>
        /// <summary>Constructor of the class used to add the file name</summary>
        public Printer(string fileName)
        {
            _fileName = fileName;
        }

        /// <function>OpenFile</function>
        /// <summary>Open a file or create one</summary>
        public bool OpenFile()
        {
            try
            {
                _fileWriter = new StreamWriter(_fileName);
                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                return false;
            }
        }

        /// <function>CloseFile</function>
        /// <summary>Close the opened file</summary>
        public void CloseFile()
        {
            // close the file
            _fileWriter.Close();
        }

        /// <function>Write</function>
        /// <param name="text">The text to be written to file</param>
        /// <summary>Write the text to the file</summary>
        public void Write(string text)
        {
            _fileWriter.Write(text);
        }

        /// <function>Write</function>
        /// <param name="text">The text to be written to file</param>
        /// <summary>Write the text to the file and add '/n' character</summary>
        public void Writeln(string text)
        {
            _fileWriter.WriteLine(text);
        }

        #endregion
    }
}
