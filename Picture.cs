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

/// <summary>
/// BlogPicture.Data.ViewModel
/// </summary>
public class PictureVm : DefaultVm
{
    /// <summary>
    /// Blog.Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Picture.Url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Blog.Id
    /// </summary>
    public string BlogId { get; set; }

    /// <summary>
    /// Picture.Age
    /// </summary>
    public string Age { get; set; }
}

/// <summary>
/// CreatePicture.DataTransferObject
/// </summary>
public class CreatePictureDto
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
    /// Url
    /// </summary>
    public string Url { get; set; } = string.Empty;
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// BlogId
    /// </summary>
    public string BlogId { get; set; } = string.Empty;
}

/// <summary>
/// UpdatePicture.DataTransferObject
/// </summary>
public class UpdatePictureDto : CreatePictureDto
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