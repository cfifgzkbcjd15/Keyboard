using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Keyboard.Models
{
    public class LegalForm
    {
        public int Id { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("singularName")]
        public string SingularName { get; set; }
    }
    public class ContactInfo
    {
        public int Id { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryFullName")]
        public string CountryFullName { get; set; }
    }

    public class Currency
    {
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        [JsonProperty("regNum")]
        public string RegNum { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("kpp")]
        public string Kpp { get; set; }
        [JsonProperty("legalForm")]
        public LegalForm? LegalForm { get; set; }
    }

    public class ExecutionDate
    {
        public int Id { get; set; }
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }

    public class Extrabudget
    {
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Extrabudgetary
    {
        public int Id { get; set; }
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("substageMonth")]
        public string SubstageMonth { get; set; }

        [JsonProperty("substageYear")]
        public string SubstageYear { get; set; }

        [JsonProperty("KOSGU")]
        public string KOSGU { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }

    public class Finances
    {
        public int Id { get; set; }
        [JsonProperty("financeSource")]
        public string FinanceSource { get; set; }

        [JsonProperty("extrabudget")]
        public Extrabudget? Extrabudget { get; set; }

        [JsonProperty("extrabudgetary")]
        public Extrabudgetary? Extrabudgetary { get; set; }
    }

    public class Foundation
    {
        public int Id { get; set; }
        [JsonProperty("oosOrder")]
        public OosOrder? OosOrder { get; set; }
    }

    public class OKEI
    {
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("nationalCode")]
        public string NationalCode { get; set; }
    }

    public class OKPD
    {
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OosOrder
    {
        public int Id { get; set; }
        [JsonProperty("chardata")]
        public string Chardata { get; set; }

        [JsonProperty("notificationNumber")]
        public string NotificationNumber { get; set; }

        [JsonProperty("lotNumbert")]
        public string LotNumbert { get; set; }

        [JsonProperty("placing")]
        public string Placing { get; set; }
    }

    public class PrintForm
    {
        public int Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("OKPD")]
        public OKPD? OKPD { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("OKEI")]
        public OKEI? OKEI { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("sum")]
        public string Sum { get; set; }
    }

    public class Products
    {
        public int Id { get; set; }
        [JsonProperty("product")]
        public List<Product>? Product { get; set; }
    }

    public class Contract
    {
        [JsonProperty("schemeVersion")]
        public string SchemeVersion { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("regNum")]
        public string RegNum { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("publishDate")]
        public DateTime PublishDate { get; set; }

        [JsonProperty("signDate")]
        public string SignDate { get; set; }

        [JsonProperty("versionNumber")]
        public string VersionNumber { get; set; }

        [JsonProperty("foundation")]
        public Foundation? Foundation { get; set; }

        [JsonProperty("customer")]
        public Customer? Customer { get; set; }

        [JsonProperty("protocolDate")]
        public string ProtocolDate { get; set; }

        [JsonProperty("documentBase")]
        public string DocumentBase { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("currency")]
        public Currency? Currency { get; set; }

        [JsonProperty("singleCustomerReason")]
        public SingleCustomerReason? SingleCustomerReason { get; set; }

        [JsonProperty("executionDate")]
        public ExecutionDate? ExecutionDate { get; set; }

        [JsonProperty("finances")]
        public Finances Finances { get; set; }

        [JsonProperty("products")]
        public Products? Products { get; set; }

        [JsonProperty("suppliers")]
        public Suppliers? Suppliers { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("printForm")]
        public PrintForm? PrintForm { get; set; }

        [JsonProperty("currentContractStage")]
        public string CurrentContractStage { get; set; }
    }

    public class Signature
    {
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SingleCustomerReason
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        [JsonProperty("participantType")]
        public string ParticipantType { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("kpp")]
        public string Kpp { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("country")]
        public Country? Country { get; set; }

        [JsonProperty("factualAddress")]
        public string FactualAddress { get; set; }

        [JsonProperty("postAddress")]
        public string PostAddress { get; set; }

        [JsonProperty("contactInfo")]
        public ContactInfo? ContactInfo { get; set; }

        [JsonProperty("contactEMail")]
        public string ContactEMail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contactFax")]
        public string ContactFax { get; set; }
    }

    public class Suppliers
    {
        public int Id { get; set; }
        [JsonProperty("supplier")]
        public List<Supplier> Supplier { get; set; }
    }

}

