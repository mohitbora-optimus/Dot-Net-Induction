using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace WriterClass
{
    public class WriteOnXml
    {
        string fileName;

        public WriteOnXml(string fileName)
        {
            this.fileName = fileName;
        }

        public void AddStudent( string Name, string Branch, string Grade)
        {
                    XmlTextWriter writer = new XmlTextWriter(fileName, null);
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Records");
                    writer.WriteStartElement("Student");

                    writer.WriteStartElement("Name");
                    writer.WriteString(Name);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Branch");
                    writer.WriteString(Branch);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Grade");
                    writer.WriteString(Grade);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
               
            }
           

        public void AddMoreStudent(string name, string branch, string grade)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlElement element = doc.CreateElement("Student");
            XmlNode attribute = doc.CreateElement("Name");
            attribute.InnerText = name;
            element.AppendChild(attribute);
            attribute = doc.CreateElement("branch");
            attribute.InnerText = branch;
            element.AppendChild(attribute);
            attribute = doc.CreateElement("grade");
            attribute.InnerText = grade;
            element.AppendChild(attribute);
            doc.DocumentElement.AppendChild(element);
            doc.Save(fileName);

            
        }

        public List<string> ShowMCAStudent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            List<string> names = new List<string>();
            XmlNodeList Node = doc.SelectNodes("Records/Student");
            string name;
            foreach (XmlNode node in Node)
            {
                XmlNode Child = node.FirstChild;
                name = Child.InnerText;
                Child = Child.NextSibling;
               
                if (Child.InnerText == "MCA")
                {
                    names.Add(name);
                }
            }
            return names;
        }

        public List<string> ShowDGradeStudent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            List<string> names = new List<string>();

            XmlNodeList nodes = doc.SelectNodes("Records/Student");
            string name;
            foreach (XmlNode node in nodes)
            {
                
                XmlNode child = node.FirstChild;
                name = node.InnerText;
                child = child.NextSibling;
               child = child.NextSibling;
                if (child.InnerText == "D")
                {
                    names.Add(name);
                }
            }
            return names;

        }
    }
}
