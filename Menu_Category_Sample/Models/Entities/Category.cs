namespace Menu_Category_Sample.Models.Entities
{
    public class Category : CategoryComponent
    {
        readonly List<CategoryComponent> _menuComponents = new List<CategoryComponent>();

        public ICollection<CategoryComponent> MenuItems => _menuComponents; // for connect 1 to n to EF

        public Category(string name)
        {
            Name = name;
        }
        public Category() // For use with EF Core
        {
            
        }

        public override void Add(CategoryComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(CategoryComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override string Print()
        {
            string ul = @$"<ul> {Name}";
            foreach (var menuComponent in _menuComponents)
            {
                ul += menuComponent.Print();
            }
            ul += @$"</ul> ";
            return ul;
        }
    }
}
