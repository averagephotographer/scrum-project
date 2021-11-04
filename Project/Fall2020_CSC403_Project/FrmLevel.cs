using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel : Form {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Item health;
        private Item health2;
        private Character[] walls;
        private Item offScreen; // whenever an enemy dies, set that enemy to this instance (a hidden pictureBox)
        private Enemy offScreenEnemy;
        private Player offScreenPlayer;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public FrmLevel() {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e) {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            health = new Item("Health", CreatePosition(picHeartContainer), CreateCollider(picHeartContainer, PADDING));
            health2 = new Item("Health", CreatePosition(picHeartContainer2), CreateCollider(picHeartContainer2, PADDING));
            offScreen = new Item("off_screen", CreatePosition(picOffScreen), CreateCollider(picOffScreen, 1));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            health.Img = picHeartContainer.BackgroundImage;
            
            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            
            offScreenEnemy = new Enemy(CreatePosition(picOffScreen), CreateCollider(picOffScreen, 0));
            offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++) {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
            
        }

        private Vector2 CreatePosition(PictureBox pic) {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding) {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e) {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player)) {
                player.MoveBack();
            }

            // check collision with item
            if (HitAnItem(player, health)) {
                player.InventoryAdd(health);

                // removes the image
                picHeartContainer.Hide();

                // sets the item to an already made iteam
                health = offScreen;

                // show the item in inventory
                // this is just a quick fix
                // TODO: base this off of the character array

                
                picHeartIndex0.Show(); // this image starts off hidden

                // stackoverflow.com/a/20060498/16369768
                picInventory0.Controls.Add(picHeartIndex0); // adds picture to picturebox
                picHeartIndex0.Location = new Point(6, 6); // places the new picture in the frame
            }

            // idea: superclass item
            // todo: this["health" + x]
            // subclass heart
            if (HitAnItem(player, health2)) {
                player.InventoryAdd(health2);
                
                // removes the image
                picHeartContainer2.Hide();

                // sets the item to an already made iteam
                health2 = offScreen;

                // show the item in inventory
                // this is just a quick fix
                // TODO: base this off of the character array
                picHeartIndex1.Show();
                picInventory1.Controls.Add(picHeartIndex1);
                picHeartIndex1.Location = new Point(6, 6);
            }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket)) {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto)) {
                Fight(enemyCheeto);
            }
            if (HitAChar(player, bossKoolaid)) {
                Fight(bossKoolaid);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    

            // Remove dead player's image
            if (IsDead(player)) {
                picPlayer.Hide();
                player = offScreenPlayer;
                player.Die();
            }

            // Remove the dead enemies' images
            if (IsDead(enemyPoisonPacket)) {
                picEnemyPoisonPacket.Hide();
                enemyPoisonPacket = offScreenEnemy;
            }
            else if (IsDead(enemyCheeto)) {
                picEnemyCheeto.Hide();
                enemyCheeto = offScreenEnemy;
                    }
            else if (IsDead(bossKoolaid)) {
                picBossKoolAid.Hide();
                bossKoolaid = offScreenEnemy;
            }

            // Update health
            PlayerHealthBar();
        }

        private bool HitAWall(Character c) {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++) {
                if (c.Collider.Intersects(walls[w].Collider)) {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other) {
            return you.Collider.Intersects(other.Collider);
        }

        private bool HitAnItem(Character you, Item other) {

            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy) {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid) {
                frmBattle.SetupForBossBattle();
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e) {
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
        }

        private void picHeartContainer2_Click(object sender, EventArgs e) {
        }

        private void picInventory2_Click(object sender, EventArgs e) {
        }

        private void picHeartIndex1_Click(object sender, EventArgs e) {
        }
    
        // Function for update the player's health bar on the main map
        public void PlayerHealthBar() {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            
            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
        }

        // check if enemy is dead
        public bool IsDead(BattleCharacter character) {
            bool isDead = false;
            if (character.Health <= 0) {
                isDead = true;
            }
            return isDead;
        }
    }
}
