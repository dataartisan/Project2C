//interface IEvent
namespace Project2B.Interfaces
{
    public interface IEvent
    {
        LocationObserverandObservable Location { get; }
        IItem Item { get; }
        IActor Actor { get; }
    }
}
