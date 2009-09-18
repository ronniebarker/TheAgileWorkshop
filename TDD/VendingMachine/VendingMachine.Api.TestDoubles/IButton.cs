using System;



namespace VendingMachine.Api.TestDoubles
{
	public interface IButton
	{
		event EventHandler<EventArgs> RejectButtonPressed;
	}
}