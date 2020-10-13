using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1DynamicHelp;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;

namespace C1.Win.C1DynamicHelp.Providers
{
    /// <summary>
    /// The class providing the <see cref="IHelpProvider"/> functionality for ComponentOne NetHelp.
    /// </summary>
    public class NetHelpProvider : IHelpProvider
    {
        #region ** const
        private const string ProjectInfoDirectory = "ProjectInfo";
        private const string TopicsFile = "topics.xnh";
        private const string TocFile = "toc.xnh";
        private const string ContextIdsElement = "contextids";
        private const string UrlAttribute = "url";
        private const string TopicIdAttribute = "id";
        #endregion

        #region ** fields
        private string _directory; 
        private string _source = "";
        private HelpTopicList _topics = new HelpTopicList();
        private Dictionary<int, HelpTopic> _ctxIdMap = new Dictionary<int, HelpTopic>();
        private Dictionary<string, HelpTopic> _urlMap = new Dictionary<string, HelpTopic>();
        #endregion

        #region ** object model

        /// <summary>
        /// Gets or sets the help file.
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
                if (File.Exists(value))
                    _directory = Path.GetDirectoryName(value);
                else if (Directory.Exists(value))
                    _directory = value;
                else
                    _directory = null;
                _source = value;
                ReadHelpFile();
            }
        }

        /// <summary>
        /// Returns a hierarchical list of topics in the help file.
        /// </summary>
        /// <returns></returns>
        public HelpTopicList GetTopics()
        {
            return _topics;
        }

        /// <summary>
        /// Returns a dictionary of help topics indexed by their context IDs 
        /// (contains only topics that have context ids).
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, HelpTopic> GetCtxtIdMap()
        {
            return _ctxIdMap;
        }

        /// <summary>
        /// Returns a dictionary of help topics indexed by their URLs (contains all topics).
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, HelpTopic> GetUrlMap()
        {
            return _urlMap;
        }

        /// <summary>
        /// Returns a URL in a specific for the help provider format that can be displayed by the C1DynamicHelp control.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetFullUrl(string url)
        {
            if (url.StartsWith("#"))
            {
                try
                {
                    int ctxtId = int.Parse(url.Substring(1));
                    url = _ctxIdMap[ctxtId].Url;
                }
                catch
                {
                }
            }
            if (string.IsNullOrEmpty(_directory))
                return "";
            if (Directory.Exists(_directory))
            {
                url = Path.Combine(_directory, url.Replace("/", "\\")) + "?csh=1";
                Uri uri = new Uri(url);
                return uri.ToString();
            }
            return "";
        }

        /// <summary>
        /// Show help navigation (in a separate window).
        /// </summary>
        /// <param name="tab">Initial help page to display, typically <b>HelpTab.Find</b>, 
        /// <b>HelpTab.Index</b>, or <b>HelpTab.TableOfContents</b>.</param>
        public void ShowExternalHelp(HelpTab tab)
        {
            ShowExternalHelp(tab, null);
        }
        /// <summary>
        /// Show help navigation (in a separate window).
        /// </summary>
        /// <param name="tab">Initial help page to display, typically <b>HelpTab.Find</b>, 
        /// <b>HelpTab.Index</b>, or <b>HelpTab.TableOfContents</b>.</param>
        /// <param name="parameter">Topic identifier</param>
        public void ShowExternalHelp(HelpTab tab, object parameter)
        {
            string strtab = "";
            if (tab == HelpTab.TableOfContents)
                strtab = "0";
            else if (tab == HelpTab.Index)
                strtab = "1";
            else if (tab == HelpTab.Find)
                strtab = "2";
            if (tab == HelpTab.Topic && parameter is string)
            {
                Uri uri = new Uri(_source);
                string url = GetTempHtmlFile(uri.ToString() + "?turl=" + parameter.ToString());
                Process.Start(url);
            }
            else if (string.IsNullOrEmpty(strtab))
                Process.Start(_source);
            else
            {
                Uri uri = new Uri(_source);
                string tmp = GetTempHtmlFile(uri.ToString() + "?tab=" + strtab);
                Process.Start(tmp);
            }
        }

        /// <summary>
        /// This method is not meaningful for the NetHelpProvider. It is used only to implement the <see cref="IHelpProvider"/> interface.
        /// </summary>
        /// <param name="url">Url to be checked and corrected</param>
        /// <returns>Always the initial url</returns>
        public string CorrectUrl(string url)
        {
            return url;
        }
        #endregion

        #region ** private stuff
        private void ParseTopics(XmlDocument doc)
        {
            XmlElement root = doc.DocumentElement;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                XmlElement topic = root.ChildNodes[i] as XmlElement;
                if (topic != null)
                {
                    string url = GetUrl(topic);
                    if (!string.IsNullOrEmpty(url))
                    {
                        if (!_urlMap.ContainsKey(url))
                            _urlMap[url] = new HelpTopic(GetTitle(topic), url);
                        HelpTopic helpTopic = _urlMap[url];
                        XmlElement contextIds = topic[ContextIdsElement];
                        if (contextIds != null)
                        {
                            int ctxId = ParseContextIds(contextIds, helpTopic);
                            if (ctxId != -1)
                                helpTopic.SetCtxtId(ctxId);
                        }
                    }
                }
            }
        }

        private int ParseContextIds(XmlElement context, HelpTopic helpTopic)
        {
            int ctxId = -1;
            for (int i = 0; i < context.ChildNodes.Count; i++)
            {
                if (context.ChildNodes[i].Name == "item" && context.ChildNodes[i].Attributes[TopicIdAttribute] != null)
                {
                    int id;
                    if (int.TryParse(context.ChildNodes[i].Attributes[TopicIdAttribute].InnerText, out id))
                    {
                        _ctxIdMap[id] = helpTopic;
                        if (ctxId == -1)
                            ctxId = id;
                    }
                }
            }
            return ctxId;
        }

        private string GetTitle(XmlElement item)
        {
            for (int i = 0; i < item.ChildNodes.Count; i++)
                if (item.ChildNodes[i].NodeType == XmlNodeType.CDATA)
                    return item.ChildNodes[i].InnerText;
            return "";
        }

        private string GetUrl(XmlElement item)
        {
            return item.Attributes[UrlAttribute] != null ? item.Attributes[UrlAttribute].InnerText : "";
        }

        private HelpTopic ParseTopic(XmlElement item)
        {
            string url = GetUrl(item);
            string title = GetTitle(item);
            HelpTopicList list = null;
            if (item.ChildNodes.Count > 1)
                list = new HelpTopicList();
            HelpTopic helpTopic = new HelpTopic(title, url, list);
            _urlMap[url] = helpTopic;
            return helpTopic;
        }

        private void ParseToc(HelpTopic helpTopic, XmlElement item)
        {
            for (int i = 0; i < item.ChildNodes.Count; i++)
            {
                if (item.ChildNodes[i].NodeType == XmlNodeType.Element)
                {
                    XmlElement topic = (XmlElement)item.ChildNodes[i];
                    HelpTopic sub = ParseTopic(topic);
                    helpTopic.SubTopics.Add(sub);
                    ParseToc(sub, topic);
                }
            }
        }

        private static string GetTempHtmlFile(string url)
        {
            string strTempPath = Path.GetTempPath();
            string tmpFile = Path.Combine(strTempPath, "_d2h_exw_starttab.htm");
            StreamWriter w = File.CreateText(tmpFile);
            w.WriteLine("<html><script language=\"javascript\">\n<!--");
            w.WriteLine("var topicPage = \"" + url + "\";");
            w.WriteLine("function isOpera() { var strUserAgent = navigator.userAgent.toLowerCase(); return ((strUserAgent.indexOf(\"opera\") == -1) ? false : true);}");
            w.WriteLine("if (location.replace && !isOpera()) location.replace(topicPage); else location.href = topicPage;");
            w.Write("//-->\n</script></html>");
            w.Close();
            return tmpFile;
        }

        private void ReadHelpFile()
        {
            if (_directory == null)
                return;
            string projectPath = Path.Combine(_directory, ProjectInfoDirectory);
            _topics.Clear();
            _urlMap.Clear();
            _ctxIdMap.Clear();
            if (Directory.Exists(projectPath))
            {
                string toc = Path.Combine(projectPath, TocFile);
                string topics = Path.Combine(projectPath, TopicsFile);
                XmlDocument doc = new XmlDocument();
                doc.Load(toc);
                _topics = new HelpTopicList();
                for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++)
                    if (doc.DocumentElement.ChildNodes[i] is XmlElement)
                    {
                        XmlElement item = (XmlElement)doc.DocumentElement.ChildNodes[i];
                        HelpTopic helpTopic = ParseTopic(item);
                        _topics.Add(helpTopic);
                        ParseToc(helpTopic, item);
                    }

                doc.Load(topics);
                ParseTopics(doc);
            }
        } 
        #endregion
    }
}
