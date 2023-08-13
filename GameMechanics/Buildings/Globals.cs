using System.Collections.Generic;

public class Globals
{
    public static int TERRAIN_LAYER_MASK = 1 << 8;

    public static BuildingData[] BUILDING_DATA = new BuildingData[]
   {
        new BuildingData("House", 100, new Dictionary<string, int>()
        {
            { "gold", 20 },
            { "wood", 120 }
        }),
        new BuildingData("Tower", 100, new Dictionary<string, int>()
        {
            { "gold", 40 },
            { "wood", 100 },
            { "stone", 20 }
        }),
        new BuildingData("Barracks", 150, new Dictionary<string, int>()
        {
            { "gold", 50 },
            { "wood", 150 },
            { "stone", 60 },
            { "iron", 10 }
        }),
       new BuildingData("TownHall", 500, new Dictionary<string, int>()
       {
           { "gold", 100 },
           { "wood", 400 },
           { "stone", 150 },
           { "iron", 40 }
       }),
       new BuildingData("Farm", 20, new Dictionary<string, int>()
       {
           { "wood", 10 },
           { "food", 20 }
       }),
       new BuildingData("Church", 200, new Dictionary<string, int>()
       {
           { "gold", 80 },
           { "wood", 40 },
           { "stone", 120 },
           { "iron" ,10 }
       }),
       new BuildingData("Warehouse", 120, new Dictionary<string, int>()
       {
           { "gold", 20 },
           { "wood", 70 },
           { "stone", 10 },
       })
   };

    public static Dictionary<string, GameResource> GAME_RESOURCES =
        new Dictionary<string, GameResource>()
    {
            { "gold", new GameResource("Gold", 1000) },
            { "wood", new GameResource("Wood", 1000) },
            { "stone", new GameResource("Stone", 1000) },
            { "iron", new GameResource("Iron", 1000) },
            { "food", new GameResource("food", 1000) }
    };

}