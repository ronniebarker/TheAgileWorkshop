using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_the_vendor_ejects_a_product : FixtureBase
	{
		[Test]
		public void Should_receive_a_product_fell_event_from_the_tray()
		{
			bool productFell = false;

			Hardware.Tray.ProductFellEvent += ( s, e ) => productFell = true;

			Hardware.Vendor.Vend();

			productFell.ShouldBeTrue();
		}
	}
}