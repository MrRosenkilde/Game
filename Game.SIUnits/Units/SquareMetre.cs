namespace Game.SIUnits.Units.BaseUnits
{
    public readonly struct SquareMetre : IUnit
    {
        public string Symbol => "m^2";

        public string Name => "square metre";

        public static CubicMetre operator *(SquareMetre left, SquareMetre right)
            => new CubicMetre();

    }
}