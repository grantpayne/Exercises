﻿using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;
            Console.WriteLine("Example 1: " + remainingNumberOfBirds + " birds left on the branch.");

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;
            Console.WriteLine("Example 2: " + numberOfExtraBirds + " more birds than there are nests.");


            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            int racoonsInWoods = 3;
            int racoonsGoHome = 2;
            int racoonsLeft = racoonsInWoods - racoonsGoHome;
            Console.WriteLine("Question 3: " + racoonsLeft + " racoons are left in the woods.");


            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int flowers = 5;
            int bees = 3;
            int flowersLessBees = flowers - bees;
            Console.WriteLine("Question 4: " + flowersLessBees + " less bess than flowers.");


            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int initialPigeons = 1;
            int additionalPigeons = 1;
            int totalPigeons = initialPigeons + additionalPigeons;
            Console.WriteLine("Question 5: " + totalPigeons + " pigeons eating breadcrumbs now.");


            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int initialOwls = 3;
            int additionalOwls = 2;
            int totalOwls = initialOwls + additionalOwls;
            Console.WriteLine("Question 6: " + totalOwls + " owls are on the fence now.");


            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int beaversWorking = 2;
            int beaversLeaving = 1;
            int beaversRemaining = beaversWorking - beaversLeaving;
            Console.WriteLine("Question 7: " + beaversRemaining + " beavers are still working on their home.");


            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int initialToucans = 2;
            int additionalToucans = 1;
            int totalToucans = initialToucans + additionalToucans;
            Console.WriteLine("Question 8: " + totalToucans + " toucans in all.");


            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int totalSquirrels = 4;
            int totalNuts = 2;
            int excessSquirrelsOverNuts = totalSquirrels - totalNuts;
            Console.WriteLine("Question 9: " + excessSquirrelsOverNuts + " more squirrels than nuts.");


            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            //Coin values:
            decimal valueOfQuarter = 0.25M;
            decimal valueOfDime = 0.10M;
            decimal valueOfNickel = 0.05M;
            decimal valueOfPenny = 0.01M;
            decimal valueOfHalfDollar = 0.50M;

            //Coin quantities:
            int numberOfQuarters = 1;
            int numberOfDimes = 1;
            int numberOfNickels = 2;
            int numberOfPennies = 0;
            int numberOfHalfDollars = 0;

            //Tabulation of total value:
            decimal rawTotalValueOfCoins = valueOfQuarter * numberOfQuarters + valueOfDime * numberOfDimes +
                valueOfNickel * numberOfNickels + valueOfPenny * numberOfPennies + valueOfHalfDollar * numberOfHalfDollars;

            //Format result of total value:
            string formattedValueOfCoins = String.Format("Question 10: {0:C} is the total value Mrs. Hilt found.",
                rawTotalValueOfCoins);

            //Display result:
            Console.WriteLine(formattedValueOfCoins);



            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int mrsBriersMuffins = 18;
            int mrsMacAdamsMuffins = 20;
            int mrsFlannerysMuffins = 17;
            int totalMuffins = mrsBriersMuffins + mrsMacAdamsMuffins + mrsFlannerysMuffins;
            Console.WriteLine("Question 11: " + totalMuffins + " were baked in all by the first grade.");


            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal yoyoCost = 0.24M;
            decimal whistleCost = 0.14M;
            decimal rawTotalCostOfToys = yoyoCost + whistleCost;

            //Format result of total cost:
            string formattedTotalCostOfToys = String.Format("Question 12: {0:C} is the total amount Mrs. Hilt spent for the two toys.",
                rawTotalCostOfToys);

            //Display Result:
            Console.WriteLine(formattedTotalCostOfToys);

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int largeMarshmallowsUsed = 8;
            int miniMarshmallowsUsed = 10;
            int totalMarshmallowsUsed = largeMarshmallowsUsed + miniMarshmallowsUsed;
            Console.WriteLine("Question 13: " + totalMarshmallowsUsed + " total marshmallows were used by Mrs. Hilt.");


            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int snowAtBrecknockElementary = 17;
            int snowAtMrsHiltsHouse = 29;
            int excessSnowAtMrsHiltsHouse = snowAtMrsHiltsHouse - snowAtBrecknockElementary;
            Console.WriteLine("Question 14: " + excessSnowAtMrsHiltsHouse + " more inches of snow fell at Mrs. Hilt's " +
                "house than at Brecknock Elementary.");


            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal mrsHiltsMoney = 10.00M;
            decimal costOfToyTruck = 3.00M;
            decimal costOfPencil = 2.00M;
            decimal rawMrsHiltsMoneyAfterPurchase = mrsHiltsMoney - costOfToyTruck - costOfPencil;

            //Format money remaining:
            string formattedMrsHiltsMoneyAfterPurchase = String.Format("Question 15: {0:C} is how much money Mrs. Hilt has left.",
                rawMrsHiltsMoneyAfterPurchase);

            //Display money remaining:
            Console.WriteLine(formattedMrsHiltsMoneyAfterPurchase);


            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int marblesInJoshsCollection = 16;
            int marblesJoshLost = 7;
            int marblesRemainingInJoshsCollection = marblesInJoshsCollection - marblesJoshLost;
            Console.WriteLine("Question 16: " + marblesRemainingInJoshsCollection + " marbles remain in Josh's collection.");


            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int megansCurrentSeashells = 19;
            int megansSeashellGoal = 25;
            int megansSeashellsNeeded = megansSeashellGoal - megansCurrentSeashells;
            Console.WriteLine("Question 17: " + megansSeashellsNeeded + " more seashells are needed for Megan to have 25 in her collection");


            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int bradsTotalBalloons = 17;
            int bradsRedBalloons = 8;
            int bradsGreenBalloons = bradsTotalBalloons - bradsRedBalloons;
            Console.WriteLine("Question 18: " + bradsGreenBalloons + " is how many green balloons Brad has.");


            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int initialBooksOnShelf = 38;
            int additionalBooksOnShelf = 10;
            int totalBooksOnShelf = initialBooksOnShelf + additionalBooksOnShelf;
            Console.WriteLine("Question 19: " + totalBooksOnShelf + " books are on the shelf now.");


            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int legsPerBee = 6;
            int numberOfBees = 8;
            int totalBeeLegs = legsPerBee * numberOfBees;
            Console.WriteLine("Question 20: " + totalBeeLegs + " is how many legs 8 bees have in total.");


            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal costOfIceCreamCone = 0.99M;
            int numberOfIceCreamCones = 2;
            decimal rawTotalCostOfIceCreamCones = costOfIceCreamCone * numberOfIceCreamCones;

            //Format total cost of ice cream cones:
            string formattedTotalCostOfIceCreamCones = String.Format("Question 21: {0} ice cream cones would cost {1:C}.",
                numberOfIceCreamCones, rawTotalCostOfIceCreamCones);

            //Display result:
            Console.WriteLine(formattedTotalCostOfIceCreamCones);


            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int rocksRequiredToCompleteTotal = 125;
            int currentRocksPossessed = 64;
            int AdditionalRocksNeeded = rocksRequiredToCompleteTotal - currentRocksPossessed;
            Console.WriteLine("Question 22: " + AdditionalRocksNeeded + " more rocks are needed to complete the border.");

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int mrsHiltsInitialMarbles = 38;
            int marblesMrsHiltLost = 15;
            int mrsHiltsMarblesRemaining = mrsHiltsInitialMarbles - marblesMrsHiltLost;
            Console.WriteLine("Question 23: " + mrsHiltsMarblesRemaining + " is how many marbles Mrs. Hilt has left.");


            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int totalMilesOfTrip = 78;
            int milesDroveBeforeStop = 32;
            int milesLeftToDrive = totalMilesOfTrip - milesDroveBeforeStop;
            Console.WriteLine("Question 24: " + milesLeftToDrive + " miles were left to drive.");


            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */

            double hoursSpentShovelingSatMorning = ((1.000) + (30.000 / 60.000));
            double hoursSpentShovelingSatAfternoon = (0.000) + (45.000 / 60.000);
            double totalHoursSpentShoveling = hoursSpentShovelingSatMorning + hoursSpentShovelingSatAfternoon;
            Console.WriteLine("Question 25: " + totalHoursSpentShoveling + " total hours were spent shoveling by Mrs. Hilt");


            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            int numberOfHotDogsPurchased = 6;
            decimal priceOfHotDog = 0.50M;
            decimal rawTotalPaidForHotDogs = numberOfHotDogsPurchased * priceOfHotDog;

            //Format amount paid for hot dogs:
            string formattedTotalPaidForHotDogs = String.Format("Question 26: Mrs. Hilt paid {0:C} for {1} hot dogs.",
                rawTotalPaidForHotDogs, numberOfHotDogsPurchased);

            //Display amount paid for hot dogs:
            Console.WriteLine(formattedTotalPaidForHotDogs);


            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal mrsHiltsMoneyForPencils = 0.50M;
            decimal costOfEachPencil = 0.07M;
            int numberOfPencilsAffordable = (int)(mrsHiltsMoneyForPencils / costOfEachPencil);

            Console.WriteLine("Question 27: " + numberOfPencilsAffordable + " pencils can be bought with the money Mr. Hilt has.");


            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalButterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterfliesSeen - orangeButterflies;
            Console.WriteLine("Question 28: " + redButterflies + " of the butterflies were red.");


            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal moneyKateGaveToClerk = 1.00M;
            decimal costOfCandy = 0.54M;
            decimal rawKatesChangeBack = moneyKateGaveToClerk - costOfCandy;

            //Format amount Kate recieves
            string formattedKatesChangeBack = String.Format("Question 29: Kate should get back {0:C}.", rawKatesChangeBack);

            //Display Result
            Console.WriteLine(formattedKatesChangeBack);


            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int marksInitialTrees = 13;
            int marksAdditionalTrees = 12;
            int marksTotalTrees = marksInitialTrees + marksAdditionalTrees;
            Console.WriteLine("Question 30: " + marksTotalTrees + " is how many trees Mark will have.");


            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int hoursPerDay = 24;
            double daysTillJoySeesGrandma = 2.000;
            double hoursTillJoySeesGrandma = hoursPerDay * daysTillJoySeesGrandma;
            Console.WriteLine("Question 31: " + hoursTillJoySeesGrandma + " hours until Joy sees her grandma.");


            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int numberOfKimsCousins = 4;
            int piecesOfGumToGiveEachCousin = 5;
            int totalPiecesOfGumNeeded = numberOfKimsCousins * piecesOfGumToGiveEachCousin;
            Console.WriteLine("Question 32: " + totalPiecesOfGumNeeded + " pieces of gum are needed for Kim to give out.");


            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal dansInitialMoney = 3.00M;
            decimal costOfCandyBar = 1.00M;
            decimal rawDansRemainingMoney = dansInitialMoney - costOfCandyBar;

            //Format Dan's remaining money:
            string formattedDansRemainingMoney = String.Format("Question 33: Dan has {0:C} left.", rawDansRemainingMoney);

            //Display Dan's remaining money:
            Console.WriteLine(formattedDansRemainingMoney);


            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int numberOfBoatsInLake = 5;
            int peoplePerBoat = 3;
            int totalPeopleOnBoatsInLake = numberOfBoatsInLake * peoplePerBoat;
            Console.WriteLine("Question 34: " + totalPeopleOnBoatsInLake + " people are on boats in the lake.");


            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int ellensInitialLegoCount = 380;
            int ellensLostLegoCount = 57;
            int ellensFinalLegoCount = ellensInitialLegoCount - ellensLostLegoCount;
            Console.WriteLine("Question 35: " + ellensFinalLegoCount + " is how many legos Ellen has now.");


            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int arthursBakedMuffinCount = 35;
            int arthursBakedMuffinGoal = 83;
            int arthersBakedMuffinsNeeded = arthursBakedMuffinGoal - arthursBakedMuffinCount;
            Console.WriteLine("Question 36: " + arthersBakedMuffinsNeeded + " muffins are needed to be baked." );


            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willysCrayonCount = 1400;
            int lucysCrayonCount = 290;
            int willysExcessCrayonsOverLucy = willysCrayonCount - lucysCrayonCount;
            Console.WriteLine("Question 37: " + willysExcessCrayonsOverLucy + " is how many more crayons Willy has than Lucy.");


            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickersPerPage = 10;
            int pageOfStickersCount = 22;
            int totalStickerCount = stickersPerPage * pageOfStickersCount;
            Console.WriteLine("Question 38: " + totalStickerCount + " is how many stickers you have.");


            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            double cupcakeCount = 96.00;
            int numberOfChildren = 8;
            double cupcakesPerPerson = cupcakeCount / numberOfChildren;
            Console.WriteLine("Question 39: " + cupcakesPerPerson + " is how many cupcakes each person will get.");


            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int gingerbreadCookieCount = 47;
            int cookiesPerJar = 6;
            int numberOfExtraCookies = gingerbreadCookieCount % cookiesPerJar;
            Console.WriteLine("Question 40: " + numberOfExtraCookies + " cookies will not be placed in a jar.");


            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int totalNumberOfCroissants = 59;
            int numberOfNeighbors = 8;
            int leftoverCroissantCount = totalNumberOfCroissants % numberOfNeighbors;
            Console.WriteLine("Question 41: " + leftoverCroissantCount + " croissants will be left with Marian.");


            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            decimal cookiesPerTray = 12.00M;
            decimal cookesDesiredPerBatch = 276.00M;
            decimal traysNeeded = (cookesDesiredPerBatch / cookiesPerTray);
            //Used decimal type in tandem with Ceiling call to handle partial-tray situations
            Console.WriteLine("Question 42: " + Math.Ceiling(traysNeeded) + " trays are needed.");


            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int numberOfPretzelsMarianMade = 480;
            int pretzelServingSize = 12;
            int numberOfPretzelServingsPossible = numberOfPretzelsMarianMade / pretzelServingSize;
            Console.WriteLine("Question 43: " + numberOfPretzelServingsPossible + " servings of pretzels can be prepared.");


            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int totalLemonCupcakesBaked = 53;
            int numberOfLemonCupcakesLeftHome = 2;
            int numberOfLemonCupcakesGivenAway = totalLemonCupcakesBaked - numberOfLemonCupcakesLeftHome;
            int numberOfLemonCupcakesPerBox = 3;
            int numberOfLemonCupcakeBoxesGiven = numberOfLemonCupcakesGivenAway / numberOfLemonCupcakesPerBox;
            Console.WriteLine("Question 44: " + numberOfLemonCupcakeBoxesGiven + " boxes of lemon cupcakes were given away.");


            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int totalCarrotSticks = 74;
            int numberOfPeopleEatingCarrotSticks = 12;
            int numberOfCarrotSticksUneaten = totalCarrotSticks % numberOfPeopleEatingCarrotSticks;
            Console.WriteLine("Question 45: " + numberOfCarrotSticksUneaten + " carrot sticks were left uneaten.");


            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int numberOfTeddyBears = 98;
            int numberOfTeddyBearsPerShelf = 7;
            int numberOfFullTeddyShelves = numberOfTeddyBears / numberOfTeddyBearsPerShelf;
            Console.WriteLine("Question 46: " + numberOfFullTeddyShelves + " shelves will be completely filled.");


            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            decimal photosPerAlbum = 20.00M;
            decimal numberOfPhotosDesired = 480.00M;
            decimal numberOfAlbumsNeeded = (numberOfPhotosDesired / photosPerAlbum);
            //Used decimal type in tandem with Ceiling call to handle partial-album situations
            Console.WriteLine("Question 47: " + Math.Ceiling(numberOfAlbumsNeeded) + " albums are needed.");


            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int numberOfTradingCards = 94;
            int numberOfTradingCardsPerBox = 8;
            int numberOfBoxesFilled = numberOfTradingCards / numberOfTradingCardsPerBox;
            int numberOfCardsInUnfilledBox = numberOfTradingCards % numberOfTradingCardsPerBox;

            Console.WriteLine("Question 48: " + numberOfBoxesFilled + " boxes were filled and there were " +
                numberOfCardsInUnfilledBox + " cards in the unfilled box.");


            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int totalNumberOfBooks = 210;
            int totalNumberOfShelves = 10;
            int numberOfBooksPerShelf = totalNumberOfBooks / totalNumberOfShelves;
            Console.WriteLine("Question 49: " + numberOfBooksPerShelf + " books will be contained on each shelf.");


            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int numberOfCroissantsBaked = 17;
            int numberOfGuestsEatingCroissants = 7;
            int numberOfFullCroissantsPerGuest = numberOfCroissantsBaked / numberOfGuestsEatingCroissants;
            Console.WriteLine("Question 50: " + numberOfFullCroissantsPerGuest + " full croissants for each guest.");


            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            decimal billsSquareFootagePerHour = (12M * 14M) / 2.15M;
            decimal jillsSquareFootagePerHour = (12M * 14M) / 1.90M;
            decimal combinedSquareFootagePerHour = billsSquareFootagePerHour + jillsSquareFootagePerHour;
            decimal numberOfRoomsToPaint = 5M;
            decimal squareFootagePerRoom = (12M * 14M);
            decimal totalSquareFootageToPaint = numberOfRoomsToPaint * squareFootagePerRoom;
            decimal combinedHoursToPaintRooms = totalSquareFootageToPaint / combinedSquareFootagePerHour;
            decimal challengeNumberOfRoomsToPaint = 623M;
            decimal challengeTotalSquareFootageToPaint = challengeNumberOfRoomsToPaint * squareFootagePerRoom;
            decimal hoursInAWorkDay = 8M;
            decimal challengeDaysToComplete = challengeTotalSquareFootageToPaint / combinedSquareFootagePerHour / hoursInAWorkDay;
            Console.WriteLine("Challenge Question 1: " + combinedHoursToPaintRooms + " hours to paint 5 rooms and it would take " +
                challengeDaysToComplete + " work days to paint 623 rooms.");




            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            string myFirstName = "Grant";
            string myLastName = "Payne";
            string myMiddleInitial = "D.";
            string myFullName = myLastName + ", " + myFirstName + " " + myMiddleInitial;
            Console.WriteLine("Challenge Question 2: " + myFullName);



            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

            decimal totalDistanceOfTrainTrip = 800.00M;
            decimal currentDistanceTrainCompleted = 537.00M;
            decimal percentageOfTrainTripCompleted = (currentDistanceTrainCompleted / totalDistanceOfTrainTrip) * 100;

            /*Displays result as a casted integer percentage representation of the decimal result variable:
              --NOTE:  This could be done more accurately by calling Math.Round() instead of casting (int)  
            */
            Console.WriteLine("Challenge Question #3 " + (int)(percentageOfTrainTripCompleted) + "% of the trip has been completed.");

            Console.ReadLine();
        }
    }
}
