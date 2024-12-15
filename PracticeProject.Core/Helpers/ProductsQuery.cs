using PracticeProject.Core.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Helpers
{
    public class ProductsQuery
    {
        public string? Category {  get; set; }
        [Range(0, int.MaxValue)]
        public int? MinPrice { get; set; }
        [Range(0, int.MaxValue)]
        [PriceRangeValidator(nameof(MinPrice), ErrorMessage = "'MaxPrice' should be greater than 'MinPrice'")]
        public int? MaxPrice { get; set; }
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
