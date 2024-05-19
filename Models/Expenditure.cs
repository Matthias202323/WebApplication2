namespace WebApplication2.Models
{
    public class Expenditure
    {
        public DateOnly Date { get; set; }

        public double Price { get; set; }

        public string? Nom { get; set; }

         public Expenditure(DateOnly date, double price, string? nom)
         {
             Date = date;
             Price = price;
             Nom = nom;
        }
    }
}
