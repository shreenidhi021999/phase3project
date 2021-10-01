using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace phase3proj.Model
{
    public partial class LaptopDetails
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string GraphicCard { get; set; }
        public int Price { get; set; }
        public int SId { get; set; }
    }
}
