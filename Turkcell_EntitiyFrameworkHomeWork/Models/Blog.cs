using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell_EntitiyFrameworkHomeWork.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public bool BlogStatıs { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
        public Category Category { get; set; }
        public Writer Writer { get; set; }
    }
}
