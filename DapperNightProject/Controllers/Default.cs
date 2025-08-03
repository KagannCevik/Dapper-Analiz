using DapperNightProject.Dtos.ProductsDtos;
using DapperNightProject.Models;
using DapperNightProject.Services.StatisticsServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperNightProject.Controllers
{
    public class Default : Controller
    {
        private readonly IStatisticsService _statisticsService;

        public Default(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new StatisticsDashboardViewModel
            {
                TotalSalesCount =await _statisticsService.GetTotalSalesCountAsync(),
                TotalSalesAmount=await _statisticsService.GetTotalSalesAmountAsync(),
                TopCity=await _statisticsService.GetTopCityAsync(),
                TopYear=await _statisticsService.GetTopYearAsync(),
                TopProducts=await _statisticsService.GetTopProductsAsync(5),
                MonthlyOrderCounts = await _statisticsService.GetMonthlyOrderCountsAsync(2023),
                TopSellers= await _statisticsService.GetTopSellersAsync(5),
                TopStoreCategories = await _statisticsService.GetTopStoreCategoriesAsync(5),
                TotalRevenue = await _statisticsService.GetTotalRevenueAsync(),
                TotalProfit = await _statisticsService.GetTotalProfitAsync(),
                LastSales = await _statisticsService.GetLastSalesAsync(5)
            };
            return View(model);
        }
     
    }
}
