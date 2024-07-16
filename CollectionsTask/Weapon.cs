﻿using CollectionsTask.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTask
{
    public class Weapon
    {
        private static int id = 0;
        public int Id { get; }
        public BulletType Type { get; private set; }
        public int MaxCapacity { get; private set; }
        private Stack<Bullet> bullets;

        public Weapon(BulletType type, int maxCapacity)
        {
            Id = ++id;
            Type = type;
            MaxCapacity = maxCapacity;
            bullets = new Stack<Bullet>();
        }

        public void Fill()
        {
            for (int i = 0; i < MaxCapacity; i++)
                bullets.Push(new Bullet(Type));
            bullets.Clear();
        }

        public void Fire()
        {
            if (bullets.Count > 0)
            {
                Bullet firedBullet = bullets.Pop();
                Console.WriteLine($"Type: {firedBullet.Type}, Remaining Bullets: {bullets.Count}");
            }
            else
            {
                Console.WriteLine("No bullets left.");
            }
        }

        public void PullTrigger()
        {
            if (bullets.Count > 0)
            {
                Bullet nextBullet = bullets.Peek();
                Console.WriteLine($"Type: {nextBullet.Type}");
            }
            else
            {
                Console.WriteLine("No bullets inside.");
            }
        }
    }
}
