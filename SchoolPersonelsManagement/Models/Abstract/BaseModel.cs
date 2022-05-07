using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPersonelsManagement.Models.Abstract
{
    public class BaseModel
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String ImgUrl { get; set; }
    }
}
