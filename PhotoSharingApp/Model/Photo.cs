﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApp.Model
{
    public class Photo
    {
        public int PhotoID { get; set; }
        [Required]
        public string Title { get; set; }
        [DisplayName("Picture")]

        public Byte[] PhotoFile { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode =true)]
        public DateTime CreatedDate { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string ImageMimeType { get; set; }
    }
}