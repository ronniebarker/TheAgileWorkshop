using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_interacting_with_the_user : FixtureBase
	{
		[Test]
		public void Should_be_able_to_present_the_user_with_a_welcome_message()
		{
			Hardware.Display.SetMessage( "Welcome" );

			TestHardware.Display.CurrentMessage.ShouldEqual( "Welcome" );
		}
	}
}