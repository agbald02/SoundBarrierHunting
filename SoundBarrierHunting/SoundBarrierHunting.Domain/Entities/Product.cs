﻿namespace SoundBarrierHunting.Domain.Entities
{
    public class Product
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }
    }
}
