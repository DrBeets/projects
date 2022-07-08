using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_KATANA = 1;
        public const int ITEM_ID_RABBIT_FOOT = 2;
        public const int ITEM_ID_PELT = 3;
        public const int ITEM_ID_GOBLIN_EAR = 4;
        public const int ITEM_ID_GOBLIN_CLUB = 5;
        public const int ITEM_ID_DRAGON_SCALE = 6;
        public const int ITEM_ID_DRAGON_CLAW = 7;
        public const int ITEM_ID_HEALING_POTION = 8;
        public const int ITEM_ID_NODACHI = 9;
        public const int ITEM_ID_BRACELET_OF_REMEMBRANCE = 10;
        public const int ITEM_ID_BONE = 11;
        public const int ITEM_ID_MIMIC_KEY = 12;
        public const int ITEM_ID_LICH_SOUL = 13;
        public const int ITEM_ID_SPIDER_SILK = 14;
        public const int ITEM_ID_SPIDER_FANG = 15;
        public const int ITEM_ID_ZOMBIE_ARM = 16;
        public const int ITEM_ID_ROTTEN_FLESH = 17;
        public const int ITEM_ID_RAT_TAIL = 18;
        public const int ITEM_ID_RAT_FUR = 19;
        public const int ITEM_ID_ROCK = 20;
        public const int ITEM_ID_GOLEM_CORE = 21;
        public const int ITEM_ID_SABER_OF_LIGHT = 22;
        public const int ITEM_ID_ZWEIHANDER = 23;
        public const int ITEM_ID_RAPIER = 24;
        public const int ITEM_ID_MAG_SASH = 25;

        public const int MONSTER_ID_RABBIT = 1;
        public const int MONSTER_ID_GOBLIN = 2;
        public const int MONSTER_ID_DRAGON = 3;
        public const int MONSTER_ID_MIMIC = 4;
        public const int MONSTER_ID_SKELETON = 5;
        public const int MONSTER_ID_SPIDER = 6;
        public const int MONSTER_ID_ZOMBIE = 7;
        public const int MONSTER_ID_RAT = 8;
        public const int MONSTER_ID_GOLEM = 9;
        public const int MONSTER_ID_LICH = 10;
        public const int MONSTER_ID_SHADOW = 11;
        public const int MONSTER_ID_BOSS = 12;

        public const int QUEST_ID_SLAY_DRAGON = 1;
        public const int QUEST_ID_SLAY_LICH = 2;
        public const int QUEST_ID_SLAY_GOLEM = 3;
        public const int QUEST_ID_DEFEAT_BOSS = 4;
        public const int QUEST_ID_DEFEAT_SHADOW = 5;

        public const int LOCATION_ID_VILLAGE = 1;
        public const int LOCATION_ID_CROSSROADS = 2;
        public const int LOCATION_ID_THE_DEPTHS = 3;
        public const int LOCATION_ID_CEMETARY = 4;
        public const int LOCATION_ID_DRAGONS_LAIR = 5;
        public const int LOCATION_ID_OUTSKIRTS = 6;
        public const int LOCATION_ID_MAG_DUNGEON = 7;
        public const int LOCATION_ID_SECRET_DUNGEON = 8;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_KATANA, "Katana", "Katanas", 1, 5, 1));
            Items.Add(new Weapon(ITEM_ID_ZWEIHANDER, "Zweihander", "Zweihanders", 5, 10, 15));
            Items.Add(new Weapon(ITEM_ID_RAPIER, "Rapier", "Rapiers", 3, 7, 10));
            Items.Add(new Weapon(ITEM_ID_NODACHI, "Nodachi", "Nodachis", 10, 15, 20));
            Items.Add(new Weapon(ITEM_ID_SABER_OF_LIGHT, "Saber of Light", "Sabers of Light", 30, 70, 500));
            Items.Add(new Item(ITEM_ID_RABBIT_FOOT, "Rabbit foot", "Rabbit feet", 1 ));
            Items.Add(new Item(ITEM_ID_PELT, "Pelt", "Pelts", 1));
            Items.Add(new Item(ITEM_ID_GOBLIN_EAR, "Goblin Ear", "Goblin Ears", 2 ));
            Items.Add(new Item(ITEM_ID_GOBLIN_CLUB, "Goblin Club", "Goblin Clubs", 3));
            Items.Add(new Item(ITEM_ID_DRAGON_SCALE, "Dragon Scale", "Dragon Scales", 30));
            Items.Add(new Item(ITEM_ID_DRAGON_CLAW, "Dragon Claw", "Dragon Claws", 30));
            Items.Add(new Potion(ITEM_ID_HEALING_POTION, "Healing Potion", "Healing Potions", 30, 5));
            Items.Add(new Item(ITEM_ID_BONE, "Bone", "Bones", 1));
            Items.Add(new Item(ITEM_ID_MIMIC_KEY, "Mimic Key", "Mimic Keys", 3 ));
            Items.Add(new Item(ITEM_ID_LICH_SOUL, "Lich Soul", "Lich Souls", 20));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider Silk", "Spiders Silk", 3));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fangs", 3));
            Items.Add(new Item(ITEM_ID_ZOMBIE_ARM, "Zombie Arm", "Zombie Arms", 1));
            Items.Add(new Item(ITEM_ID_ROTTEN_FLESH, "Rotten Flesh", "Rotten Flesh", 1));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tails", 1));
            Items.Add(new Item(ITEM_ID_RAT_FUR, "Rat Fur", "Rat Fur", 2));
            Items.Add(new Item(ITEM_ID_ROCK, "Rock", "Rocks", 1));
            Items.Add(new Item(ITEM_ID_GOLEM_CORE, "Golem Core", "Golem Cores", 10));
            Items.Add(new Item(ITEM_ID_MAG_SASH, "Magnabris' Sash", "Magnabris' Sashes", 100));
            Items.Add(new Item(ITEM_ID_BRACELET_OF_REMEMBRANCE, "Bracelet of Remembrance", "Bracelets of Remembrance", 500));
        }

        private static void PopulateMonsters()
        {
            Monster rabbit = new Monster(MONSTER_ID_RABBIT,"Rabbit", 1, 2, 1, 3, 3);
            rabbit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RABBIT_FOOT), 25, false));
            rabbit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PELT), 75, true));

            Monster goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 3, 5, 3, 5, 5);
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOBLIN_EAR), 75, true));
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOBLIN_CLUB), 25, false));

            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 2, 3, 2, 4, 4);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_FUR), 75, true));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 25, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 100, true));

            Monster spider = new Monster(MONSTER_ID_SPIDER, "Spider", 4, 5, 5, 7, 7);
            spider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            spider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster golem = new Monster(MONSTER_ID_GOLEM, "Golem", 10, 15, 20, 40, 40);
            golem.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROCK), 75, false));
            golem.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOLEM_CORE), 100, true));

            Monster skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton", 7, 10, 10, 15, 15);
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONE), 75, true));

            Monster zombie = new Monster(MONSTER_ID_ZOMBIE, "Zombie", 7, 10, 10, 15, 15);
            zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTEN_FLESH), 75, true));
            zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ZOMBIE_ARM), 25, false));

            Monster lich = new Monster(MONSTER_ID_LICH, "Lich", 20, 30, 40, 80, 80);
            lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LICH_SOUL), 100, true));
            lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONE), 75, false));

            Monster mimic = new Monster(MONSTER_ID_MIMIC, "Mimic", 15, 30, 20, 30, 30);
            mimic.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MIMIC_KEY), 50, true));

            Monster dragon = new Monster(MONSTER_ID_DRAGON, "Dragon", 30, 60, 60, 100, 100);
            dragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DRAGON_CLAW), 100, true));
            dragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DRAGON_SCALE), 25, false));

            Monster shadow = new Monster(MONSTER_ID_SHADOW, "Shadow of Kaienavan", 50, 0, 0, 100, 100);
            shadow.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 100, true));

            Monster boss = new Monster(MONSTER_ID_BOSS, "Magnabris", 60, 0, 0, 180, 180);
            boss.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAG_SASH), 100, true));

            Monsters.Add(rabbit);
            Monsters.Add(goblin);
            Monsters.Add(rat);
            Monsters.Add(spider);
            Monsters.Add(golem);
            Monsters.Add(skeleton);
            Monsters.Add(zombie);
            Monsters.Add(lich);
            Monsters.Add(mimic);
            Monsters.Add(dragon);
            Monsters.Add(shadow);
            Monsters.Add(boss);

        }
        private static void PopulateQuests()
        {
            Quest slayGolem = new Quest(QUEST_ID_SLAY_GOLEM, "Slay The Golem",
                "Slay the Golem and retrieve the Golem's Core. You will recieve 20 experience points and 15 gold.", 20, 15);
            slayGolem.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_GOLEM_CORE), 1));
            slayGolem.RewardItem = ItemByID(ITEM_ID_GOLEM_CORE);

            Quest slayLich = new Quest(QUEST_ID_SLAY_LICH, "Slay The Lich",
                "Slay the Lich and retrieve the Lich's Soul. You will recieve 40 experience points and 30 gold.", 40, 30);
            slayLich.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LICH_SOUL), 1));
            slayLich.RewardItem = ItemByID(ITEM_ID_LICH_SOUL);

            Quest slayDragon = new Quest(QUEST_ID_SLAY_DRAGON, "Slay The Dragon",
                "Slay the Dragon and retrieve the Dragon's Claw. You will recieve 60 experience points and 60 gold.", 60, 60);
            slayDragon.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DRAGON_CLAW), 1));
            slayDragon.RewardItem = ItemByID(ITEM_ID_DRAGON_CLAW);

            Quest defeatShadow = new Quest(QUEST_ID_DEFEAT_SHADOW, "Slay The Shadow",
                "Defeat the Shadow", 0, 0);
            defeatShadow.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KATANA), 1));
            defeatShadow.RewardItem = ItemByID(ITEM_ID_SABER_OF_LIGHT);

            Quest defeatBoss = new Quest(QUEST_ID_DEFEAT_BOSS, "Defeat The Boss",
                "Defeat Magnabris once and for all.", 0, 0);
            defeatBoss.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_MAG_SASH), 1));
            defeatBoss.RewardItem = ItemByID(ITEM_ID_MAG_SASH);

            Quests.Add(slayGolem);
            Quests.Add(slayLich);
            Quests.Add(slayDragon);
            Quests.Add(defeatShadow);
            Quests.Add(defeatBoss);

        }

        private static void PopulateLocations()
        {
            Location village = new Location(LOCATION_ID_VILLAGE, "Norghast Village", "A small village in the realm of Norghast");
            Vendor orindae = new Vendor("Orindae");
            orindae.AddItemToInventory(ItemByID(ITEM_ID_BRACELET_OF_REMEMBRANCE), 1);
            orindae.AddItemToInventory(ItemByID(ITEM_ID_BONE), 5);
            village.VendorWorkingHere = orindae;

            Location crossroads = new Location(LOCATION_ID_CROSSROADS, "The Crossroads", "A four way crossroads");
            crossroads.MonsterLivingHere = MonsterByID(MONSTER_ID_RABBIT);
            crossroads.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN);

            Location depths = new Location(LOCATION_ID_THE_DEPTHS, "The Depths", "A dark cesspool of creatures");
            depths.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_GOLEM);
            depths.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);
            depths.MonsterLivingHere = MonsterByID(MONSTER_ID_SPIDER);
            depths.MonsterLivingHere = MonsterByID(MONSTER_ID_GOLEM);

            Location cemetary = new Location(LOCATION_ID_CEMETARY, "Cemetary", "The resting grounds of the departed", ItemByID(ITEM_ID_GOLEM_CORE));
            cemetary.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_LICH);
            cemetary.MonsterLivingHere = MonsterByID(MONSTER_ID_SKELETON);
            cemetary.MonsterLivingHere = MonsterByID(MONSTER_ID_ZOMBIE);
            cemetary.MonsterLivingHere = MonsterByID(MONSTER_ID_LICH);

            Location dragonsLair = new Location(LOCATION_ID_DRAGONS_LAIR, "Dragons Lair", "The Lair of a Dragon", ItemByID(ITEM_ID_LICH_SOUL));
            dragonsLair.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_DRAGON);
            dragonsLair.MonsterLivingHere = MonsterByID(MONSTER_ID_MIMIC);
            dragonsLair.MonsterLivingHere = MonsterByID(MONSTER_ID_DRAGON);

            Location outskirts = new Location(LOCATION_ID_OUTSKIRTS, "Outskirts", "The outskirts of a dungeon", ItemByID(ITEM_ID_DRAGON_CLAW));

            Location magDungeon = new Location(LOCATION_ID_MAG_DUNGEON, "Magnabris' Dungeon", "The lair of Magnabris", ItemByID(ITEM_ID_BRACELET_OF_REMEMBRANCE));
            magDungeon.QuestAvailableHere = QuestByID(QUEST_ID_DEFEAT_BOSS);
            magDungeon.MonsterLivingHere = MonsterByID(MONSTER_ID_BOSS);

            Location secretDungeon = new Location(LOCATION_ID_SECRET_DUNGEON, "Secret Dungeon", "Its a secret");
            secretDungeon.QuestAvailableHere = QuestByID(QUEST_ID_DEFEAT_SHADOW);
            secretDungeon.MonsterLivingHere = MonsterByID(MONSTER_ID_SHADOW);

            village.LocationToNorth = crossroads;
            village.LocationToWest = secretDungeon;

            crossroads.LocationToNorth = cemetary;
            crossroads.LocationToEast = dragonsLair;
            crossroads.LocationToSouth = village;
            crossroads.LocationToWest = depths;

            depths.LocationToEast = crossroads;

            cemetary.LocationToSouth = crossroads;

            dragonsLair.LocationToEast = outskirts;
            dragonsLair.LocationToWest = crossroads;

            secretDungeon.LocationToEast = village;

            outskirts.LocationToEast = magDungeon;
            outskirts.LocationToWest = dragonsLair;

            magDungeon.LocationToWest = outskirts;

            Locations.Add(village);
            Locations.Add(crossroads);
            Locations.Add(depths);
            Locations.Add(cemetary);
            Locations.Add(dragonsLair);
            Locations.Add(secretDungeon);
            Locations.Add(outskirts);
            Locations.Add(magDungeon);
        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
