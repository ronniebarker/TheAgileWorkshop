using System;



namespace VendingMachine.Api
{
	public interface ITouchPanel
	{
		event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;
		string Code { get; }
	}







	public class CodeEnteredEventArgs : EventArgs
	{
		public CodeEnteredEventArgs( string code )
		{
			Code = code;
		}



		public string Code { get; private set; }
	}







	public enum TouchPanelNumber
	{
		Zero = 0,
		Four = 4,
	}
}