namespace Composite.CompositeClass
{
    public abstract class Component
    {
        protected string Name { get; set; } //can public too // can anything that we need

        public Component(string name)
        {
            Name = name;
        }

        // Add and Remove is manager methods and optional and can define another methods and only in Composite can implement because leaf is endpoint and dont have any chlid
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int startDepth);
    }
}
