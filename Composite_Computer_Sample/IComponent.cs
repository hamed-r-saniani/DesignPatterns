namespace Composite_Computer_Sample
{
    public interface IComponent
    {
        string? Name { get; set; }
        int Price { get; set; }
        int DisplayPrice();
    }
}
