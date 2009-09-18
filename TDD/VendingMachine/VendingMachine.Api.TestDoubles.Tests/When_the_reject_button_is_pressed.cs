using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_the_reject_button_is_pressed
	{
		[Test]
		public void Should_fire_the_RejectButtonPressed_event()
		{
			var rejectButtonMock = new Button();
			IButton rejectButton = rejectButtonMock;
			bool fired = false;
			rejectButton.RejectButtonPressed += ( s, e ) => fired = true;

			rejectButtonMock.PressRejectButton();

			fired.ShouldBeTrue();
		}
	}
}