using Newtonsoft.Json;

namespace ConsumerTwo.Models
{
    public class Attachment
    {
        [JsonProperty("publishedContentId")]
        public string publishedContentId { get; set; }

        [JsonProperty("fileName")]
        public string fileName { get; set; }

        [JsonProperty("docDescription")]
        public string docDescription { get; set; }

        [JsonProperty("docRegNumber")]
        public string docRegNumber { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("cryptoSigns")]
        public CryptoSigns cryptoSigns { get; set; }
    }

    public class CryptoSigns
    {
        [JsonProperty("0")]
        public string? _0 { get; set; }

        [JsonProperty("signature")]
        public string[]? signature { get; set; }
    }

    public class Currency
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class DocAcceptance
    {
        [JsonProperty("sid")]
        public string sid { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("documentDate")]
        public string documentDate { get; set; }

        [JsonProperty("documentNum")]
        public string documentNum { get; set; }
    }

    public class DocAcceptancePayDoc
    {
        [JsonProperty("isDocAcceptancePayDoc")]
        public string isDocAcceptancePayDoc { get; set; }

        [JsonProperty("payDocToDocAcceptanceCompliances")]
        public PayDocToDocAcceptanceCompliances payDocToDocAcceptanceCompliances { get; set; }
    }

    public class DocTermination
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("documentDate")]
        public string documentDate { get; set; }
    }

    public class Execution
    {
        [JsonProperty("payDoc")]
        public PayDoc payDoc { get; set; }

        [JsonProperty("currency")]
        public Currency currency { get; set; }

        [JsonProperty("paid")]
        public string paid { get; set; }

        [JsonProperty("paidRUR")]
        public string paidRUR { get; set; }

        [JsonProperty("paidVAT")]
        public string paidVAT { get; set; }

        [JsonProperty("paidVATRUR")]
        public string paidVATRUR { get; set; }

        [JsonProperty("improperExecutionText")]
        public string improperExecutionText { get; set; }
    }

    public class Executions
    {
        [JsonProperty("stage")]
        public Stage stage { get; set; }

        [JsonProperty("ordinalNumber")]
        public string ordinalNumber { get; set; }

        [JsonProperty("execution")]
        public List<Execution> execution { get; set; }
    }

    public class PayDoc
    {
        [JsonProperty("sid")]
        public string sid { get; set; }

        [JsonProperty("documentName")]
        public string documentName { get; set; }

        [JsonProperty("documentDate")]
        public string documentDate { get; set; }

        [JsonProperty("documentNum")]
        public string documentNum { get; set; }

        [JsonProperty("payDocTypeInfo")]
        public PayDocTypeInfo payDocTypeInfo { get; set; }
    }

    public class PayDocToDocAcceptanceCompliances
    {
        [JsonProperty("docAcceptance")]
        public DocAcceptance docAcceptance { get; set; }
    }

    public class PayDocTypeInfo
    {
        [JsonProperty("docAcceptancePayDoc")]
        public DocAcceptancePayDoc docAcceptancePayDoc { get; set; }
    }

    public class PaymentDocuments
    {
        [JsonProperty("attachment")]
        public Attachment? attachment { get; set; }
    }

    public class PrintForm
    {
        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("docRegNumber")]
        public string docRegNumber { get; set; }
    }

    public class Reason
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class ReceiptDocuments
    {
        [JsonProperty("attachment")]
        public Attachment? attachment { get; set; }
    }

    public class ContractProcedure
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("regNum")]
        public string regNum { get; set; }

        [JsonProperty("publishDate")]
        public DateTime publishDate { get; set; }

        [JsonProperty("versionNumber")]
        public string versionNumber { get; set; }

        [JsonProperty("executions")]
        public Executions executions { get; set; }

        [JsonProperty("termination")]
        public Termination termination { get; set; }

        [JsonProperty("printForm")]
        public PrintForm printForm { get; set; }

        [JsonProperty("terminationDocuments")]
        public TerminationDocuments terminationDocuments { get; set; }

        [JsonProperty("paymentDocuments")]
        public PaymentDocuments paymentDocuments { get; set; }

        [JsonProperty("receiptDocuments")]
        public ReceiptDocuments receiptDocuments { get; set; }

        [JsonProperty("modificationReason")]
        public string modificationReason { get; set; }

        [JsonProperty("currentContractStage")]
        public string currentContractStage { get; set; }

        [JsonProperty("okpd2okved2")]
        public string okpd2okved2 { get; set; }

        [JsonProperty("isEDIBased")]
        public string isEDIBased { get; set; }

        [JsonProperty("isPURorASFKBased")]
        public string isPURorASFKBased { get; set; }

        [JsonProperty("isUnilateralRefusalAuto")]
        public string isUnilateralRefusalAuto { get; set; }
    }

    public class Stage
    {
        [JsonProperty("endDate")]
        public string endDate { get; set; }
    }

    public class Termination
    {
        [JsonProperty("paid")]
        public string paid { get; set; }

        [JsonProperty("terminationDate")]
        public string terminationDate { get; set; }

        [JsonProperty("reasonInfo")]
        public string reasonInfo { get; set; }

        [JsonProperty("reason")]
        public Reason reason { get; set; }

        [JsonProperty("docTermination")]
        public DocTermination docTermination { get; set; }
    }

    public class TerminationDocuments
    {
        [JsonProperty("attachment")]
        public Attachment? attachment { get; set; }
    }

}
