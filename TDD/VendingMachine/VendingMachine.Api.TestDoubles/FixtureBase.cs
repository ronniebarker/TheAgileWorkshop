using NUnit.Framework;



namespace VendingMachine.Api.TestDoubles
{
	public class FixtureBase
	{
		protected VendingMachineTestHardware TestHardware;



		protected IVendingMachineHardware Hardware
		{
			get { return TestHardware; }
		}



		[SetUp]
		public void SetupHardware()
		{
			TestHardware = new VendingMachineTestHardware();
		}
	}
}