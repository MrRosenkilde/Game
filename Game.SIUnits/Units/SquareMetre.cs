namespace Game.SIUnits.Units.BaseUnits
{
    public readonly struct SquareMetre : IUnit
    {
        public string Symbol => "m2";


        public static CubicMetre operator *(SquareMetre left, SquareMetre right)
            => new CubicMetre();

    }
}