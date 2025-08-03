using DapperNightProject.Models;
using DapperNightProject.Services.DapperService;
using DapperNightProject.Services.EfService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DapperNightProject.Controllers
{
    public class TestController : Controller
    {
        private readonly IEfService _efService;
        private readonly IDapperService _dapperService;

        public TestController(IEfService efService, IDapperService dapperService)
        {
            _efService = efService;
            _dapperService = dapperService;
        }

        public async Task< IActionResult> DapperTest()
        {
          
            long memoryBefore = GC.GetTotalMemory(true);
            var sw=Stopwatch.StartNew();
            var records = await _dapperService.GetAllRecordAsync();
            var count = await _dapperService.GetRecordCountAsync();
            sw.Stop();
            long memoryAfter = GC.GetTotalMemory(true);
            long memoryUsed = memoryAfter - memoryBefore;
            var model = new CompareViewModel
            {
                Yontem = "Dapper",
                RecordCount = count,
                RecordList = records,
                ElapsedMilliseconds = sw.ElapsedMilliseconds,
                MemoryUsedBytes = memoryUsed,
                
            };
            return View(model);
        }
        public async Task< IActionResult> EfTest()
        {
           
            long memoryBefore = GC.GetTotalMemory(true);
            var sw = Stopwatch.StartNew();
            var records = await _efService.GetAllRecordsAsync();
            var count = await _efService.GetRecordCountAsync();
            sw.Stop();
            long memoryAfter = GC.GetTotalMemory(true);
            long memoryUsed = memoryAfter - memoryBefore;
            var model = new CompareViewModel
            {
                Yontem = "Entity Framework",
                RecordCount = count,
                RecordList = records,
                ElapsedMilliseconds = sw.ElapsedMilliseconds,
                MemoryUsedBytes= memoryUsed,

            };
            return View(model);
        }
    }
}
