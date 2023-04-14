using Sterp.General.Model;
using System.ComponentModel.DataAnnotations;

namespace Sterp.Blog.Model;

/// <summary>
/// BlogCategory.Data.Transfer.Object
/// </summary>
public class DtoCategory : DefaultRaw
{
    /// <summary>
    /// Category.Name
    /// </summary>
    [StringLength(maximumLength: 32, MinimumLength = 3)]
    public string Name { get; set; }

    /// <summary>
    /// Category.Description
    /// </summary>
    public string Description { get; set; }
}