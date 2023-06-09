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

}


/// <summary>
/// BlogComment.Data.ViewModel
/// </summary>
public class CommentVm : DefaultVm
{

    /// <summary>
    /// Comment.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Blog.Id
    /// </summary>
    public string BlogId { get; set; }

    /// <summary>
    /// Comment.Age
    /// </summary>
    public string Age { get; set; }
}

/// <summary>
/// CreateComment.DataTransferObject
/// </summary>
public class CreateCommentDto
{
    /// <summary>
    /// UserdId
    /// </summary>
    public string UserdId { get; set; } = string.Empty;
    /// <summary>
    /// InstitutionId
    /// </summary>
    public string InstitutionId { get; set; } = string.Empty;
    /// <summary>
    /// RoleId
    /// </summary>
    public string RoleId { get; set; } = string.Empty;
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; } = string.Empty;
    /// <summary>
    /// BlogId
    /// </summary>
    public string BlogId { get; set; } = string.Empty;
}

/// <summary>
/// UpdateComment.DataTransferObject
/// </summary>
public class UpdateCommentDto : CreateCommentDto
{
    /// <summary>
    /// Id
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// IsActive
    /// </summary>
    public int IsActive { get; set; }
}