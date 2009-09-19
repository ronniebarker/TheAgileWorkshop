using System;



namespace VendingMachine.Api.TestDoubles
{
	public class VendorWithTray : IVendor, ITray
	{
		public event EventHandler<EventArgs> ProductFellEvent;



		public void Vend()
		{
			ProductFellEvent( this, new EventArgs() );
		}
	}
}