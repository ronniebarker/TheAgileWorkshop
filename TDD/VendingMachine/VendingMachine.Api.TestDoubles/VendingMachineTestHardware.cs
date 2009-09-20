namespace VendingMachine.Api.TestDoubles
{
	public class VendingMachineTestHardware : IVendingMachineHardware
	{
		public VendingMachineTestHardware()
		{
			RejectButton = new Button();
			CoinSlot = new CoinSlot();
			TouchPanel = new TouchPanel();
			Vendor = new VendorWithTray();
			Display = new Display();
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



		ITray IVendingMachineHardware.Tray
		{
			get { return Vendor; }
		}



		IVendor IVendingMachineHardware.Vendor
		{
			get { return Vendor; }
		}



		IDisplay IVendingMachineHardware.Display
		{
			get { return Display; }
		}



		public Button RejectButton { get; private set; }
		public CoinSlot CoinSlot { get; private set; }
		public TouchPanel TouchPanel { get; private set; }
		public VendorWithTray Vendor { get; private set; }
		public Display Display { get; private set; }
	}
}