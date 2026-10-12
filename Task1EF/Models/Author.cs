using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task01EF.Models
{
    [Table("Writers")]
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Country { get; set; }
    }
}

#region Questions
/*
- Why we use Code First rather than DB First?
  1. Code First allows the C# code to act as the single source of truth.
  2. Better support for Version Control (Git) and tracking schema changes easily via migrations.
  3. Fits naturally with Domain-Driven Design (DDD) and clean architecture principles.

- Why we use Fluent API over Data Annotations?
  1. Keeps domain models clean and free from database-specific attributes.
  2. More powerful and flexible, supporting complex relationships, composite keys, and cascade delete configurations that annotations cannot handle.
  3. Centralizes all database mapping rules in one place (OnModelCreating).
*/
#endregion