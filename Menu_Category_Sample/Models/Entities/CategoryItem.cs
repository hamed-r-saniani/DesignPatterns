namespace Menu_Category_Sample.Models.Entities
{
    public class CategoryItem : CategoryComponent
    {
        public string Link { get; set; } // because our site menues when we have leaf we can click on them no in composite

        public CategoryItem(string name,string link)
        {
            Name = name;
            Link = link;
        }

        public CategoryItem() // For EF
        {
            
        }

        public override void Add(CategoryComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            string li = @$"<li> <a href='{Link}'> {Name}  </a> </li>";
            return li;
        }
    }
}
