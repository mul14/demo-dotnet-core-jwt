using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Program.Models
{
    public class CartModel
    {
        public uint Id { get; set; }

        public uint ProductId { get; set; }
        public uint UserId { get; set; }

        public virtual UserModel User { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; } = null;
    }
}
