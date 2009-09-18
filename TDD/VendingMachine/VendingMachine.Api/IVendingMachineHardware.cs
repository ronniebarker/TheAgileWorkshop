namespace VendingMachine.Api
{
	public interface IVendingMachineHardware
	{
		IButton RejectButton { get; }
	}
}