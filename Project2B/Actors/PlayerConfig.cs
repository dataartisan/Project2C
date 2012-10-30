using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
//this class gets the configuration from the XML file
namespace Project2B
{
    class PlayerConfig
    {
			//please copy this to a neutral location and change the configuration location
        private string _filename = @"C:\PlayerConfig.xml";
            private int _carryWeight;
            private int _startingHealth;
            private int _movePenalty;
            private int _lives;  
			
			/// <summary>
			/// Constructor
			/// </summary>
            public PlayerConfig()
            {
                Config();

            }
			/// <summary>
			/// Gets Lives
			/// </summary>
            public int Lives
            {
                get { return _lives; }
            }
			/// <summary>
			/// Gets move penalty
			/// </summary>
            public int MovePenalty
            {
                get { return _movePenalty; }
            }
			/// <summary>
			/// Gets starting health
			/// </summary>
            public int StartingHealth
            {
                get { return _startingHealth; }
            }
			/// <summary>
			/// Gets CarryWeight
			/// </summary>

            public int CarryWeight
            {
                get { return _carryWeight; }
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
                           if (node.Name.Equals("EnergyLevel"))
                           {
                               _startingHealth = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                           if (node.Name.Equals("MaxCarryItems"))
                           {
                               _carryWeight = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                           if (node.Name.Equals("Lives"))
                           {
                               _lives = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                           if (node.Name.Equals("MoveEnergyDecrease"))
                           {
                               _movePenalty = int.Parse(bookElement.GetElementsByTagName("Value")[0].InnerText);
                           }
                   
                       }
                   }


               }
    }
}
