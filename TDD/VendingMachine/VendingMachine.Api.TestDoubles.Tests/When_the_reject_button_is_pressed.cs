using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_the_reject_button_is_pressed : FixtureBase
	{
		[Test]
		public void Should_Receive_the_RejectButtonPressed_event()
		{
			bool rejectButtonEventWasFired = false;
			Hardware.RejectButton.RejectButtonPressed += ( s, e ) => rejectButtonEventWasFired = true;

			TestHardware.RejectButton.PressRejectButton();

			rejectButtonEventWasFired.ShouldBeTrue();
		}
	}
}