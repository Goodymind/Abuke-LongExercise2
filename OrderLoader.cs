using Abuke_LongExercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Abuke_LongExercise2
{
    internal class OrderLoader
    {
        private XmlDocument doc;
        private XmlElement root;
        private string path;

        public int CurrentID = 0;
        public OrderLoader(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                createXmlFile();
            }
            else
            {
                doc = new XmlDocument();
                doc.Load(path);

            }

            root = doc.DocumentElement;
            if (root == null)
                createXmlFile();
            else if (root.Name != "Orders")
                createXmlFile();
            else
            {
                var orders = root.ChildNodes;
                foreach (XmlNode orderNode in orders)
                {
                    var currentIdNode = orderNode["Id"];
                    int currentId = int.Parse(currentIdNode.InnerText);
                    CurrentID = CurrentID < currentId ? currentId : CurrentID;
                }
                CurrentID++;
            }

            doc.Save(path);
        }

        private void createXmlFile() 
        {
            doc = new XmlDocument();
            root = doc.CreateElement("Orders");
            doc.AppendChild(root);
        }

        public void addOrder(Order order) 
        {
            var orderElement = doc.CreateElement("Order");
            var orderId = doc.CreateElement("Id");
            var items = doc.CreateElement("Items");

            orderId.InnerText = CurrentID.ToString();

            orderElement.AppendChild(orderId);
            orderElement.AppendChild(items);

            foreach (Item item in order.Items)
            { 
                var itemElement = doc.CreateElement("Item");

                var itemDescription = doc.CreateElement("Description");
                var itemCost = doc.CreateElement("Cost");

                itemDescription.InnerText = item.ToString();
                itemCost.InnerText = item.Cost.ToString();

                itemElement.AppendChild(itemDescription);
                itemElement.AppendChild(itemCost);
                items.AppendChild(itemElement);
            }

            root.AppendChild(orderElement);
            CurrentID++;
            doc.Save(path);
        }

        public XmlNode getOrder(int order_no)
        {
            var orders = root.ChildNodes;
            foreach (XmlNode orderNode in orders)
            {
                var currentIdNode = orderNode["Id"];
                int currentId = int.Parse(currentIdNode.InnerText);
                if (currentId == order_no)
                    return orderNode;
            }

            return null;
        }
    }
}
