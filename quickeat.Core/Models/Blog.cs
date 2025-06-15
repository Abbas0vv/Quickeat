using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickeat.Core.Interfaces;

namespace quickeat.Core.Models;

public class Blog : IEntity
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
    public string AuthorId { get; set; }
    public string ImageUrl { get; set; }

    public ApplicationUser Author { get; set; }
}
