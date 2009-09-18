namespace VendingMachine.Api.TestDoubles
{
	public class VendingMachineTestHardware : IVendingMachineHardware
	{
		public VendingMachineTestHardware()
		{
			RejectButton = new Button();
		}



		IButton IVendingMachineHardware.RejectButton
		{
			get { return RejectButton; }
		}



		public Button RejectButton { get; private set; }
	}
}