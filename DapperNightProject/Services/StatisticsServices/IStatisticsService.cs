using DapperNightProject.Dtos;
using DapperNightProject.Dtos.ProductsDtos;
using DapperNightProject.Models;

namespace DapperNightProject.Services.StatisticsServices
{
    public interface IStatisticsService
    {
        Task<int> GetTotalSalesCountAsync();
        Task<decimal> GetTotalSalesAmountAsync();
        Task<String> GetTopCityAsync();
        Task<int> GetTopYearAsync();
        Task<List<ProductStatDto>> GetTopProductsAsync(int count);
        Task<List<int>> GetMonthlyOrderCountsAsync(int year);
        Task<List<UserSalesStatDto>> GetTopSellersAsync(int count);
        Task<List<StoreCategoryStatDto>> GetTopStoreCategoriesAsync(int count);
        Task<decimal> GetTotalRevenueAsync();
        Task<decimal> GetTotalProfitAsync();
        Task<List<SaleStatDto>> GetLastSalesAsync(int count);
       
    }
}
