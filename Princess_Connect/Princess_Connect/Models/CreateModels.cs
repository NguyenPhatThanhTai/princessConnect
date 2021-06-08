using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Princess_Connect.Models
{
    public partial class CreateModels
    {
        public string MaNhanVat { set; get; }
        public string TenNhanVat { set; get; }
        public HttpPostedFileBase ImageFile { set; get; }
        public string HinhAnhNhanVat { set; get; }
        public string CotTruyen { set; get; }
        public string AnhCotTruyen { set; get; }
    }
}