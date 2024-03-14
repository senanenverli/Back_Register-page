using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.viewModel;

public class HomeViewModel
{
    public List<Shipping> Shippings { get; set; }
}