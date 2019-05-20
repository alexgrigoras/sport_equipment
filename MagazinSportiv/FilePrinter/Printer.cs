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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace MagazinSportiv
{
    public class Printer
    {
        #region Public Fields

        private string _fileName;

        #endregion

        #region Public Methods

        /// <function>Printer</function>
        /// <param name="fileName">The name of the file</param>
        /// <summary>Constructor of the class used to add the file name</summary>
        public Printer(string fileName)
        {
            _fileName = fileName;

            OpenFile();
        }

        /// <function>OpenFile</function>
        /// <summary>Open a file or create one</summary>
        private void OpenFile()
        {
            // open the file
        }

        /// <function>CloseFile</function>
        /// <summary>Close the opened file</summary>
        private void CloseFile()
        {
            // close the file
        }

        /// <function>Write</function>
        /// <param name="text">The text to be written to file</param>
        /// <summary>Write the text to the file</summary>
        public void Write(string text)
        {
            // write to file

        }

        /// <function>Write</function>
        /// <param name="text">The text to be written to file</param>
        /// <summary>Write the text to the file and add '/n' character</summary>
        public void Writeln(string text)
        {

        }

        #endregion
    }
}
