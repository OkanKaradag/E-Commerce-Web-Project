using System;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
