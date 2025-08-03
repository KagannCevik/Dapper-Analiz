
using Dapper;
using DapperNightProject.Context;
using DapperNightProject.Dtos;
using DapperNightProject.Dtos.ProductsDtos;
using DapperNightProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperNightProject.Services.StatisticsServices
{
    public class StatisticsService : IStatisticsService
    {
        private readonly DapperContext _dapperContext;

        public StatisticsService(DapperContext dapperContext)
        {
            this._dapperContext = dapperContext;
        }

      

        public async Task<List<SaleStatDto>> GetLastSalesAsync(int count)
        {
            var sql = $@"
        SELECT TOP ({count}) ITEMNAME, TOTALPRICE, DATE_
        FROM SALES
        ORDER BY DATE_ DESC";
            var conn = _dapperContext.CreateConnection();
            var result = await conn.QueryAsync<SaleStatDto>(sql);
            return result.ToList();
        }

        public async Task<List<int>> GetMonthlyOrderCountsAsync(int year)
        {
            var sql = @"
            SELECT MONTH(DATE_) AS Month, COUNT(*) AS OrderCount
            FROM SALES
             WHERE YEAR(DATE_) = @year
            GROUP BY MONTH(DATE_)
            ORDER BY Month";
            var conn = _dapperContext.CreateConnection();
            var result = await conn.QueryAsync<(int Month, int OrderCount)>(sql, new { year });

            // 12 ayı doldurmak için:
            var monthlyCounts = Enumerable.Repeat(0, 12).ToList();
            foreach (var row in result)
                monthlyCounts[row.Month - 1] = row.OrderCount;
            return monthlyCounts;
        }

        public Task<string> GetTopCityAsync()
        {
            var sql = @"Select TOP 1 CITY From Sales Group By CITY ORDER BY Count(*) DESC";
            var conn = _dapperContext.CreateConnection();
            return conn.ExecuteScalarAsync<string>(sql);
        }

        public async Task<List<ProductStatDto>> GetTopProductsAsync(int count)
        {
            var sql = $@"
        SELECT TOP ({count}) ITEMNAME AS ProductName,
               COUNT(*) AS TotalSalesCount,
               SUM(TOTALPRICE) AS TotalAmount
        FROM SALES
        GROUP BY ITEMNAME
        ORDER BY TotalSalesCount DESC";
            var conn = _dapperContext.CreateConnection();
            return (await conn.QueryAsync<ProductStatDto>(sql)).ToList();
        }

        public async Task<List<UserSalesStatDto>> GetTopSellersAsync(int count)
        {
            var sql = $@"
        SELECT TOP ({count}) NAMESURNAME AS NameSurname,
               COUNT(*) AS TotalSalesCount
        FROM SALES
        GROUP BY NAMESURNAME
        ORDER BY TotalSalesCount DESC";
            var conn = _dapperContext.CreateConnection();
            return (await conn.QueryAsync<UserSalesStatDto>(sql)).ToList();
        }

        public async Task<List<StoreCategoryStatDto>> GetTopStoreCategoriesAsync(int count)
        {
            var sql = $@"
            WITH StoreCategorySales AS (
            SELECT 
                NAMESURNAME AS StoreName,
                CATEGORY1 AS Category,
                COUNT(*) AS SalesCount,
                SUM(TOTALPRICE) AS TotalAmount
            FROM SALES
            GROUP BY NAMESURNAME, CATEGORY1
         ),
          RankedCategories AS (
            SELECT *,
                ROW_NUMBER() OVER (PARTITION BY StoreName ORDER BY SalesCount DESC) AS rn
            FROM StoreCategorySales
            )
            SELECT TOP ({count}) 
            StoreName,
            Category AS TopCategory,
            SalesCount AS TotalSalesCount,
            TotalAmount
            FROM RankedCategories
             WHERE rn = 1
            ORDER BY TotalSalesCount DESC";
            var conn = _dapperContext.CreateConnection();
            return (await conn.QueryAsync<StoreCategoryStatDto>(sql)).ToList();
        }

        public Task<int> GetTopYearAsync()
        {
            var sql = "Select Top 1 YEAR (DATE_) AS SaleYear From Sales Group By YEAR (DATE_) Order By Count(*) Desc";
            var conn = _dapperContext.CreateConnection();
            return conn.ExecuteScalarAsync<int>(sql);
        }

        public async Task<decimal> GetTotalProfitAsync()
        {
            // Eğer maliyet yoksa, örnek: %20 kâr marjı
            var revenue = await GetTotalRevenueAsync();
            return revenue * 0.20M;
        }

        public async Task<decimal> GetTotalRevenueAsync()
        {
            var sql = "SELECT SUM(TOTALPRICE) FROM SALES";
            var conn = _dapperContext.CreateConnection();
            var result = await conn.ExecuteScalarAsync<decimal?>(sql);
            return result ?? 0;
        }

        public Task<decimal> GetTotalSalesAmountAsync()
        {
            var sql = "Select Sum(TOTALPRICE) from Sales";
            var conn = _dapperContext.CreateConnection();
            return conn.ExecuteScalarAsync<decimal>(sql);
        }

        public async Task<int> GetTotalSalesCountAsync()
        {
            var sql = "Select Count(*) From Sales";
            var conn = _dapperContext.CreateConnection();
            return await conn.ExecuteScalarAsync<int>(sql);

        }
       
    }
}
