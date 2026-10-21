using RazorPages.Models;
using RazorPagesZenSpaCh7.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesZenSpaCh7.Views.Service
{
    public class ClientService
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
        public Client? Client { get; set; }
        [ForeignKey("ServicesID")]
        public int ServicesID { get; set; }
        public Services? Services { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
