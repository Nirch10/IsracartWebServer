namespace Lib.Utils
{
    public interface IParsable<T>
    {
         public T Parse(params string[] dataToParse);
    }
}