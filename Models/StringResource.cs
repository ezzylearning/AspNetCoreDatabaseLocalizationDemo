using System;
using System.Collections.Generic;

#nullable disable

namespace AspNetCoreDatabaseLocalizationDemo.Models
{
    public partial class StringResource
    {
        public int Id { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Language Language { get; set; }
    }
}
