namespace SampleBlazorUI.Shared
{
	public class OrderItem
	{

		public int Id { get; set; }

		public int OrderId { get; set; }

		public string Product { get; set; }

		public int Quantity { get; set; }

		public decimal PriceUSD { get; set; }

		public decimal TotalPrice { get { return Quantity * PriceUSD; } }


	}
}