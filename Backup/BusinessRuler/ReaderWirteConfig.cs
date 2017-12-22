using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace BusinessRuler
{
    public class ReaderWirteConfig
    {
        //²Ù×÷ÅäÖÃÎÄ¼þ
        public static void WriteToAppConfig(string theKey, string theValue)
        {
            string[] strs = Application.ExecutablePath.Split('\\');
            XmlDocument xmlDoc = new XmlDocument();
            string xmlFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + strs[strs.Length - 1] + ".Config";
            xmlDoc.Load(xmlFileName);
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlAttribute att = nodes[i].Attributes["key"];
                if (att.Value.Equals(theKey))
                {
                    nodes[i].Attributes["value"].Value = theValue;
                    break;
                }
            }
            xmlDoc.Save(xmlFileName);
        }

        public static string GetValueByKey(string theKey)
        {
            string[] strs = Application.ExecutablePath.Split('\\');
            XmlDocument xmlDoc = new XmlDocument();
            string xmlFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + strs[strs.Length - 1] + ".Config";
            xmlDoc.Load(xmlFileName);
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlAttribute att = nodes[i].Attributes["key"];
                if (att.Value.Equals(theKey))
                {
                    return nodes[i].Attributes["value"].Value;
                }
            }
            return null;
        }
    }
}
