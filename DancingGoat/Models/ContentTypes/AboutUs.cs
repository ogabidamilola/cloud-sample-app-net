// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace DancingGoat.Models
{
    public partial class AboutUs
    {
        public const string Codename = "about_us";
        public const string FactsCodename = "facts";
        public const string UrlPatternCodename = "url_pattern";

        public IEnumerable<object> Facts { get; set; }
        public string UrlPattern { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}