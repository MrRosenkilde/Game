using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Resources
{
    public enum RType
    {
        //CRAFTING SECTION
        SmallStones,
        Sticks,
        Wood,
        Lumber,
        BigLeaves,
        Bones,
        Grass,
        DryGrass,

        //FOREST FOOD SECTION (PLANTS)
        //https://www.artofmanliness.com/articles/surviving-in-the-wild-19-common-edible-plants/
        //https://www.nutritionadvance.com/types-of-edible-mushrooms/
        //shrooms
        ChestnutMushroom,
        MorelMushroom,
        GoldenOakMushroom,
        AbaloneMushroom,
        KingBrownMushroom,
        HedgeHogMushroom,
        LilyMushroom,

        //plants
        RawAmaranth,
        CookedAmaranth,
        Asparagus,
        Burdock,
        Bullrush,
        Clovers,
        Chicory,
        ChickWeed,
        CurledDock,
        Dandelion,
        FireWeed,
        Plantain,
        Purslane,

        //Meat
        Deer,
        Fox,
        Squirrel,
        Rabbit,
        Badger,
        Hare,
        Owl,
        Bobcat,

        //Dangerous animals, if these meat types are rolled from hunting, an additional roll will be made to see if the hunter survived
        Wolves,
        BlackBear,
        GrizzlyBear,
        Moose,


    }
}
