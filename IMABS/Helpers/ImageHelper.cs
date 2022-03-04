using System;

namespace IMABS.Helpers
{
    public class ImageHelper
    {
        public static string GetImage(string ImgGUID)
        {
            var onlyGuid = ImgGUID.Contains("Edit") ? ImgGUID.Split("Edit/")[1] : ImgGUID;
            if (onlyGuid.Contains("/"))
            {
                return onlyGuid;
            }
            Guid guid = new Guid(onlyGuid);

            if (guid == Guid.Empty)
            {
                return null;
            }

            return $"/getattachment/{guid}/attachment.aspx";
        }
    }
}
