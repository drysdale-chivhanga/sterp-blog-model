using Sterp.General.Model;
using System.ComponentModel.DataAnnotations;

namespace Sterp.Blog.Model;

/// <summary>
/// BlogPicture.Data.Transfer.Object
/// </summary>
public class DtoPicture : DefaultRaw
{
    /// <summary>
    /// Blog.Name
    /// </summary>
    [StringLength(maximumLength: 32, MinimumLength = 3)]
    public string Name { get; set; }

    /// <summary>
    /// Blog.Url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Blog.Id
    /// </summary>
    public long BlogId { get; set; }
}