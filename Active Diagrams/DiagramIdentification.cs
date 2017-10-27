using System;
using System.Globalization;
using System.Xml;

namespace Active_Diagrams
{
    /// <summary>
    /// Class DiagramIdentification represents metadata that are stored with 
    /// the image (diagram) within the document. Metadata are in 
    /// AlternativeText property of the linked image.
    /// </summary>
    public class DiagramIdentification
    {
        private static string IdentificationOfVersion1 = "ActiveDiagrams;Version=1.0;GUID=";
        private static string IdentificationOfVersion2 = "ActiveDiagrams;Version=2.0;XML=";
        private static string IdentificationOfVersion2End = "</DiagramIdentification>";
        private static int GUIDLength = "{268B0FB1-69AB-4270-84D1-EF9306B19669}".Length;
        private static string DiagramIdentificationDateFormat = "yyyyMMddHHmmss";

        private int vVersion;
        private string vGUID;
        private string vAuthor;
        private string vType;
        private string vName;
        private string vStereotype;
        private DateTime vEAModifiedDate;
        private DateTime vEACreatedDate;
        private DateTime vWordModifiedDate;
        private DateTime vWordCreatedDate;

        public int Version { get { return vVersion; } }
        public string GUID { get { return vGUID; } }
        public string Author { get { return vAuthor; } }
        public string Type { get { return vType; } }
        public string Name { get { return vName; } }
        public string Stereotype { get { return vStereotype; } }
        public DateTime EACreatedDate { get { return vEACreatedDate; } }
        public DateTime EAModifiedDate { get { return vEAModifiedDate; } }
        public DateTime WordCreatedDate { get { return vWordCreatedDate; } }
        public DateTime WordModifiedDate { get { return vWordModifiedDate; } set { vWordModifiedDate = value; } }

        public DiagramIdentification(string Identification)
        {
            ParseIdentification(Identification);
        }

        public DiagramIdentification(EADiagram Diagram, DateTime WordCreatedDate, DateTime WordModifiedDate)
        {
            ClearValues();
            vGUID = Diagram.GUID;
            SetValues(Diagram);
            vWordCreatedDate = WordCreatedDate;
            vWordModifiedDate = WordModifiedDate;
        }

        /// <summary>
        /// Resets all data in properties.
        /// </summary>
        private void ClearValues()
        {
            vVersion = 0;
            vGUID = "";
            vAuthor = "";
            vType = "";
            vName = "";
            vStereotype = "";
            vEACreatedDate = DateTime.MinValue;
            vEAModifiedDate = DateTime.MinValue;
            vWordCreatedDate = DateTime.MinValue;
            vWordModifiedDate = DateTime.MinValue;
        }

        public void SetValues(EADiagram Diagram)
        {
            vAuthor = Diagram.Author;
            vType = Diagram.Type;
            vName = Diagram.Name;
            vStereotype = Diagram.Stereotype;
            vEACreatedDate = Diagram.CreatedAt;
            vEAModifiedDate = Diagram.ModifiedAt;
        }

        /// <summary>
        /// Returns true if the string corresponds to the diagram identification.
        /// </summary>
        /// <param name="DiagramIdentification">Any string.</param>
        /// <returns>true if the string corresponds to diagram identification</returns>
        static public bool IsDiagramIdentification(string DiagramIdentification)
        {
            if (string.IsNullOrWhiteSpace(DiagramIdentification)) return false;

            return   
            (
                
            (
                (DiagramIdentification.StartsWith(IdentificationOfVersion1)) && (DiagramIdentification.Length == IdentificationOfVersion1.Length + GUIDLength))
                ||
                ((DiagramIdentification.StartsWith(IdentificationOfVersion2)) && (DiagramIdentification.EndsWith(IdentificationOfVersion2End)))
            );
        }
        /// <summary>
        /// Gets a version out of Diagram Identification string
        /// </summary>
        /// <param name="Identification">Any string</param>
        /// <returns>Version of Diagram Identification string</returns>
        private int ParseVersion(string Identification)
        {
            if (Identification.StartsWith(IdentificationOfVersion1))
                return 1;
            else if (Identification.StartsWith(IdentificationOfVersion2))
                return 2;
            else
                throw new ArgumentException("Unsupported version.");
        }

        /// <summary>
        /// Supporting operation that tries to parse a string S that 
        /// should contain a datatime in given format. If it fails 
        /// result value is DateTime.MinValue.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        private static DateTime ParseDateTime(string S)
        {
            DateTime result;

            if (!DateTime.TryParseExact(S, DiagramIdentificationDateFormat, null, DateTimeStyles.None, out result))
                result = DateTime.MinValue;

            return result;
        }


        /// <summary>
        /// Creates an XML string of this class. In other words, this operation 
        /// returns string that represents metadata. The result is in current 
        /// version.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("DiagramIdentification");
            xml.AppendChild(root);

            XmlElement e;

            e = xml.CreateElement("GUID");
            e.InnerText = GUID;
            root.AppendChild(e);

            e = xml.CreateElement("Author");
            e.InnerText = Author;
            root.AppendChild(e);

            e = xml.CreateElement("Type");
            e.InnerText = Type;
            root.AppendChild(e);

            e = xml.CreateElement("Name");
            e.InnerText = Name;
            root.AppendChild(e);

            e = xml.CreateElement("Stereotype");
            e.InnerText = Stereotype;
            root.AppendChild(e);

            e = xml.CreateElement("EACreatedDate");
            e.InnerText = EACreatedDate.ToString(DiagramIdentificationDateFormat);
            root.AppendChild(e);

            e = xml.CreateElement("EAModifiedDate");
            e.InnerText = EAModifiedDate.ToString(DiagramIdentificationDateFormat);
            root.AppendChild(e);

            e = xml.CreateElement("WordCreatedDate");
            e.InnerText = WordCreatedDate.ToString(DiagramIdentificationDateFormat);
            root.AppendChild(e);

            e = xml.CreateElement("WordModifiedDate");
            e.InnerText = WordModifiedDate.ToString(DiagramIdentificationDateFormat);
            root.AppendChild(e);

            return IdentificationOfVersion2 + xml.OuterXml;
        }

        /// <summary>
        /// Parses the diagram identification given in Identification parameter. 
        /// This parameter can containt medatadata according to rules defined
        /// by DiagramIdentification class. In case that the version of the
        /// datadata is not valid an exception is raised. This operation supports
        /// all released version (that means not only the current one). 
        /// </summary>
        /// <param name="Identification"></param>
        private void ParseIdentification(string Identification)
        {
            ClearValues();

            if (!IsDiagramIdentification(Identification))
                throw new ArgumentException("Wrong Diagram Identification format.");

            vVersion = ParseVersion(Identification);

            switch (vVersion)
            {
                case 1: vGUID = Identification.Substring(IdentificationOfVersion1.Length, GUIDLength); break;
                case 2: SetValuesVersion2(Identification.Substring(IdentificationOfVersion2.Length)); break;
                default: throw new ArgumentException("Unsupported version.");

            }
        }

        /// <summary>
        /// Sets properties values according to metadata given in XMLString parameter.
        /// </summary>
        /// <param name="XMLString"></param>
        private void SetValuesVersion2(string XMLString)
        {
            //xml
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(XMLString);

            vGUID = xml.SelectSingleNode("/DiagramIdentification/GUID").InnerText;
            vAuthor = xml.SelectSingleNode("/DiagramIdentification/Author").InnerText;
            vType = xml.SelectSingleNode("/DiagramIdentification/Type").InnerText;
            vName = xml.SelectSingleNode("/DiagramIdentification/Name").InnerText;
            vStereotype = xml.SelectSingleNode("/DiagramIdentification/Stereotype").InnerText;

            vEACreatedDate = ParseDateTime(xml.SelectSingleNode("/DiagramIdentification/EACreatedDate").InnerText);
            vEAModifiedDate = ParseDateTime(xml.SelectSingleNode("/DiagramIdentification/EAModifiedDate").InnerText);
            vWordCreatedDate = ParseDateTime(xml.SelectSingleNode("/DiagramIdentification/WordCreatedDate").InnerText);
            vWordModifiedDate = ParseDateTime(xml.SelectSingleNode("/DiagramIdentification/WordModifiedDate").InnerText);
        }

    }
}
