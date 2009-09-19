namespace VendingMachine.Api.TestDoubles
{
	public class VendingMachineTestHardware : IVendingMachineHardware
	{
		public VendingMachineTestHardware()
		{
			RejectButton = new Button();
			CoinSlot = new CoinSlot();
			TouchPanel = new TouchPanel();
			VendorWithTray = new VendorWithTray();
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
			get { return VendorWithTray; }
		}



		IVendor IVendingMachineHardware.Vendor
		{
			get { return VendorWithTray; }
		}



		public Button RejectButton { get; private set; }
		public CoinSlot CoinSlot { get; private set; }
		public TouchPanel TouchPanel { get; private set; }
		public VendorWithTray VendorWithTray { get; private set; }
	}
}