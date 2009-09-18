using System;



namespace VendingMachine.Api.TestDoubles
{
	public class Button : IButton
	{
		public event EventHandler<EventArgs> RejectButtonPressed;



		public void PressRejectButton()
		{
			RejectButtonPressed( this, new EventArgs() );
		}
	}
}