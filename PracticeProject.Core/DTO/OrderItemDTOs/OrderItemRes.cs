using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.DTO.ProductDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.OrderItemDTOs
{
    public class OrderItemRes
    {
        public Guid Id { get; set; }
        //public Guid? OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public OrderProductResponse? Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public static class OrderItemExtensions
    {
        public static OrderItemRes ToOrderItemRes(this OrderItem item)
        {
            return new OrderItemRes
            {
                Id = item.Id,
                //OrderId = item.OrderId,
                ProductId = item.ProductId,
                Product = item.Product?.ToOrderProductResponse(),
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                TotalPrice = item.UnitPrice * item.Quantity
            };
        }
    }
}
