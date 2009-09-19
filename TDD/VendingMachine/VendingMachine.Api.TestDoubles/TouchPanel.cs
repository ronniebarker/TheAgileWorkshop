using System;



namespace VendingMachine.Api.TestDoubles
{
	public class TouchPanel : ITouchPanel
	{
		public event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;
		public string Code { get; private set; }



		public void PressB()
		{
			Code += "B";
		}



		protected virtual void OnCodeEntered()
		{
			if( CodeEnteredEvent != null )
			{
				CodeEnteredEvent( this, new CodeEnteredEventArgs( Code ) );
			}
		}



		public void Press( TouchPanelNumber number )
		{
			if( Code == null )
			{
				throw new InvalidOperationException( "Code must start with a letter" );
			}
			Code += ( (int)number ).ToString();
			OnCodeEntered();
		}
	}
}