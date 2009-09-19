using System;



namespace VendingMachine.Api.TestDoubles
{
	public class TouchPanel : ITouchPanel
	{
		public event EventHandler<CodeEnteredEventArgs> CodeEnteredEvent;

		private TouchPanelLetter? codeLetter;
		private TouchPanelNumber? codeNumber;



		public string Code
		{
			get { return codeLetter.ToString() + ( (int)codeNumber ); }
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
			if( codeLetter == null )
			{
				throw new InvalidOperationException( "Code must start with a letter" );
			}
			if( codeNumber != null )
			{
				throw new InvalidOperationException( "Code already has a number" );
			}
			codeNumber = number;
			OnCodeEntered();
		}



		public void Press( TouchPanelLetter letter )
		{
			if( codeLetter != null )
			{
				throw new InvalidOperationException( "Code can only start with a letter" );
			}
			codeLetter = letter;
		}



		public void Press( TouchPanelButton button )
		{
			switch( button )
			{
				case TouchPanelButton.Clear:
					codeNumber = null;
					codeLetter = null;
					break;
			}
		}
	}
}