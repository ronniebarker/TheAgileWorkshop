namespace VendingMachine.Api.TestDoubles
{
	public class Display : IDisplay
	{
		public string CurrentMessage { get; private set; }



		public void SetMessage( string message )
		{
			CurrentMessage = message;
		}
	}
}