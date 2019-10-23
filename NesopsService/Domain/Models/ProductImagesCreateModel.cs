using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class ProductImagesCreateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string ThumbnailPath { get; set; }

        public string Path { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
