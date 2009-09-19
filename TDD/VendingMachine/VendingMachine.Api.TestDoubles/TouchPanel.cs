using System;



namespace VendingMachine.Api.TestDoubles
{
	public class TouchPanel : ITouchPanel
	{
		private string code;
		public event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;



		public void PressB()
		{
			code += "B";
		}



		public void Press4()
		{
			code += "4";
			CodeEnteredEvent( this, new CodeEnteredEventArgs( code ) );
		}
	}
}