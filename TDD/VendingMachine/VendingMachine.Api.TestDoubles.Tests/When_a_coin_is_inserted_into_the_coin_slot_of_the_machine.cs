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

			TestHardware.CoinSlot.InsertCoin();

			coinInsertedEventWasFired.ShouldBeTrue();
		}
	}
}