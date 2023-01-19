namespace Site_Ilian_DanRaul.Models
{
    public class Statut
    {
        public int ID { get; set; }
        public string Stare { get; set; }
        public ICollection<ListaAnimecs>? ListaAnimeuri{ get; set; } //navigation property
    }
}
