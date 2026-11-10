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
public static class Probe {
    public static void Run() {
        Console.WriteLine(">>> Проба <<<");
    }
}