﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string User { get; set; }
        [Required]
        [StringLength(250)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public int PhotoID { get; set; }
        public virtual Photo Photo { get; set; }
       
}
}