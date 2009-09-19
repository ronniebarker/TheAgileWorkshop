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



		[Test]
		public void Should_accept_number_1()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "B1" );
		}



		[Test]
		public void Should_accept_number_2()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Two );
			Hardware.TouchPanel.Code.ShouldEqual( "B2" );
		}



		[Test]
		public void Should_accept_number_3()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Three );
			Hardware.TouchPanel.Code.ShouldEqual( "B3" );
		}



		[Test]
		public void Should_accept_number_4()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Four );
			Hardware.TouchPanel.Code.ShouldEqual( "B4" );
		}



		[Test]
		public void Should_accept_number_5()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Five );
			Hardware.TouchPanel.Code.ShouldEqual( "B5" );
		}



		[Test]
		public void Should_accept_number_6()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Six );
			Hardware.TouchPanel.Code.ShouldEqual( "B6" );
		}



		[Test]
		public void Should_accept_number_7()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Seven );
			Hardware.TouchPanel.Code.ShouldEqual( "B7" );
		}



		[Test]
		public void Should_accept_number_8()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Eight );
			Hardware.TouchPanel.Code.ShouldEqual( "B8" );
		}



		[Test]
		public void Should_accept_number_9()
		{
			TestHardware.TouchPanel.PressB();
			TestHardware.TouchPanel.Press( TouchPanelNumber.Nine );
			Hardware.TouchPanel.Code.ShouldEqual( "B9" );
		}
	}
}