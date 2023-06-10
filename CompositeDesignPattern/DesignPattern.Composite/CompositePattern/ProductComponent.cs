namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProductComponent(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int TotalCount()
        {
            return 1;
        }

        public string Display()
        {
            return $"<li class='list-group-item'>{Name}</li>";
        }
    }
}
