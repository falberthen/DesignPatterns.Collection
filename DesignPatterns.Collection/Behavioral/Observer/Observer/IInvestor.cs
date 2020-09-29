using DesignPatterns.Behavioral.Observer.Subject;

/// <summary>
/// The 'Observer' interface
/// </summary>
namespace DesignPatterns.Behavioral.Observer.Observer
{
    public interface IInvestor
    {
        string Name { get; }
        void Update(Stock stock);
    }
}