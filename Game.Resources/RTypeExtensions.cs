using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Resources
{
    public static class RTypeExtensions
    {
        public static Resource ToResource(this RType type, uint amount = 0u)
            => new Resource(amount, type);

        public static RAttr Attributes(this RType type)
            => type switch
            {
                RType.SmallStones        => RAttr.Crafting,
                RType.Sticks             => RAttr.Crafting | RAttr.Burnable,
                RType.Wood               => RAttr.Crafting | RAttr.Burnable,
                RType.Lumber             => RAttr.Crafting | RAttr.Burnable,
                RType.BigLeaves          => RAttr.Crafting | RAttr.Burnable,
                RType.Bones              => RAttr.Crafting,
                RType.Grass              => RAttr.Crafting,
                RType.DryGrass           => RAttr.Crafting,
                RType.ChestnutMushroom   => RAttr.Editable,
                RType.MorelMushroom      => RAttr.Editable,
                RType.GoldenOakMushroom  => RAttr.Editable,
                RType.AbaloneMushroom    => RAttr.Editable,
                RType.KingBrownMushroom  => RAttr.Editable,
                RType.HedgeHogMushroom   => RAttr.Editable,
                RType.LilyMushroom       => RAttr.Editable,
                RType.RawAmaranth        => RAttr.Editable | RAttr.Plant,
                RType.CookedAmaranth     => RAttr.Editable | RAttr.Plant,
                RType.Asparagus          => RAttr.Editable | RAttr.Plant,
                RType.Burdock            => RAttr.Editable | RAttr.Plant,
                RType.Bullrush           => RAttr.Editable | RAttr.Plant,
                RType.Clovers            => RAttr.Editable | RAttr.Plant,
                RType.Chicory            => RAttr.Editable | RAttr.Plant,
                RType.ChickWeed          => RAttr.Editable | RAttr.Plant,
                RType.CurledDock         => RAttr.Editable | RAttr.Plant,
                RType.Dandelion          => RAttr.Editable | RAttr.Plant,
                RType.FireWeed           => RAttr.Editable | RAttr.Plant,
                RType.Plantain           => RAttr.Editable | RAttr.Plant,
                RType.Purslane           => RAttr.Editable | RAttr.Plant,
                RType.Deer               => RAttr.Editable | RAttr.Meat,
                RType.Fox                => RAttr.Editable | RAttr.Meat,
                RType.Squirrel           => RAttr.Editable | RAttr.Meat,
                RType.Rabbit             => RAttr.Editable | RAttr.Meat,
                RType.Badger             => RAttr.Editable | RAttr.Meat,
                RType.Hare               => RAttr.Editable | RAttr.Meat,
                RType.Owl                => RAttr.Editable | RAttr.Meat,
                RType.Bobcat             => RAttr.Editable | RAttr.Meat,
                RType.Wolves             => RAttr.Editable | RAttr.Meat | RAttr.Dangerous,
                RType.BlackBear          => RAttr.Editable | RAttr.Meat | RAttr.Dangerous,
                RType.GrizzlyBear        => RAttr.Editable | RAttr.Meat | RAttr.Dangerous,
                RType.Moose              => RAttr.Editable | RAttr.Meat | RAttr.Dangerous,
                _                        => RAttr.None
            };
    }
}
