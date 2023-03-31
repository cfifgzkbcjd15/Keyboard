using System.Xml.Serialization;

namespace Keyboard.Models
{
    [XmlRoot(ElementName = "foundation")]
    public class Foundation
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "singleCustomer")]
        public bool SingleCustomer { get; set; }
    }

    [XmlRoot(ElementName = "customer")]
    public class Customer
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "regNum")]
        public int RegNum { get; set; }

        [XmlElement(ElementName = "fullName")]
        public string FullName { get; set; }

        [XmlElement(ElementName = "inn")]
        public int Inn { get; set; }

        [XmlElement(ElementName = "kpp")]
        public int Kpp { get; set; }
    }

    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "singleCustomerReason")]
    public class SingleCustomerReason
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "executionDate")]
    public class ExecutionDate
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "month")]
        public int Month { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }
    }

    [XmlRoot(ElementName = "budget")]
    public class Budget
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "budgetary")]
    public class Budgetary
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "month")]
        public int Month { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }

        [XmlElement(ElementName = "substageMonth")]
        public int SubstageMonth { get; set; }

        [XmlElement(ElementName = "substageYear")]
        public int SubstageYear { get; set; }

        [XmlElement(ElementName = "KBK")]
        public double KBK { get; set; }

        [XmlElement(ElementName = "price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "comment")]
        public string Comment { get; set; }
    }

    [XmlRoot(ElementName = "finances")]
    public class Finances
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "financeSource")]
        public string FinanceSource { get; set; }

        [XmlElement(ElementName = "budget")]
        public Budget Budget { get; set; }

        [XmlElement(ElementName = "budgetLevel")]
        public int BudgetLevel { get; set; }

        [XmlElement(ElementName = "budgetary")]
        public Budgetary Budgetary { get; set; }
    }

    [XmlRoot(ElementName = "OKPD")]
    public class OKPD
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "OKEI")]
    public class OKEI
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "nationalCode")]
        public string NationalCode { get; set; }
    }

    [XmlRoot(ElementName = "product")]
    public class Product
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "sid")]
        public int Sid { get; set; }

        [XmlElement(ElementName = "OKPD")]
        public OKPD OKPD { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "OKEI")]
        public OKEI OKEI { get; set; }

        [XmlElement(ElementName = "price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "sum")]
        public double Sum { get; set; }
    }

    [XmlRoot(ElementName = "products")]
    public class Products
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }
    }

    [XmlRoot(ElementName = "legalForm")]
    public class LegalForm
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "singularName")]
        public string SingularName { get; set; }
    }

    [XmlRoot(ElementName = "country")]
    public class Country
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "countryCode")]
        public int CountryCode { get; set; }

        [XmlElement(ElementName = "countryFullName")]
        public string CountryFullName { get; set; }
    }

    [XmlRoot(ElementName = "supplier")]
    public class Supplier
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "participantType")]
        public string ParticipantType { get; set; }

        [XmlElement(ElementName = "inn")]
        public int Inn { get; set; }

        [XmlElement(ElementName = "kpp")]
        public int Kpp { get; set; }

        [XmlElement(ElementName = "legalForm")]
        public LegalForm LegalForm { get; set; }

        [XmlElement(ElementName = "organizationName")]
        public string OrganizationName { get; set; }

        [XmlElement(ElementName = "country")]
        public Country Country { get; set; }

        [XmlElement(ElementName = "factualAddress")]
        public string FactualAddress { get; set; }

        [XmlElement(ElementName = "postAddress")]
        public string PostAddress { get; set; }

        [XmlElement(ElementName = "contactPhone")]
        public string ContactPhone { get; set; }
    }

    [XmlRoot(ElementName = "suppliers")]
    public class Suppliers
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "supplier")]
        public Supplier Supplier { get; set; }
    }

    [XmlRoot(ElementName = "signature")]
    public class Signature
    {
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "printForm")]
    public class PrintForm
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

        [XmlElement(ElementName = "signature")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "modification")]
    public class Modification
    {
        public int Id { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "base")]
        public string Base { get; set; }
    }

    [XmlRoot(ElementName = "contract")]
    public class Contract
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "regNum")]
        public double RegNum { get; set; }

        [XmlElement(ElementName = "number")]
        public int Number { get; set; }

        [XmlElement(ElementName = "publishDate")]
        public DateTime PublishDate { get; set; }

        [XmlElement(ElementName = "signDate")]
        public DateTime SignDate { get; set; }

        [XmlElement(ElementName = "versionNumber")]
        public int VersionNumber { get; set; }

        [XmlElement(ElementName = "foundation")]
        public Foundation Foundation { get; set; }

        [XmlElement(ElementName = "customer")]
        public Customer Customer { get; set; }

        [XmlElement(ElementName = "price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }

        [XmlElement(ElementName = "singleCustomerReason")]
        public SingleCustomerReason SingleCustomerReason { get; set; }

        [XmlElement(ElementName = "executionDate")]
        public ExecutionDate ExecutionDate { get; set; }

        [XmlElement(ElementName = "finances")]
        public Finances Finances { get; set; }

        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }

        [XmlElement(ElementName = "suppliers")]
        public Suppliers Suppliers { get; set; }

        [XmlElement(ElementName = "href")]
        public string Href { get; set; }

        [XmlElement(ElementName = "printForm")]
        public PrintForm PrintForm { get; set; }

        [XmlElement(ElementName = "modification")]
        public Modification Modification { get; set; }

        [XmlElement(ElementName = "currentContractStage")]
        public string CurrentContractStage { get; set; }

        [XmlAttribute(AttributeName = "schemeVersion")]
        public double SchemeVersion { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "export")]
    public class Export
    {
        public int Id { get; set; }

        [XmlElement(ElementName = "contract")]
        public Contract Contract { get; set; }

        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlAttribute(AttributeName = "oos")]
        public string Oos { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
