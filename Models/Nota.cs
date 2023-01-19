namespace Site_Ilian_DanRaul.Models
{
    public class Nota
    {
        public int ID { get; set; }
        public string NotaAnime { get; set; }
        public ICollection<ListaAnimecs>? ListeAninme { get; set; } //navigation property
    }
}
