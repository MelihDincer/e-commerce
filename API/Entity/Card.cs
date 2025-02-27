namespace API.Entity;

public class Card 
{
    public int CardId {get; set;}
    public string CustomerId {get; set;} = null!;
    public List<CardItem> CardItems { get; set; } = new List<CardItem>();
    public void AddItem(Product product, int quantity) 
    {
        var item = CardItems.Where(c => c.ProductId == product.ProductId).FirstOrDefault();
        if(item == null)
        {
            CardItems.Add(new CardItem {Product = product, Quantity = quantity});
        }
        else
        {
            item.Quantity += quantity;
        }
    }

    public void DeleteItem(int productId, int quantity)
    {
        var item = CardItems.Where(c => c.ProductId == productId).FirstOrDefault();
        if(item == null)
        {
            return;
        }
        item.Quantity -= quantity;
        if(item.Quantity == 0)
        {
            CardItems.Remove(item);
        }
    }
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