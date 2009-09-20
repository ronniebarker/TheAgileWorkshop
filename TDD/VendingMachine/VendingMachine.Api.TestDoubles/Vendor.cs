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
			CheckVendAndThrow( productNumber );

			if( ProductFellEvent != null )
			{
				ProductFellEvent( this, new EventArgs() );
			}
		}



		public int GetStockLevel( int productNumber )
		{
			CheckVendAndThrow( productNumber );
			return stock[ productNumber ];
		}



		public bool CanVend( int productNumber )
		{
			return CheckVend( productNumber ) == null;
		}



		private Exception CheckVend( int productNumber )
		{
			if( ( productNumber < 0 ) || ( productNumber > 49 ) )
			{
				return new InvalidOperationException( "Invalid product code" );
			}
			if( ! stock.ContainsKey( productNumber ) )
			{
				return new InvalidOperationException( "Unregistered product code" );
			}

			if( stock[ productNumber ] <= 0 )
			{
				return new InvalidOperationException( "No Stock" );
			}

			return null;
		}



		private void CheckVendAndThrow( int productNumber )
		{
			var exception = CheckVend( productNumber );
			if( exception != null )
			{
				throw exception;
			}
		}



		public void SetStockLevel( int productCode, int stockLevel )
		{
			stock[ productCode ] = stockLevel;
		}
	}
}