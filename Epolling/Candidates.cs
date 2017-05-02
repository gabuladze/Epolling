using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Epolling
{
    class Candidates
    {
        public static List<string> Load()
        {
            List<string> candidatesList = new List<string>();
            XmlDocument candidates = new XmlDocument();
            candidates.Load("Candidates.xml");

            foreach (XmlNode node in candidates.DocumentElement)
            {
                candidatesList.Add(node.Attributes[1].InnerText);
            }

            return candidatesList;
        }
    }
}
