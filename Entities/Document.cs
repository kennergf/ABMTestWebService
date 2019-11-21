using System.Xml.Serialization;

namespace ABMTestWebService.Entities
{
    [XmlRoot("InputDocument")]
    public class Document
    {
        [XmlElement("Declaration")]
        public string Declaration {get;set;}

        [XmlElement("Jurisdiction")]
        public string Jurisdiction {get;set;}

        [XmlElement("CWProcedure")]
        public string CWProcedure {get;set;}

        [XmlElement("DeclarationDestination")]
        public string DeclarationDestination {get; set;}

        [XmlElement("DocumentRef")]
        public string DocumentRef {get; set;}

        [XmlElement("SiteID")]
        public string SiteID {get; set;}

        [XmlElement("AccountCode")]
        public string AccountCode {get; set;}
    }
}