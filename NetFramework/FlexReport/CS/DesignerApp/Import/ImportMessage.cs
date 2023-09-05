//----------------------------------------------------------------------------
// ImportMessage.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace FlexReportDesignerApp.Util
{
    internal enum ImportMessageType
    {
        Information = 0,
        Warning = 1,
        Error = 2,
    }

    internal class ImportMessage
    {
        private ImportMessageType _type;
        private string _text;

        #region Constructors
        public ImportMessage(
            ImportMessageType type,
            string text)
        {
            _type = type;
            _text = text;
        }
        #endregion

        #region Public properties
        public ImportMessageType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        #endregion
    }

    internal class ImportMessages : List<ImportMessage>
    {
        #region Public
        public ImportMessage Add(
            ImportMessageType type,
            string text)
        {
            ImportMessage result = new ImportMessage(type, text);
            this.Add(result);
            return result;
        }

        public void Save(
            string fileName)
        {
            if (Count <= 0)
                return;

            XmlDocument doc = new XmlDocument();
            XmlElement messagesElement = (XmlElement)doc.AppendChild(doc.CreateElement("Messages"));
            foreach (ImportMessage im in this)
            {
                XmlElement messageElement = (XmlElement)messagesElement.AppendChild(doc.CreateElement("Message"));
                messageElement.Attributes.Append(doc.CreateAttribute("type")).Value = im.Type.ToString();
                messageElement.InnerText = im.Text;
            }
            doc.Save(fileName);
        }

        public void Load(
            string fileName)
        {
            Clear();
            if (!File.Exists(fileName))
                return;

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList nodes = doc.SelectNodes("Messages/Message");
            foreach (XmlNode xn in nodes)
                Add((ImportMessageType)Enum.Parse(typeof(ImportMessageType), xn.Attributes[0].Value), xn.InnerText);
        }
        #endregion
    }

    /// <summary>
    /// Error codes returned by Import() method in C1FlexCRI**.dll modules.
    /// </summary>
    internal static class CrystalImportErrorCodes
    {
        public const int NoSuchError = -1; // this code is NEVER returned by the import module
        public const int Success = 0;
        public const int BadArguments = 1;
        public const int GeneralError = 2;
        public const int ErrorSavingMessages = 3;
        public const int CrystalNotInstalled = 4;
        public const int RASNotAvailable = 101;
    }
}
