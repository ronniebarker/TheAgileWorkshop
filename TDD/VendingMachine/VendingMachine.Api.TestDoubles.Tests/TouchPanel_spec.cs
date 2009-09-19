using System;
using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class TouchPanel_spec_ : FixtureBase
	{
		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void Should_throw_invalid_operation_exception_if_number_entered_first()
		{
			TestHardware.TouchPanel.Press( TouchPanelNumber.Four );
		}



		[Test]
		public void Should_accept_number_0()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Zero );
			Hardware.TouchPanel.Code.ShouldEqual( "B0" );
		}
	}
}