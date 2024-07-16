using CollectionsTask.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTask
{
    public class Bullet
    {
        private static int id = 0;
        public int Id { get; }
        public BulletType Type { get; }

        public Bullet(BulletType type)
        {
            Type = type;
            Id = ++id;
        }
    }
}
