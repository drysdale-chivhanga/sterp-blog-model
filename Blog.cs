using Sterp.General.Model;
using System.ComponentModel.DataAnnotations;

namespace Sterp.Blog.Model;

/// <summary>
/// BlogInformation.Data.Transfer.Object
/// </summary>
public class DtoBlog : DefaultRaw
{
    /// <summary>
    /// Blog.Name
    /// </summary>
    [StringLength(maximumLength: 32, MinimumLength = 3)]
    public string Name { get; set; }

    /// <summary>
    /// Blog.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Blog.Category.Id
    /// </summary>
    public long CategoryId { get; set; }
}

/// <summary>
/// BlogInformation.Data.ViewModel
/// </summary>
public class BlogVm : DefaultVm
{
    /// <summary>
    /// Blog.Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Blog.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Blog.Category.Id
    /// </summary>
    public string CategoryId { get; set; }
}