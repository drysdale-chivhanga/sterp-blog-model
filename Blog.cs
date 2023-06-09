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
    /// PictureUrl
    /// </summary>
    public string PictureUrl { get; set; }

    /// <summary>
    /// Blog.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Blog.Category.Id
    /// </summary>
    public long CategoryId { get; set; }

    /// <summary>
    /// Blog.CanComment
    /// </summary>
    public int CanComment { get; set; }

    /// <summary>
    /// Blog.IsFeaturing
    /// </summary>
    public int IsFeaturing { get; set; }
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

    /// <summary>
    /// Blog.CanComment
    /// </summary>
    public int CanComment { get; set; }
    /// <summary>
    /// PictureUrl
    /// </summary>
    public string PictureUrl { get; set; }

    /// <summary>
    /// Blog.IsFeaturing
    /// </summary>
    public int IsFeaturing { get; set; }

    /// <summary>
    /// Blog.Age
    /// </summary>
    public string Age { get; set; }
}

/// <summary>
/// CreateBlog.DataTransferObject
/// </summary>
public class CreateBlogDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Blog.Description
    /// </summary>
    public string Description { get; set; } = string.Empty;
    /// <summary>
    /// Blog.CategoryId
    /// </summary>
    public string CategoryId { get; set; } = string.Empty;
    /// <summary>
    /// Blog.PictureUrl
    /// </summary>
    public string BlogUrl { get; set; } = string.Empty;
    /// <summary>
    /// Blog.Logged.UserdId
    /// </summary>
    public string UserdId { get; set; } = string.Empty;
    /// <summary>
    /// Blog.Logged.InstitutionId
    /// </summary>
    public string InstitutionId { get; set; } = string.Empty;
    /// <summary>
    /// Blog.Logged.RoleId
    /// </summary>
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    /// Blog.CanComment
    /// </summary>
    public int CanComment { get; set; }

    /// <summary>
    /// Blog.IsFeaturing
    /// </summary>
    public int IsFeaturing { get; set; }
}


/// <summary>
/// UpdateBlog.DataTransferObject
/// </summary>
public class UpdateBlogDto : CreateBlogDto
{
    /// <summary>
    /// Blog.ID
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// Blog.ActiveStatus
    /// </summary>
    public int IsActive { get; set; }
}

/// <summary>
/// BlogWithComments.ViewModel
/// </summary>
public class BlogWithCommentsVm
{
    /// <summary>
    /// Category
    /// </summary>
    public CategoryVm Category { get; set; }
    /// <summary>
    /// Blog
    /// </summary>
    public BlogVm Blog { get; set; }
    /// <summary>
    /// Comments
    /// </summary>
    public List<CommentVm> Comments { get; set; }
    /// <summary>
    /// Pictures
    /// </summary>
    public List<PictureVm> Pictures { get; set; }
}
