using Game.SIUnits.BaseUnits;

namespace Game.SIUnits.Units.BaseUnits
{
    public readonly struct MetersPerSecond : IUnit
    {
        public string Symbol => "m/s";

        public string Name => "metres per second";

        public static MetrePerSecondSquared operator /(MetersPerSecond left, Second right)
            => new MetrePerSecondSquared();

    }
}