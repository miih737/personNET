﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class SearchResult_Video : SearchResult
    {
        public string DirVideo { get; set; }
        public string User { get; set; }
        public string Title { get; set; }
        public string UploadDate { get; set; }
    }
}