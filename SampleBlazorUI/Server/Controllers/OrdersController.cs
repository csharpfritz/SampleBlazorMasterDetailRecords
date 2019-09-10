using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleBlazorUI.Shared;

namespace SampleBlazorUI.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{

		private static readonly List<Order> _Orders = new List<Order> {

				new Order {
					Id=1,
					CustomerName="Joe Bag O'Donuts"
				},

				new Order {
					Id=2,
					CustomerName="Mary Contrary"
				}

			};

		private static readonly List<OrderItem> _Items = new List<OrderItem>
		{

			new OrderItem {
				Id=1,
				OrderId=1,
				Product="Widgets",
				Quantity=2,
				PriceUSD=7.99M
			},
			new OrderItem {
				Id=2,
				OrderId=1,
				Product="Stuff",
				Quantity=1,
				PriceUSD=5.99M
			},
			new OrderItem {
				Id=3,
				OrderId=2,
				Product="Widgets",
				Quantity=1,
				PriceUSD=7.99M
			}

		};

		[HttpGet]
		public IActionResult GetOrders() {

			return Ok(_Orders);

		}

		[HttpGet("{id}")]
		public IActionResult GetItemsForOrder(int id) {

			return Ok(_Items.Where(i => i.OrderId == id).ToArray());

		}

	}


}