namespace ChainOfResponsability;

public abstract class Processor
{
    private Processor? _next;

    public Processor(Processor? next = null) => _next = next;

    public virtual void Process(Number request){
        if(_next != null)
            _next.Process(request);
    }
}
