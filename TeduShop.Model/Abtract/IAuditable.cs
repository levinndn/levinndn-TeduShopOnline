using System;

namespace TeduShop.Model.Abtract
{
    internal interface IAuditable
    {
        DateTime?     CreateDate { set; get; }
        string CreateBy { set; get; }
        bool Status { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        bool HomeFlag { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}