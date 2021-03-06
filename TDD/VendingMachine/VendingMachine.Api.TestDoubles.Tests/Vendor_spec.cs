using System;
using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class Vendor_spec : FixtureBase
	{
		[Test]
		public void Should_accept_product_codes_from_0_to_49()
		{
			for( int i = 0 ; i <= 49 ; i++ )
			{
				TestHardware.Vendor.SetStockLevel( i, 1 );
				Hardware.Vendor.Vend( i );
			}
		}



		[Test]
		public void Should_Should_report_back_stock_level()
		{
			TestHardware.Vendor.SetStockLevel( 5, 17 );
			Hardware.Vendor.GetStockLevel( 5 ).ShouldEqual( 17 );
		}



		[Test]
		[ExpectedException( typeof( InvalidOperationException ), ExpectedMessage = "Invalid product code" )]
		public void When_getting_stock_level_Should_throw_invalid_operation_exception_for_invalid_product_code_50()
		{
			Hardware.Vendor.GetStockLevel( 50 );
		}



		[Test]
		[ExpectedException( typeof( InvalidOperationException ), ExpectedMessage = "Invalid product code" )]
		public void When_getting_stock_level_Should_throw_invalid_operation_exception_for_invalid_product_code_minus_1()
		{
			Hardware.Vendor.GetStockLevel( -1 );
		}



		[Test]
		public void Should_be_able_to_check_if_vending_is_possible_for_a_product()
		{
			TestHardware.Vendor.SetStockLevel( 17, 3 );
			Hardware.Vendor.CanVend( 3 ).ShouldBeFalse();
			Hardware.Vendor.CanVend( 17 ).ShouldBeTrue();
		}
	}
}