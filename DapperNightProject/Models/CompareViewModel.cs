using DapperNightProject.Dtos;

namespace DapperNightProject.Models
{
    public class CompareViewModel
    {

        public string Yontem { get; set; } 
        public int RecordCount { get; set; }
        public List<Record> RecordList { get; set; }
        public long ElapsedMilliseconds { get; set; }
        public long MemoryUsedBytes { get; set; }      
        public string SqlQuery { get; set; }
    }
}
