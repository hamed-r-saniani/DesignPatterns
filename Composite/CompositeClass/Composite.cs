namespace Composite.CompositeClass
{
    public class Composite : Component
    {
        private List<Component> components = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public Composite(string name, List<Component> components) : base(name)
        {
            foreach(var component in components)
            {
                Add(component);
            }
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display(int startDepth)
        {
            Console.WriteLine(new string('-', startDepth) + Name + ':');
            foreach (var component in components)
            {
                component.Display(startDepth + 1);
            }
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
