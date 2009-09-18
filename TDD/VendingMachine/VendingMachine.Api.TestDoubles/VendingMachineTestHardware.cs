namespace VendingMachine.Api.TestDoubles
{
	public class VendingMachineTestHardware : IVendingMachineHardware
	{
		public VendingMachineTestHardware()
		{
			RejectButton = new Button();
			CoinSlot = new CoinSlot();
		}



		IButton IVendingMachineHardware.RejectButton
		{
			get { return RejectButton; }
		}



		ICoinSlot IVendingMachineHardware.CoinSlot
		{
			get { return CoinSlot; }
		}



		public Button RejectButton { get; private set; }
		public CoinSlot CoinSlot { get; private set; }
	}
}