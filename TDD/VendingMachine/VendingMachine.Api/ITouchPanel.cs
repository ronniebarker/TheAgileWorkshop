using System;



namespace VendingMachine.Api
{
	public interface ITouchPanel
	{
		event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;
	}







	public class CodeEnteredEventArgs : EventArgs
	{
		public CodeEnteredEventArgs( string code )
		{
			Code = code;
		}



		public string Code { get; private set; }
	}
}