using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projectef.Models
{
  public class Category
  {
    public Guid CategoryId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Weight { get; set; }
    public virtual ICollection<Task>? Tasks { get; set; }
  }
}