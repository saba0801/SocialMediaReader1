using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaReader1.Models.SocialMedia.Facebook
{
    

    public class Posts
    {
        public dynamic jsonObj { get; set; }
        public Posts(dynamic json)
        {
            jsonObj = json;
            id = jsonObj.id;
            name = jsonObj.name;
        }
        public string id { get; set; }
        public string name { get; set; }
    }
}