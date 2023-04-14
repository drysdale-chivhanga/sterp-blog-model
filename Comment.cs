using Sterp.General.Model;

namespace Sterp.Blog.Model;

/// <summary>
/// BlogComment.Data.Transfer.Object
/// </summary>
public class DtoComment : DefaultRaw
{

    /// <summary>
    /// Comment.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Blog.Id
    /// </summary>
    public long BlogId { get; set; }

    /// <summary>
    /// Blog.Parent.Comment.Id
    /// </summary>
    public long ParentId { get; set; }
}