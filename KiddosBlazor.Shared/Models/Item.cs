using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiddosBlazor.Shared.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Onderwerp { get; set; }

        public string Teaser { get; set; }

        public string Body { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public List<Image> Images { get; set; }

        public List<Document> Documents { get; set; }

        public List<String> Tags { get; set; }

    }
}