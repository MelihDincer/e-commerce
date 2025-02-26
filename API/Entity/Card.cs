namespace API.Entity;

public class Card 
{
    public int CardId {get; set;}
    public string CustomerId {get; set;} = null!;
    public List<CardItem> CardItems { get; set; } = new List<CardItem>();
}

public class CardItem
{
    public int CardItemId {get; set;}
    public int ProductId{ get; set; }
    public Product Product { get; set; } = null!;
    public int CardId { get; set; }
    public Card Card { get; set; } = null!;
    public int Quantity { get; set; }

}