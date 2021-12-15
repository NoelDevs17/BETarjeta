using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;


namespace BETarjeta.Models

{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        
        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpiracaion { get; set; }
        [Required]
        public string CVV { get; set; }
    }
}
