using NBehave.Spec.NUnit;
using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles.Tests
{
	[TestFixture]
	public class When_a_coin_is_inserted_into_the_coin_slot_of_the_machine : FixtureBase
	{
		[Test]
		public void Should_Receive_the_CoinInserted_event()
		{
			bool coinInsertedEventWasFired = false;
			Hardware.CoinSlot.CoinInsertedEvent += ( s, e ) => coinInsertedEventWasFired = true;

			TestHardware.CoinSlot.InsertCoin( 0.20m );

			coinInsertedEventWasFired.ShouldBeTrue();
		}



		[Test]
		public void Should_increase_coin_count()
		{
			Hardware.CoinSlot.CoinCount.ShouldEqual( 0 );

			TestHardware.CoinSlot.InsertCoin( 0.50m );

			Hardware.CoinSlot.CoinCount.ShouldEqual( 1 );
		}



		[Test]
		public void Should_increase_the_total_in_the_coin_slot_by_the_value_of_the_coin()
		{
			Hardware.CoinSlot.Value.ShouldEqual( 0.00m );

			TestHardware.CoinSlot.InsertCoin( 0.10m );

			Hardware.CoinSlot.Value.ShouldEqual( 0.10m );
		}
	}
}