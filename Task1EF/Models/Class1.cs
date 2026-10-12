using System;

namespace Task01EF.Models
{
    public class class1
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}

#region Essay Questions & Answers
/*
Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
- Answer: By EF Core convention, any property named "Id" or "[ClassName]Id" is automatically recognized as the Primary Key.

Q2: Why is "Country" nullable in the database while "Price" is not?
- Answer: "Country" is defined as a nullable string (string?) which allows nulls by default. 
  "Price" is a decimal (a non-nullable value type in C#), meaning it cannot accept null values unless explicitly marked as nullable (decimal?).
*/
#endregion