using System.ComponentModel;
using System.Text;

namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<IComponent> _components;
        public ICollection<IComponent> Components => _components;

        public ProductComposite(string name, int id)
        {
            Name = name;
            Id = id;
            _components = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public int TotalCount()
        {
            return _components.Sum(x => x.TotalCount());
        }

        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name} ({TotalCount()})</div>");
            stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
            foreach (var item in _components)
            {
                stringBuilder.Append(item.Display());
            }
            stringBuilder.Append("</lu>");
            return stringBuilder.ToString();
        }
    }
}
