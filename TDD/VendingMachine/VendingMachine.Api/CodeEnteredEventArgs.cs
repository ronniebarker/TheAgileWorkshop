using System;



namespace VendingMachine.Api
{
	public class CodeEnteredEventArgs : EventArgs
	{
		public CodeEnteredEventArgs( string code )
		{
			Code = code;
		}



		public string Code { get; private set; }
	}
}