namespace Composite_Computer_Sample
{
    public class Composite : IComponent
    {      
        public string? Name { get; set; }
        public int Price { get; set; }

        List<IComponent> components = new List<IComponent>();

        public Composite(string name,int price)
        {
            Name = name;
            Price = price;
        }

        public int DisplayPrice()
        {
            int resultPrice = Price;
            foreach (var component in components)
            {
                resultPrice += component.DisplayPrice();
            }
            Console.WriteLine(Name + "(Result Price): " + resultPrice);

            return resultPrice;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
    }
}
