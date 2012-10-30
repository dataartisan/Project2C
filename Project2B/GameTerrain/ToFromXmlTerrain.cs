using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.GameTerrain;

//this class reads and writes to the xml file.
namespace Project2B
{
    class ToFromXmlTerrain
    {
		
		///<summary>
		/// Writes the activity to XML
		///</summary>
        public void WriteXML()
        {
            Terrian1 overview = new Terrian1();
            
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Terrian1));

            System.IO.StreamWriter file = new System.IO.StreamWriter(
                @"c:\temp\SerializationOverview.xml");
            writer.Serialize(file, overview);
            file.Close();
        }
	
		///<summary>
		/// Reads the configured value from the XML
		///</summary>
        public ITerrian ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Terrian1));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"c:\temp\SerializationOverview.xml");
            Terrian1 overview = new Terrian1();
            overview = (Terrian1)reader.Deserialize(file);

            return overview;

        }

    
    
    }
}
