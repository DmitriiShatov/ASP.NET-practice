using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public int? OrderId { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя!")]
        public string User { get; set; }
        [Required(ErrorMessage = "Укажите адресс!")]
        public string Address { get; set; }
        [Required (ErrorMessage = "Укажите номер телефона!")]
        public string ContactPhone { get; set; }
        public int? BikeId { get; set; }
        public Bike Bike { get; set; }
    }
} 
