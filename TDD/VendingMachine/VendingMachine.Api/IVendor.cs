namespace VendingMachine.Api
{
	public interface IVendor
	{
		void Vend( int productNumber );
		int GetStockLevel( int productNumber );
		bool CanVend( int productNumber );
	}
}