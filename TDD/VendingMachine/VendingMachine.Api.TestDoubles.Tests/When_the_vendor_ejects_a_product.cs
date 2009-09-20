using System;
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
			TestHardware.Vendor.SetStockLevel( 1, 1 );

			Hardware.Vendor.Vend( 1 );

			productFell.ShouldBeTrue();
		}



		[Test]
		[ExpectedException( typeof( InvalidOperationException ), ExpectedMessage = "Unregistered product code" )]
		public void Should_raise_invalid_operation_exception_if_no_stock_ever_added()
		{
			Hardware.Vendor.Vend( 1 );
		}

	}
}