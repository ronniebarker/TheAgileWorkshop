namespace VendingMachine.Api.TestDoubles
{
	public class VendingMachineTestHardware : IVendingMachineHardware
	{
		public VendingMachineTestHardware()
		{
			RejectButton = new Button();
			CoinSlot = new CoinSlot();
			TouchPanel = new TouchPanel();
		}



		IButton IVendingMachineHardware.RejectButton
		{
			get { return RejectButton; }
		}



		ICoinSlot IVendingMachineHardware.CoinSlot
		{
			get { return CoinSlot; }
		}



		ITouchPanel IVendingMachineHardware.TouchPanel
		{
			get { return TouchPanel; }
		}



		public Button RejectButton { get; private set; }
		public CoinSlot CoinSlot { get; private set; }
		public TouchPanel TouchPanel { get; private set; }
	}
}