public static class Probe {
    public static void Run() {
        Console.WriteLine(">>> Проба <<<");
    Guild probeGuild = new Guild("Учебная гильдия");
    Hero probeWarrior = new Hero("Учебный воин", 150);

    probeGuild.Heroes.Add(probeWarrior);
    probeGuild.Heroes.Add(probeWarrior);
    Console.WriteLine($"Записей: {probeGuild.Heroes.Count}");

    probeWarrior.TakeDamage(30);
    foreach (Hero hero in probeGuild.Heroes) {
        Console.WriteLine($"{hero.Name}: {hero.Health}");
        }
    }
}
