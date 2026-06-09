using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kollok
{
    internal class ClassConnector
    {
        public int Price { get; }
        public string ConnectorName { get; }

        public ClassConnector(string name, int price)
        {
            ConnectorName = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ConnectorName} {Price} руб./см";
        }
    }
}
