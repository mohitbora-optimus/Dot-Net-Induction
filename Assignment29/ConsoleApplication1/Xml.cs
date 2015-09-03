using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    public class Xml
    {
        private string _fileName;
        private string _name;
        private int _age;
        private string _address;

        public Xml(string file)
        {
            _fileName = file;
        }

        public void CreateXml()
        {
            XmlTextWriter textWriter = new XmlTextWriter(_fileName, Encoding.UTF8);

            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("ROOT");
            textWriter.WriteStartElement("Student");

            textWriter.WriteElementString("Name", "AJAY");
            textWriter.WriteElementString("Age", "15");
            textWriter.WriteElementString("Branch", "CSE");

            textWriter.WriteStartElement("Address");
            textWriter.WriteElementString("City", "delhi");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();


            textWriter.WriteStartElement("Student");

            textWriter.WriteElementString("Name", "Vijaty");
            textWriter.WriteElementString("Age", "15");
            textWriter.WriteElementString("Branch", "PCM");

            textWriter.WriteStartElement("Address");
            textWriter.WriteElementString("City", "MUMBAI");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        public void navigatingXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_fileName);
            XmlNode root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//ROOT/Student");

            foreach (XmlNode node in nodes)
            {
                XmlNode name = node.SelectSingleNode("Name");
                XmlNode age = node.SelectSingleNode("Age");
                XmlNode branch = node.SelectSingleNode("Branch");
                Console.WriteLine("Name : {0} \n  Age : {1} \n Branch: {2}", name.InnerText, age.InnerText, branch.InnerText);
            }
            Console.ReadKey();

        }

        public void AppendingChild()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_fileName);

            XmlNode root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/ROOT/Student");
            XmlElement College = doc.CreateElement("College");
            College.InnerText = "Engineering";


            foreach(XmlNode node in nodes)
            {
                XmlNode branch = node.SelectSingleNode("Branch");

                if (branch.InnerText.CompareTo("PCM") == 0)
                {
                    node.InsertAfter(College,branch);
                   
                }
            }
            doc.Save(_fileName);
        }
    }
}
