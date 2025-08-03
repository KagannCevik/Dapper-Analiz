using DapperNightProject.Dtos;

namespace DapperNightProject.Controllers
{
    internal class ComporeViewModel
    {
        public string Yontem { get; set; }
        public int KayitSayisi { get; set; }
        public List<Record> IlkOnKayit { get; set; }
    }
}