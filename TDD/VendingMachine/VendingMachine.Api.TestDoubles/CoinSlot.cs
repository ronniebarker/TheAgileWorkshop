using System;



namespace VendingMachine.Api.TestDoubles
{
	public class CoinSlot : ICoinSlot
	{
		public event EventHandler<EventArgs> CoinInsertedEvent;



		public void InsertCoin( decimal value )
		{
			CoinCount++;
			Value += value;

			if( CoinInsertedEvent != null )
			{
				CoinInsertedEvent( this, new EventArgs() );
			}
		}



		public int CoinCount { get; private set; }
		public decimal Value { get; private set; }
	}
}