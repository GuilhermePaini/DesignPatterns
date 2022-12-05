namespace Iterator
{
    internal interface InterfaceIterator
    {
        object? Current { get; }
        bool Next();
    }
}
