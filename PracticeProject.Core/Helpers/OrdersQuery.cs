using PracticeProject.Core.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Helpers
{
    public class OrdersQuery
    {
        public string? Status { get; set; }
        [Range(1, int.MaxValue)]
        public int? TotalMinPrice { get; set; }
        [Range(1, int.MaxValue)]
        [PriceRangeValidator(nameof(TotalMinPrice), ErrorMessage = "'TotalMaxPrice' should be greater than 'TotalMinPrice'")]
        public int? TotalMaxPrice { get; set; }
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public DateTime? OrdersBefore { get; set; }
    }
}
