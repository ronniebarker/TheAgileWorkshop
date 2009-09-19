using System;



namespace VendingMachine.Api
{
	public interface ITouchPanel
	{
		event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;
		string Code { get; }
	}
}