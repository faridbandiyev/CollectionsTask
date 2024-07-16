using CollectionsTask;
using CollectionsTask.Helpers.Enums;
using System;
using System.Collections.Generic;

Weapon weapon = new Weapon(BulletType.ArmorPiercing, 5);

List<Bullet> bulletCollection = new List<Bullet>
            {
                new Bullet(BulletType.ArmorPiercing),
                new Bullet(BulletType.Expanding),
                new Bullet(BulletType.HollowBase),
                new Bullet(BulletType.ArmorPiercing),
                new Bullet(BulletType.Expanding)
            };

weapon.Fill(bulletCollection);

bool exit = false;

while (!exit)
{
    Console.WriteLine("Choose an action:");
    Console.WriteLine("1. Fire Weapon");
    Console.WriteLine("2. Pull Trigger");
    Console.WriteLine("3. Exit");

    string choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            weapon.Fire();
            break;

        case "2":
            weapon.PullTrigger();
            break;

        case "3":
            exit = true;
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine();
}

