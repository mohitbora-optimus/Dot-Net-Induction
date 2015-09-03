using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class XmlService
    {
        private string fileName ="XmlFile.xml";

        public static void Main(string[] args)
        {
            XmlService xmlService = new XmlService();

            Xml XmlObject = new Xml(xmlService.fileName);
            XmlObject.CreateXml();

            XmlObject.navigatingXml();

            XmlObject.AppendingChild();
        }
    }
}
