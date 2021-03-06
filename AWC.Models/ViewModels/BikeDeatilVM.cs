﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AWC.Models.ViewModels
{
    public class BikeDetailsVM
    {
        public int ProductId { get; set; }
        public int? ProductSubCategoryId { get; set; }
        public int? ProductModelId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public byte[] Image { get; set; }
        public decimal? ListPrice { get; set; }
    }
}
