namespace Nile
{
    public interface IProductDatabase
    {
        Product Add( Product product );
        Product Get( int id );
        Product[] GetAll();
        void Remove( int id );
        Product Update( Product product );
    }
}