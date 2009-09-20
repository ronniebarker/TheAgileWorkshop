using System;
using System.Collections.Generic;



namespace VendingMachine.Api.TestDoubles
{
	public class VendorWithTray : IVendor, ITray
	{
		private readonly Dictionary<int, int> stock = new Dictionary<int, int>();
		public event EventHandler<EventArgs> ProductFellEvent;



		public void Vend( int productNumber )
		{
			if( ( ! stock.ContainsKey( productNumber ) ) || ( stock[ productNumber ] < 1 ) )
			{
				throw new InvalidOperationException( "Out of stock" );
			}

			if( ProductFellEvent != null )
			{
				ProductFellEvent( this, new EventArgs() );
			}
		}



		public void SetStockLevel( int productCode, int stockLevel )
		{
			stock[ productCode ] = stockLevel;
		}
	}
}