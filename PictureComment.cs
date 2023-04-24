using Sterp.General.Model;

namespace Sterp.Blog.Model;

/// <summary>
/// BlogPictureComment.Data.Transfer.Object
/// </summary>
public class DtoPictureComment : DefaultRaw
{

    /// <summary>
    /// PictureComment.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Picture.Id
    /// </summary>
    public long PictureId { get; set; }

}


/// <summary>
/// BlogPictureComment.Data.ViewModel
/// </summary>
public class PictureCommentVm : DefaultVm
{

    /// <summary>
    /// PictureComment.Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Picture.Id
    /// </summary>
    public string PictureId { get; set; }
}