using System.ComponentModel.DataAnnotations;

namespace CRMApp.Models;

public class Order
{
    public int Id { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string ShippingAddress { get; set; }

    public bool IsShipped { get; set; }

    public DateTime? ShippedDate { get; set; }

    public Customer Customer { get; set; }
}
