using System;



namespace VendingMachine.Api
{
	public interface ITray
	{
		event EventHandler<EventArgs> ProductFellEvent;
	}
}