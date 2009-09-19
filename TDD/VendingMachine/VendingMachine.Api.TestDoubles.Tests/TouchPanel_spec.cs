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
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Zero );
			Hardware.TouchPanel.Code.ShouldEqual( "B0" );
		}



		[Test]
		public void Should_accept_number_1()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "B1" );
		}



		[Test]
		public void Should_accept_number_2()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Two );
			Hardware.TouchPanel.Code.ShouldEqual( "B2" );
		}



		[Test]
		public void Should_accept_number_3()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Three );
			Hardware.TouchPanel.Code.ShouldEqual( "B3" );
		}



		[Test]
		public void Should_accept_number_4()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Four );
			Hardware.TouchPanel.Code.ShouldEqual( "B4" );
		}



		[Test]
		public void Should_accept_number_5()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Five );
			Hardware.TouchPanel.Code.ShouldEqual( "B5" );
		}



		[Test]
		public void Should_accept_number_6()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Six );
			Hardware.TouchPanel.Code.ShouldEqual( "B6" );
		}



		[Test]
		public void Should_accept_number_7()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Seven );
			Hardware.TouchPanel.Code.ShouldEqual( "B7" );
		}



		[Test]
		public void Should_accept_number_8()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Eight );
			Hardware.TouchPanel.Code.ShouldEqual( "B8" );
		}



		[Test]
		public void Should_accept_number_9()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Nine );
			Hardware.TouchPanel.Code.ShouldEqual( "B9" );
		}



		[Test]
		public void Should_accept_letter_A()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.A );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "A1" );
		}



		[Test]
		public void Should_accept_letter_B()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "B1" );
		}



		[Test]
		public void Should_accept_letter_C()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.C );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "C1" );
		}



		[Test]
		public void Should_accept_letter_D()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.D );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "D1" );
		}



		[Test]
		public void Should_accept_letter_E()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.E );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			Hardware.TouchPanel.Code.ShouldEqual( "E1" );
		}



		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void Should_throw_invalid_operation_exception_if_two_letters_entered_in_a_row()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.A );
			TestHardware.TouchPanel.Press( TouchPanelLetter.B );
		}



		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void Should_throw_invalid_operation_exception_if_letter_followed_by_two_numbers_is_entered()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.A );
			TestHardware.TouchPanel.Press( TouchPanelNumber.One );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Three );
		}



		[Test]
		public void Should_clear_code_if_clear_button_is_pressed_and_allow_a_full_code_to_be_entered()
		{
			TestHardware.TouchPanel.Press( TouchPanelLetter.C );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Seven );

			TestHardware.TouchPanel.Press( TouchPanelButton.Clear );

			TestHardware.TouchPanel.Press( TouchPanelLetter.E );
			TestHardware.TouchPanel.Press( TouchPanelNumber.Five );

			Hardware.TouchPanel.Code.ShouldEqual( "E5" );
		}
	}
}