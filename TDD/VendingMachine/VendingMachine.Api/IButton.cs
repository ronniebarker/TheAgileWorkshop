using System;



namespace VendingMachine.Api
{
	public interface IButton
	{
		event EventHandler<EventArgs> RejectButtonPressed;
	}
}