// public static class Probe {
//     public static void Run() {
//         Console.WriteLine(">>> Проба <<<");
//     Guild probeGuild = new Guild("Учебная гильдия");
//     Hero probeWarrior = new Hero("Учебный воин", 150);

//     probeGuild.Heroes.Add(probeWarrior);
//     probeGuild.Heroes.Add(probeWarrior);
//     Console.WriteLine($"Записей: {probeGuild.Heroes.Count}");

//     probeWarrior.TakeDamage(30);
//     foreach (Hero hero in probeGuild.Heroes) {
//         Console.WriteLine($"{hero.Name}: {hero.Health}");
//         }
//     }
// }
// Guild traceGuild = new Guild("Трассировка");
// Hero first = new Hero("Первый", 100);
// Hero second = new Hero("Второй", 80);

// traceGuild.Heroes.Add(first);
// traceGuild.Heroes.Add(second);
// traceGuild.Heroes.Add(first);

// first.TakeDamage(30);

// Console.WriteLine(traceGuild.Heroes.Count);
// Console.WriteLine(traceGuild.Heroes[2].Health);
// foreach (Hero hero in traceGuild.Heroes) {
//     Console.WriteLine($"{hero.Name}: {hero.Health}");
// }
// Console.WriteLine(traceGuild.Heroes[traceGuild.Heroes.Count - 2].Name);
//     }
// }

// //ЧАСТЬ Д1!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// public static class Probe {
//     public static void Run() {
//         Console.WriteLine(">>> Проба <<<");

//         Guild testGuild = new Guild("Тестовая гильдия");
//         testGuild.Heroes.Add(new Hero("Александр", 150));
//         testGuild.Heroes.Add(new Hero("Ярослав", 100));
//         testGuild.Heroes.Add(new Hero("Анастасия", 90));

//         Console.WriteLine("Д.1");
        
//         Guild secondGuild = new Guild("Вторая гильдия");
        
//         Console.WriteLine($"Элементов во второй гильдии до добавления: {secondGuild.Heroes.Count}");

//         foreach (Hero h in secondGuild.Heroes) {
//             Console.WriteLine($"Имя: {h.Name}");
//         }

//         Hero heroFromFirst = testGuild.Heroes[0]; 
//         secondGuild.Heroes.Add(heroFromFirst);
        
//         Console.WriteLine($"Элементов во второй гильдии после добавления: {secondGuild.Heroes.Count}");


//         Console.WriteLine("Д.2");

//         if (testGuild.Heroes.Count > 0) {
//             int totalHealth = 0;
            
//             foreach (Hero h in testGuild.Heroes) {
//                 totalHealth += h.Health;
//             }
            
//             int averageHealth = totalHealth / testGuild.Heroes.Count;
//             Console.WriteLine($"Среднее здоровье: {averageHealth}");

//             int aboveAverageCount = 0;
//             foreach (Hero h in testGuild.Heroes) {
//                 if (h.Health > averageHealth) {
//                     aboveAverageCount++;
//                 }
//             }
            
//             Console.WriteLine($"Героев со здоровьем выше среднего: {aboveAverageCount}");
//         }
//         else {
//             Console.WriteLine("Гильдия пуста, среднее здоровье не посчитать.");
//         }
//     }
// }
