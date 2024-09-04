using Composite.CompositeClass;

Component component = new Composite.CompositeClass.Composite("Root Item", new List<Component>
{
    new Leaf("Leaf 1"),
    new Composite.CompositeClass.Composite("Composite 1",new List<Component>
    {
        new Leaf("Leaf 1-1"),
        new Leaf("Leaf 1-2"),
        new Composite.CompositeClass.Composite("Composite 1-1",new List<Component>
        {
            new Leaf("Leaf 1-1-1"),
            new Composite.CompositeClass.Composite("Empty Composite")
        })
    }),
    new Leaf("Leaf 2"),
    new Leaf("Leaf 3"),
    new Leaf("Leaf 4")
});

component.Display(1);
