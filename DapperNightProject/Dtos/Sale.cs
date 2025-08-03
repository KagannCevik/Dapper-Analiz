namespace DapperNightProject.Dtos
{
    public class Sale
    {
        public int ID { get; set; }
        public int? ORDERID { get; set; }
        public int? ORDERDETAILID { get; set; }
        public DateTime? DATE_ { get; set; }
        public int? USERID { get; set; }
        public string? USERNAME_ { get; set; }
        public string? NAMESURNAME { get; set; }
        public string? STATUS_ { get; set; }
        public int? ITEMID { get; set; }
        public string? ITEMCODE { get; set; }
        public string? ITEMNAME { get; set; }
        public int? AMOUNT { get; set; }
        public decimal? UNITPRICE { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? TOTALPRICE { get; set; }
        public string? CATEGORY1 { get; set; }
        public string? CATEGORY2 { get; set; }
        public string? CATEGORY3 { get; set; }
        public string? CATEGORY4 { get; set; }
        public string? BRAND { get; set; }
        public string? USERGENDER { get; set; }
        public DateTime? USERBIRTHDATE { get; set; }
        public string? REGION { get; set; }
        public string? CITY { get; set; }
        public string? TOWN { get; set; }
        public string? DISTRICT { get; set; }
        public string? ADDRESSTEXT { get; set; }
        public int? ADDRESSID { get; set; }
    }
}
