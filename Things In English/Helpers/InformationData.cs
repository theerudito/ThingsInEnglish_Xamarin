﻿using System.Collections.Generic;
using ThingsInEnglish.ApplicationContextDB;
using ThingsInEnglish.Models;

namespace ThingsInEnglish.Helpers
{
    public static class InformationData
    {
        public static void DataDefault()
        {
            var _dbCcontext = new ApplicationContext_DB();

            var newThing = new List<Things>
            {
               new Things { IdThing = 1, Name = "FEEDING BOTTLE", ImageBase64 = DataBase64.stringOne},
               new Things { IdThing = 2, Name = "CLOCK", ImageBase64 = DataBase64.stringTwo},
               new Things { IdThing = 3, Name = "APPLE", ImageBase64 = DataBase64.stringThree},
               new Things { IdThing = 4, Name = "WATCH", ImageBase64 = DataBase64.stringFour},
               new Things { IdThing = 5, Name = "BATTERY", ImageBase64 = DataBase64.stringFive},
               new Things { IdThing = 6, Name = "WIRE HDMI", ImageBase64 = DataBase64.stringSix},
               new Things { IdThing = 7, Name = "MONEY", ImageBase64 = DataBase64.stringSeven},
               new Things { IdThing = 8, Name = "COIN", ImageBase64 = DataBase64.stringEight},
               new Things { IdThing = 9, Name = "COMPUTER", ImageBase64 = DataBase64.stringNine},
               new Things { IdThing = 10, Name = "XBOX", ImageBase64 = DataBase64.stringTen},
               new Things { IdThing = 11, Name = "COMPACT DISK", ImageBase64 = DataBase64.stringEleven},
               new Things { IdThing = 12, Name = "HARD DISK", ImageBase64 = DataBase64.stringTwelve},
               new Things { IdThing = 13, Name = "GLASS", ImageBase64 = DataBase64.stringThirTeen},
               new Things { IdThing = 14, Name = "EARTH", ImageBase64 = DataBase64.stringFourTeen},
               new Things { IdThing = 15, Name = "FLASH DISK", ImageBase64 = DataBase64.stringFiveTeen},
               new Things { IdThing = 16, Name = "GAME PAD", ImageBase64 = DataBase64.stringSixTeen},
               new Things { IdThing = 17, Name = "PLAY STATION 3", ImageBase64 = DataBase64.stringSevenTeen},
               new Things { IdThing = 18, Name = "GMAIL", ImageBase64 = DataBase64.stringEighTeen},
               new Things { IdThing = 19, Name = "MILK", ImageBase64 = DataBase64.stringNineTeen},
               new Things { IdThing = 20, Name = "PINTURE", ImageBase64 = DataBase64.stringTwenty},
               new Things { IdThing = 21, Name = "INSTAGRAM", ImageBase64 = DataBase64.stringTwentyOne},
               new Things { IdThing = 22, Name = "KEYBOARD", ImageBase64 = DataBase64.stringTwentyTwo},
               new Things { IdThing = 23, Name = "SHARE", ImageBase64 = DataBase64.stringTwentyThree},
               new Things { IdThing = 24, Name = "LINKEDIN", ImageBase64 = DataBase64.stringTwentyFour},
               new Things { IdThing = 25, Name = "LOCATION", ImageBase64 = DataBase64.stringTwentyFive},
               new Things { IdThing = 26, Name = "FOLDER", ImageBase64 = DataBase64.stringTwentySix},
               new Things { IdThing = 27, Name = "MOUSE", ImageBase64 = DataBase64.stringTwentySeven},
               new Things { IdThing = 28, Name = "PORT RJ45", ImageBase64 = DataBase64.stringTwentyEight},
               new Things { IdThing = 29, Name = "ORANGE", ImageBase64 = DataBase64.stringTwentyNine},
               new Things { IdThing = 30, Name = "PENCIL", ImageBase64 = DataBase64.stringThirty},
               new Things { IdThing = 31, Name = "PEPSY", ImageBase64 = DataBase64.stringThirtyOne},
               new Things { IdThing = 32, Name = "PHONE", ImageBase64 = DataBase64.stringThirtyTwo},
               new Things { IdThing = 33, Name = "PLAY STATION 2", ImageBase64 = DataBase64.stringThirtyThree},
               new Things { IdThing = 34, Name = "PLAY STATION 4", ImageBase64 = DataBase64.stringThirtyFour},
               new Things { IdThing = 35, Name = "PLAY STATION 1", ImageBase64 = DataBase64.stringThirtyFive},
               new Things { IdThing = 36, Name = "PLUG WIRE", ImageBase64 = DataBase64.stringThirtySix},
               new Things { IdThing = 37, Name = "REPORTS", ImageBase64 = DataBase64.stringThirtySeven},
               new Things { IdThing = 38, Name = "ROBOT", ImageBase64 = DataBase64.stringThirtyEight},
               new Things { IdThing = 39, Name = "ROCKET", ImageBase64 = DataBase64.stringThirtyNine},
               new Things { IdThing = 40, Name = "SATELLITE", ImageBase64 = DataBase64.stringForty},
               new Things { IdThing = 41, Name = "DISK FLOPPY", ImageBase64 = DataBase64.stringFortyOne},
               new Things { IdThing = 42, Name = "MAGNIFYING GLASS", ImageBase64 = DataBase64.stringFortyTwo},
               new Things { IdThing = 43, Name = "STAR", ImageBase64 = DataBase64.stringFortyThree},
               new Things { IdThing = 44, Name = "TELESCOPE", ImageBase64 = DataBase64.stringFortyFour},
               new Things { IdThing = 45, Name = "TOYS", ImageBase64 = DataBase64.stringFortyFive},
               new Things { IdThing = 46, Name = "TWITTER", ImageBase64 = DataBase64.stringFortySix},
               new Things { IdThing = 47, Name = "UFO", ImageBase64 = DataBase64.stringFortySeven},
               new Things { IdThing = 48, Name = "VGA PORT", ImageBase64 = DataBase64.stringFortyEight},
               new Things { IdThing = 49, Name = "GAMEBOY", ImageBase64 = DataBase64.stringFortyNine},
               new Things { IdThing = 50, Name = "CHROME", ImageBase64 = DataBase64.stringFifty},
               new Things { IdThing = 51, Name = "WHATSSAP", ImageBase64 = DataBase64.stringFiftyOne},
               new Things { IdThing = 52, Name = "YOUTUBE", ImageBase64 = DataBase64.stringFiftyTwo},
               new Things { IdThing = 53, Name = "MOON", ImageBase64 = DataBase64.stringFiftyThree},
               new Things { IdThing = 54, Name = "AUDIO HEADSET", ImageBase64 = DataBase64.stringFiftyFour},
               new Things { IdThing = 55, Name = "CALCULATOR", ImageBase64 = DataBase64.stringFiftyFive},
               new Things { IdThing = 56, Name = "CARROT", ImageBase64 = DataBase64.stringFiftySix},
               new Things { IdThing = 57, Name = "MONITOR", ImageBase64 = DataBase64.stringFiftySeven},
               new Things { IdThing = 58, Name = "DATAPHONE", ImageBase64 = DataBase64.stringFiftyEight},
               new Things { IdThing = 59, Name = "CREDIT CART", ImageBase64 = DataBase64.stringFiftyNine},
               new Things { IdThing = 60, Name = "TROPHY", ImageBase64 = DataBase64.stringSixty},
               new Things { IdThing = 61, Name = "CUT", ImageBase64 = DataBase64.stringSixtyOne},
               new Things { IdThing = 62, Name = "DESK", ImageBase64 = DataBase64.stringSixtyTwo},
               new Things { IdThing = 63, Name = "CHAIR", ImageBase64 = DataBase64.stringSixtyThree},
               new Things { IdThing = 64, Name = "ELECTIC GUITAR", ImageBase64 = DataBase64.stringSixtyFour},
               new Things { IdThing = 65, Name = "PLAYING CARDS", ImageBase64 = DataBase64.stringSixtyFive},
               new Things { IdThing = 66, Name = "KNIFE", ImageBase64 = DataBase64.stringSixtySix},
               new Things { IdThing = 67, Name = "MEMORY CARD", ImageBase64 = DataBase64.stringSixtySeven},
               new Things { IdThing = 68, Name = "MICROPHONE", ImageBase64 = DataBase64.stringSixtyEight},
               new Things { IdThing = 69, Name = "LAPTOP", ImageBase64 = DataBase64.stringSixtyNine},
               new Things { IdThing = 70, Name = "OWL", ImageBase64 = DataBase64.stringSeventy},
               new Things { IdThing = 71, Name = "PINEAPPLE", ImageBase64 = DataBase64.stringSeventyOne},
               new Things { IdThing = 72, Name = "BOX", ImageBase64 = DataBase64.stringSeventyTwo},
               new Things { IdThing = 73, Name = "TV", ImageBase64 = DataBase64.stringSeventyThree},
               new Things { IdThing = 74, Name = "SPEAKER", ImageBase64 = DataBase64.stringSeventyFour},
               new Things { IdThing = 75, Name = "DRESS", ImageBase64 = DataBase64.stringSeventyFive},
               new Things { IdThing = 76, Name = "HOURSE", ImageBase64 = DataBase64.stringSeventySix},
               new Things { IdThing = 77, Name = "BOAT", ImageBase64 = DataBase64.stringSeventySeven},
               new Things { IdThing = 78, Name = "BACKPACK", ImageBase64 = DataBase64.stringSeventyEight},
               new Things { IdThing = 79, Name = "SHIRT", ImageBase64 = DataBase64.stringSeventyNine},
               new Things { IdThing = 80, Name = "RAINBOW", ImageBase64 = DataBase64.stringEighty},
               new Things { IdThing = 81, Name = "ROUTER", ImageBase64 = DataBase64.stringEightyOne},
               new Things { IdThing = 82, Name = "CRADLE", ImageBase64 = DataBase64.stringEightyTwo},
               new Things { IdThing = 83, Name = "BABY", ImageBase64 = DataBase64.stringEightyThree},
               new Things { IdThing = 84, Name = "BAT", ImageBase64 = DataBase64.stringEightyFour},
               new Things { IdThing = 85, Name = "BELT", ImageBase64 = DataBase64.stringEightyFive},
               new Things { IdThing = 86, Name = "BIKE", ImageBase64 = DataBase64.stringEightySix},
               new Things { IdThing = 87, Name = "CLOUD", ImageBase64 = DataBase64.stringEightySeven},
               new Things { IdThing = 88, Name = "COOKIES", ImageBase64 = DataBase64.stringEightyEight},
               new Things { IdThing = 89, Name = "TABLE", ImageBase64 = DataBase64.stringEightyNine},
               new Things { IdThing = 90, Name = "CANDIES", ImageBase64 = DataBase64.stringNinety},
               new Things { IdThing = 91, Name = "BOOK", ImageBase64 = DataBase64.stringNinetyOne},
               new Things { IdThing = 92, Name = "GUITAR", ImageBase64 = DataBase64.stringNinetyTwo},
               new Things { IdThing = 93, Name = "BIBLE", ImageBase64 = DataBase64.stringNinetyThree},
               new Things { IdThing = 94, Name = "HOUSE", ImageBase64 = DataBase64.stringNinetyFour},
               new Things { IdThing = 95, Name = "PANTS", ImageBase64 = DataBase64.stringNinetyFive},
               new Things { IdThing = 96, Name = "SUN", ImageBase64 = DataBase64.stringNinetySix},
               new Things { IdThing = 97, Name = "THUNDER", ImageBase64 = DataBase64.stringNinetySeven},
               new Things { IdThing = 98, Name = "SNOW", ImageBase64 = DataBase64.stringNinetyEight},
               new Things { IdThing = 99, Name = "TEMPERATURE", ImageBase64 = DataBase64.stringNinetyNine},
               new Things { IdThing = 100, Name = "CAR", ImageBase64 = DataBase64.stringOneHundred},
               new Things { IdThing = 101, Name = "RABBIT", ImageBase64 = DataBase64.stringOneHundredOne},
               new Things { IdThing = 102, Name = "BIRD", ImageBase64 = DataBase64.stringOneHundredTwo},
               new Things { IdThing = 103, Name = "TREE", ImageBase64 = DataBase64.stringOneHundredThree},
               new Things { IdThing = 104, Name = "CLOVER", ImageBase64 = DataBase64.stringOneHundredFour},
               new Things { IdThing = 105, Name = "CACTUS", ImageBase64 = DataBase64.stringOneHundredFive},
               new Things { IdThing = 106, Name = "NINJA", ImageBase64 = DataBase64.stringOneHundredSix},
               new Things { IdThing = 107, Name = "NOTEBOOK", ImageBase64 = DataBase64.stringOneHundredSeven},
               new Things { IdThing = 108, Name = "PIANO", ImageBase64 = DataBase64.stringOneHundredEight},
               new Things { IdThing = 109, Name = "MOUSE", ImageBase64 = DataBase64.stringOneHundredNine},
               new Things { IdThing = 110, Name = "SQUIRREL", ImageBase64 = DataBase64.stringOneHundredTen},
               new Things { IdThing = 111, Name = "EAGLE", ImageBase64 = DataBase64.stringOneHundredEleven},
               new Things { IdThing = 112, Name = "FISH", ImageBase64 = DataBase64.stringOneHundredTwelve},
               new Things { IdThing = 113, Name = "COW", ImageBase64 = DataBase64.stringOneHundredThirTeen},
               new Things { IdThing = 114, Name = "SHEEP", ImageBase64 = DataBase64.stringOneHundredFourTeen},
               new Things { IdThing = 115, Name = "BED", ImageBase64 = DataBase64.stringOneHundredFifTeen},
               new Things { IdThing = 116, Name = "TRUMPET", ImageBase64 = DataBase64.stringOneHundredSixTeen},
               new Things { IdThing = 117, Name = "HAT", ImageBase64 = DataBase64.stringOneHundredSevenTeen},
               new Things { IdThing = 118, Name = "CAP", ImageBase64 = DataBase64.stringOneHundredEighTeen},
               new Things { IdThing = 119, Name = "PARROT", ImageBase64 = DataBase64.stringOneHundredNineTeen},
               new Things { IdThing = 120, Name = "DOG", ImageBase64 = DataBase64.stringOneHundredTwenty},
               new Things { IdThing = 121, Name = "CAT", ImageBase64 = DataBase64.stringOneHundredTwentyOne},
               new Things { IdThing = 122, Name = "FLOWER", ImageBase64 = DataBase64.stringOneHundredTwentyTwo},
               new Things { IdThing = 123, Name = "REMOTE CONTROL", ImageBase64 = DataBase64.stringOneHundredTwentyThree},
               new Things { IdThing = 124, Name = "SKIRT", ImageBase64 = DataBase64.stringOneHundredTwentyFour},
               new Things { IdThing = 125, Name = "SOCK", ImageBase64 = DataBase64.stringOneHundredTwentyFive},
               new Things { IdThing = 126, Name = "TEACHER", ImageBase64 = DataBase64.stringOneHundredTwentySix},
               new Things { IdThing = 127, Name = "SHEET", ImageBase64 = DataBase64.stringOneHundredTwentySeven},
               new Things { IdThing = 128, Name = "WIFI", ImageBase64 = DataBase64.stringOneHundredTwentyEight},
               new Things { IdThing = 129, Name = "BALLOONS", ImageBase64 = DataBase64.stringOneHundredTwentyNine},
               new Things { IdThing = 130, Name = "RADIO", ImageBase64 = DataBase64.stringOneHundredThirty},
               new Things { IdThing = 131, Name = "ICECREAM", ImageBase64 = DataBase64.stringOneHundredThirtyOne},
               new Things { IdThing = 132, Name = "LIGHT LAMP", ImageBase64 = DataBase64.stringOneHundredThirtyTwo},
               new Things { IdThing = 133, Name = "CORVATE", ImageBase64 = DataBase64.stringOneHundredThirtyThree},
               new Things { IdThing = 134, Name = "BASKETBALL", ImageBase64 = DataBase64.stringOneHundredThirtyFour},
            };

            _dbCcontext.AddRange(newThing);
            _dbCcontext.SaveChanges();
        }
    }
}