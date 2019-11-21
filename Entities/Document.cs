using System.Xml.Serialization;

namespace ABMTestWebService.Entities
{
    [XmlRoot("InputDocument")]
    public class Document
    {
        [XmlElement("DeclarationList")]
        public DeclarationDTO[] DeclarationList {get; set;}
    }

    public class DeclarationDTO
    {
        [XmlElement("Declaration")]
        public DeclarationHeaderDTO Declaration {get; set;}
    }

    public class DeclarationHeaderDTO
    {
        [XmlAttribute("Command")]
        public string Command {get; set;}

        [XmlAttribute("Version")]
        public string Version {get; set;}

        [XmlElement("DeclarationHeader")]
        public DeclarationDataDTO DeclarationHeader {get; set;}
    }

    public class DeclarationDataDTO
    {
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