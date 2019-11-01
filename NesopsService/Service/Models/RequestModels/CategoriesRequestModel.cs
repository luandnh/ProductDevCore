using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Service.Models.RequestModels
{
    public class CategoriesRequestModel : RequestModelBase
    {
        public IList<string> relates { get; set; } = new List<string>();
    }
}
