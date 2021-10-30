using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Item
    {
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }
        public string Name { get; private set; }

        public Item(string name, Vector2 initPos, Collider collider)
        {
            Name = name;
            Position = initPos;
            Collider = collider;
        }
    }
}
