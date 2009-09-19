using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_someone_enters_a_letter_and_number_on_the_touch_panel : FixtureBase
	{
		[Test]
		public void Should_raise_a_code_entered_event()
		{
			string codeEntered = "";

			Hardware.TouchPanel.CodeEnteredEvent += ( s, e ) => codeEntered = e.Code;

			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Four );

			codeEntered.ShouldEqual( "B4" );
		}
	}
}