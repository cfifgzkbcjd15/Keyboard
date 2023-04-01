using Newtonsoft.Json;

namespace ConsumerTwo.Models.OnlyContractProcedure
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Budget
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Budgetary
    {
        [JsonProperty("month")]
        public int month { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }

        [JsonProperty("substageMonth")]
        public int substageMonth { get; set; }

        [JsonProperty("substageYear")]
        public int substageYear { get; set; }

        [JsonProperty("KBK")]
        public string KBK { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("comment")]
        public string comment { get; set; }
    }

    public class ContactInfo
    {
        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("middleName")]
        public string middleName { get; set; }
    }

    public class ContractProcedure
    {
        [JsonProperty("schemeVersion")]
        public string schemeVersion { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("regNum")]
        public string regNum { get; set; }

        [JsonProperty("number")]
        public string number { get; set; }

        [JsonProperty("publishDate")]
        public DateTime publishDate { get; set; }

        [JsonProperty("signDate")]
        public string signDate { get; set; }

        [JsonProperty("versionNumber")]
        public string versionNumber { get; set; }

        [JsonProperty("foundation")]
        public Foundation foundation { get; set; }

        [JsonProperty("customer")]
        public Customer customer { get; set; }

        [JsonProperty("protocolDate")]
        public string protocolDate { get; set; }

        [JsonProperty("documentBase")]
        public string documentBase { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("currency")]
        public Currency currency { get; set; }

        [JsonProperty("singleCustomerReason")]
        public SingleCustomerReason singleCustomerReason { get; set; }

        [JsonProperty("executionDate")]
        public ExecutionDate executionDate { get; set; }

        [JsonProperty("finances")]
        public Finances finances { get; set; }

        [JsonProperty("products")]
        public Products products { get; set; }

        [JsonProperty("suppliers")]
        public Suppliers suppliers { get; set; }

        [JsonProperty("href")]
        public string href { get; set; }

        [JsonProperty("printForm")]
        public PrintForm printForm { get; set; }

        [JsonProperty("Modification")]
        public Modification Modification { get; set; }

        [JsonProperty("currentContractStage")]
        public string currentContractStage { get; set; }
    }

    public class Country
    {
        [JsonProperty("countryCode")]
        public string countryCode { get; set; }

        [JsonProperty("countryFullName")]
        public string countryFullName { get; set; }
    }

    public class Currency
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Customer
    {
        [JsonProperty("regNum")]
        public string regNum { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("inn")]
        public string inn { get; set; }

        [JsonProperty("kpp")]
        public string kpp { get; set; }
    }

    public class ExecutionDate
    {
        [JsonProperty("month")]
        public int month { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }
    }

    public class Extrabudget
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Extrabudgetary
    {
        [JsonProperty("month")]
        public int month { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }

        [JsonProperty("substageMonth")]
        public int substageMonth { get; set; }

        [JsonProperty("substageYear")]
        public int substageYear { get; set; }

        [JsonProperty("KOSGU")]
        public string KOSGU { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }
    }

    public class Finances
    {
        [JsonProperty("financeSource")]
        public string financeSource { get; set; }

        [JsonProperty("extrabudget")]
        public Extrabudget extrabudget { get; set; }

        [JsonProperty("budget")]
        public Budget budget { get; set; }

        [JsonProperty("budgetLevel")]
        public string budgetLevel { get; set; }

        [JsonProperty("budgetary")]
        public Budgetary budgetary { get; set; }

        [JsonProperty("extrabudgetary")]
        public Extrabudgetary extrabudgetary { get; set; }
    }

    public class Foundation
    {
        [JsonProperty("oosOrder")]
        public OosOrder oosOrder { get; set; }
    }

    public class Modification
    {
        [JsonProperty("modification")]
        public string modification { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("base")]
        public string @base { get; set; }
    }

    public class OKEI
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("nationalCode")]
        public string nationalCode { get; set; }
    }

    public class OKPD
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class OosOrder
    {
        [JsonProperty("chardata")]
        public string chardata { get; set; }

        [JsonProperty("notificationNumber")]
        public string notificationNumber { get; set; }

        [JsonProperty("lotNumbert")]
        public string lotNumbert { get; set; }

        [JsonProperty("placing")]
        public string placing { get; set; }
    }

    public class PrintForm
    {
        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("signature")]
        public Signature signature { get; set; }
    }

    public class Product
    {
        [JsonProperty("sid")]
        public string sid { get; set; }

        [JsonProperty("OKPD")]
        public OKPD OKPD { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("OKEI")]
        public OKEI OKEI { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("quantity")]
        public int quantity { get; set; }

        [JsonProperty("sum")]
        public double sum { get; set; }
    }

    public class Products
    {
        [JsonProperty("product")]
        public List<Product> product { get; set; }
    }

    public class ResponseProcedure
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("contract")]
        public ContractProcedure contract { get; set; }
    }

    public class Signature
    {
        [JsonProperty("type")]
        public string type { get; set; }
    }

    public class SingleCustomerReason
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Supplier
    {
        [JsonProperty("participantType")]
        public string participantType { get; set; }

        [JsonProperty("inn")]
        public string inn { get; set; }

        [JsonProperty("kpp")]
        public string kpp { get; set; }

        [JsonProperty("organizationName")]
        public string organizationName { get; set; }

        [JsonProperty("country")]
        public Country country { get; set; }

        [JsonProperty("factualAddress")]
        public string factualAddress { get; set; }

        [JsonProperty("postAddress")]
        public string postAddress { get; set; }

        [JsonProperty("contactInfo")]
        public ContactInfo contactInfo { get; set; }

        [JsonProperty("contactEMail")]
        public string contactEMail { get; set; }

        [JsonProperty("contactPhone")]
        public string contactPhone { get; set; }

        [JsonProperty("contactFax")]
        public string contactFax { get; set; }
    }

    public class Suppliers
    {
        [JsonProperty("supplier")]
        public List<Supplier> supplier { get; set; }
    }


}
