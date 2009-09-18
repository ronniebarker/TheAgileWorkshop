using System;



namespace VendingMachine.Api.TestDoubles
{
	public class CoinSlot : ICoinSlot
	{
		public event EventHandler<EventArgs> CoinInsertedEvent;



		public void InsertCoin()
		{
			CoinInsertedEvent( this, new EventArgs() );
		}
	}
}