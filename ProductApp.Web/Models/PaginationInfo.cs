namespace ProductApp.Web.Models
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }         // Toplam ürün sayısı
        public int ItemsPerPage { get; set; }       // Her sayfada kaç ürün gösterilecek
        public int CurrentPage { get; set; }        // Şu anki sayfa
        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); // Sayfa sayısı
    }
}
