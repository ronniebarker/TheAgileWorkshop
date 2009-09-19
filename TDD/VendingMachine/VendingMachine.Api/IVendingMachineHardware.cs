namespace VendingMachine.Api
{
	public interface IVendingMachineHardware
	{
		IButton RejectButton { get; }
		ICoinSlot CoinSlot { get; }
		ITouchPanel TouchPanel { get; }
		ITray Tray { get; }
		IVendor Vendor { get; }
	}
}