using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Character
    {
        private const int GO_INC = 3;

        public Vector2 MoveSpeed { get; private set; }
        public Vector2 LastPosition { get; private set; }
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }
        private List<string> Inventory = new List<string>();

        public Character(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;

        }

          LastPosition = P
        {
            Position = new Vector2(P
            Collider.MovePosition((int)Position.x, (int)Position.y);
          }
        }

          Position = LastPosit
        {
          }
        }

          MoveSpeed = new Ve
        {
          }
        }
        public void GoRight()
        {
            MoveSpeed = new Vector2(+GO_INC, 0);
        }
        public void GoUp()
        {
            MoveSpeed = new Vector2(0, -GO_INC);
        }
        public void GoDown()
        {
            MoveSpeed = new Vector2(0, +GO_INC);
        }

        public void ResetMoveSpeed()
        {
            MoveSpeed = new Vector2(0, 0);
        }

        public void InventoryAdd(string item)
        {
            Console.WriteLine("Adding: ");

            Inventory.Add(item);
            Inventory.ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine();
        }

        // eventually made items a class?
        public string InventoryRemove(int index)
        {
            Console.WriteLine("Removing: ");

            string item = Inventory[index];
            Inventory.RemoveAt(index);
            Inventory.ForEach(Console.Write);

            Console.WriteLine();
            Console.WriteLine();

            return item;
        }
  }
