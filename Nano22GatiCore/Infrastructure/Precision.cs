namespace Nano22GatiCore.Infrastructure
{
    public class Precision
    {
        public Precision(string Name, int Value, bool IsAuto = false)
        {
            this.Name = Name;
            this.Value = Value;
            this.IsAuto = IsAuto;
        }

        public string Name { get; private set; }
        public int Value { get; private set; }
        public bool IsAuto { get; private set;}
    }
}
