using DapperNightProject.Dtos.ProductsDtos;

namespace DapperNightProject.Models
{
    public class StatisticsDashboardViewModel
    {
        public int TotalSalesCount { get; set; }
        public decimal TotalSalesAmount { get; set; }
        public string MostSoldProductName { get; set; }
        public int TodaySalesCount { get; set; }
        public List<string> AllCities { get; set; }
        public List<string> AllCategories { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedCategory { get; set; }
        public DateTime? FilterStartDate { get; set; }
        public DateTime? FilterEndDate { get; set; }
        
        //public List<SaleStat> LastSales { get; set; }
        public List<string> MonthlySalesLabels { get; set; }
        public List<int> MonthlySalesData { get; set; }
        public List<string> CitySalesLabels { get; set; }
        public List<int> CitySalesData { get; set; }
        public String TopCity { get; set; }
        public int TopYear { get; set; }
        public List<ProductStatDto> TopProducts{ get; set; }
        public List<int> MonthlyOrderCounts { get; set; }
        public List<UserSalesStatDto> TopSellers { get; set; }
        public List<StoreCategoryStatDto> TopStoreCategories { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        public List<SaleStatDto> LastSales { get; set; } = new();
    }
    
    public class SaleStat
    {
        public DateTime Date_ { get; set; }
        public string ItemName { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
