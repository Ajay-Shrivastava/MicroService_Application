﻿namespace CheckoutService.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int OrderId { get; set; } 
        public string Status { get; set; }
    }
}
