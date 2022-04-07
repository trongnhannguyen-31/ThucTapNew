﻿namespace Phoenix.Shared.OrderDetail
{
	public class OrderDetailDto
	{
		public int Id { get; set; }

		public int Order_Id { get; set; }

		public int ProductSKU_Id { get; set; }

		public string Product_Name { get; set; }

		public double? Price { get; set; }

		public int? Quantity { get; set; }

		public double? Total { get; set; }
	}
}
