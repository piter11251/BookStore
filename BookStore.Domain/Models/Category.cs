﻿namespace BookStore.Domain.Models
{
    public class Category: Entity
    {
        public string Name { get; set; }

        /* EF Relation */
        public IEnumerable<Book> Books { get; set; } 
    }
}