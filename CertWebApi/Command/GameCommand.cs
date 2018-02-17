namespace CertWebApi.Command
{
    public class GameCommand
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public NeedLevel NeedLevel { get; set; }
    }

    public enum NeedLevel
    {
        HIGH,
        OVER_EXITED,
        LOW
    }
}