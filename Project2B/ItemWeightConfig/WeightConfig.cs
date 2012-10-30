using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Project2B
{
    public class WeightConfig
    {
        
            //please copy this to a neutral location and change the configuration location
            private string _filename = @"C:\ItemWeightConfig.xml";
            private int _defaultweight;
            private int _configweight;
			
			/// <summary>
			/// Constructor
			/// </summary>
            public WeightConfig()
            {
                Config();

            }
			/// <summary>
            /// Gets the Deafult Item Weight
			/// </summary>
            public int DefaultWeight
            {
                get { return _defaultweight; }
            }
			/// <summary>
			/// Gets the Configurable Item Weight
			/// </summary>
            public int ConfigWeight
            {
                get { return _configweight; }
            }
			
			
			
			/// <summary>
			/// Reads from XML, Parses and Sets
			/// </summary>
            private void Config()
            {
                   XmlDocument doc = new XmlDocument();
                   doc.Load(_filename);
                   XmlNodeList bookList = doc.DocumentElement.ChildNodes;


                   foreach (XmlNode node in bookList)
                   {
                       XmlElement bookElement = (XmlElement) node;
                       

                       if (bookElement != null)
                       {
                           if (node.Name.Equals("ConfigWeight"))
                           {
                               _configweight = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                           if (node.Name.Equals("DefaultWeight"))
                           {
                               _defaultweight = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                           
                   
                       }
                   }


               }
 
    }
}
