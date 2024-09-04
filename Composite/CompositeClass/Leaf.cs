namespace Composite.CompositeClass
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {         
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int startDepth)
        {
            Console.WriteLine(new string('-', startDepth) + Name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
