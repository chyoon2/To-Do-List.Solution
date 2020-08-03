using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }
    public int ItemId {get; set;}
    public bool Complete {get; set;} = false;
    public string Description {get; set;}
    public ICollection<CategoryItem> Categories { get;}
  }
}