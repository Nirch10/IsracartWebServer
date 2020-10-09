namespace Lib.Utils
{
    public interface IDataExporter<T>
    {
         public List<T> Export(string source);
    }
}