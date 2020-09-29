namespace DesignPatterns.Structural.Facade.Subsystem
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}