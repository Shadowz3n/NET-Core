using System;
using app.Api.Domain.Entities;

namespace app.Domain.Commands.Responses
{
    public class CreateProductResponse
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}