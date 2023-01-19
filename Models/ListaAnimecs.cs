using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Site_Ilian_DanRaul.Models
{
    public class ListaAnimecs
    {
        public int Id { get; set; }
        public int? TitluID { get; set; }
        public Titlu? Titlu { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataInceput { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }
        public int? NotaID { get; set; }
        public Nota? Nota { get; set; }
        public int? StatutID { get; set; }
        public Statut? Statut { get; set; }
    } //navigation property
}
