using System;



namespace VendingMachine.Api.TestDoubles
{
	public class CoinSlot : ICoinSlot
	{
		public event EventHandler<EventArgs> CoinInsertedEvent;



		public void InsertCoin()
		{
			CoinCount++;

			if( CoinInsertedEvent != null )
			{
				CoinInsertedEvent( this, new EventArgs() );
			}
		}



		public int CoinCount { get; private set; }
	}
}