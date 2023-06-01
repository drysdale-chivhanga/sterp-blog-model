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

    /// <summary>
    /// Category.FileUrl
    /// </summary>
    public string FileUrl { get; set; }

    /// <summary>
    /// Category.IsBlog
    /// </summary>
    public bool IsBlog { get; set; } = true;

    /// <summary>
    /// Category.IsFeaturing
    /// </summary>
    public bool IsFeaturing { get; set; } = false;
}

/// <summary>
/// Category.View.Model
/// </summary>
public class CategoryVm : DefaultVm
{
    /// <summary>
    /// Category.Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Category.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Category.FileUrl
    /// </summary>
    public string FileUrl { get; set; }
    /// <summary>
    /// Category.IsBlog
    /// </summary>
    public int IsBlog { get; set; }

    /// <summary>
    /// Category.IsFeaturing
    /// </summary>
    public int IsFeaturing { get; set; }
}

/// <summary>
/// CreateCategory.DataTransferObject
/// </summary>
public class CreateCategoryDto
{
    /// <summary>
    /// Category.Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Category.FileUrl
    /// </summary>
    public string FileUrl { get; set; } = string.Empty;

    /// <summary>
    /// Category.Description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Category.UserdId
    /// </summary>
    public string UserdId { get; set; } = string.Empty;

    /// <summary>
    /// Category.InstitutionId
    /// </summary>
    public string InstitutionId { get; set; } = string.Empty;

    /// <summary>
    /// Category.RoleId
    /// </summary>
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    /// Category.IsBlog
    /// </summary>
    public int IsBlog { get; set; }

    /// <summary>
    /// Category.IsFeaturing
    /// </summary>
    public int IsFeaturing { get; set; }
}


/// <summary>
///  UpdateCategory.DataTransferObject
/// </summary>
public class UpdateCategoryDto : CreateCategoryDto
{
    /// <summary>
    /// Category.Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Category.IsActive
    /// </summary>
    public int IsActive { get; set; }
}