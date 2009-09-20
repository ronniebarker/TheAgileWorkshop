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
			if( ! CanVend( productNumber ) )
			{
				throw new InvalidOperationException( "Cannot vend" );
			}

			if( ProductFellEvent != null )
			{
				ProductFellEvent( this, new EventArgs() );
			}
		}



		public int GetStockLevel( int productNumber )
		{
			if( ! stock.ContainsKey( productNumber ) )
			{
				throw new InvalidOperationException();
			}
			return stock[ productNumber ];
		}



		public bool CanVend( int productNumber )
		{
			return ( stock.ContainsKey( productNumber ) ) && ( stock[ productNumber ] > 0 );
		}



		public void SetStockLevel( int productCode, int stockLevel )
		{
			stock[ productCode ] = stockLevel;
		}
	}
}