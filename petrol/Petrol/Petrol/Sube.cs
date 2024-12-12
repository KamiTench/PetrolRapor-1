namespace Petrol
{
    public class Subel  // Bu sınıf POCO (data model) olarak kalacak
    {
        public int SubeId { get; set; }
        public string SubeAd { get; set; }
        public string SubeAdres { get; set; }

        // Constructor
        public Subel(int id, string ad, string adres)
        {
            SubeId = id;
            SubeAd = ad;
            SubeAdres = adres;
        }

        // Parametresiz constructor
        public Subel() { }
    }
}
