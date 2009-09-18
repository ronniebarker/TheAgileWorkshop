using System;



namespace VendingMachine.Api
{
	public interface ICoinSlot
	{
		event EventHandler<EventArgs> CoinInsertedEvent;
		int CoinCount { get; }
	}
}