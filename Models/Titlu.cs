namespace Site_Ilian_DanRaul.Models
{
    public class Titlu
    {
        public int ID { get; set; }
        public string TitluAnime { get; set; }
        public ICollection<ListaAnimecs>? ListaAnimeuri{ get; set; } //navigation property
    }
}
