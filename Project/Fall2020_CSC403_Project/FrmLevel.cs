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
    private Enemy Doritto; //new enemy called doritto
    private Enemy Knife; // new enemy called knife
    private Enemy GrapeKoolAid; // new enemy called GrapeKoolAid
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;


    System.Random random = new System.Random(); // calls the random class

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));


      RandomEnemies();


      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      Doritto = new Enemy(CreatePosition(picEnemyDorittoMan), CreateCollider(picEnemyDorittoMan, PADDING));
      Knife = new Enemy(CreatePosition(picEnemyKnife), CreateCollider(picEnemyKnife, PADDING));
      GrapeKoolAid = new Enemy(CreatePosition(picEnemyGrapeKoolAid), CreateCollider(picEnemyGrapeKoolAid, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      Doritto.Img = picEnemyDorittoMan.BackgroundImage;
      Knife.Img = picEnemyKnife.BackgroundImage;
      GrapeKoolAid.Img = picEnemyGrapeKoolAid.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      Doritto.Color = Color.AliceBlue;
      Knife.Color = Color.Brown;
      GrapeKoolAid.Color = Color.Purple;

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

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }

      else if(HitAChar(player, Doritto))
      {
        Fight(Doritto);
      }

      else if(HitAChar(player, Knife))
      {
        Fight(Knife);
      }

      else if(HitAChar(player, GrapeKoolAid))
      {
        Fight(GrapeKoolAid);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
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

    private int [] Generate_RandomNumbers()
    {
            int max = 5;
            int number1 = random.Next(max);
            int number2 = random.Next(max);
            int number3 = random.Next(max);
            int number4 = random.Next(max);

            while((number1 == number2) || (number1 == number3) || (number1 == number4))
            {
                number1 = random.Next(max);
            }
            while((number2 == number3) || (number2 == number4))
            {
                number2 = random.Next(max);
            }
            while(number3 == number4)
            {
                number3 = random.Next(max);
            }
            int[] RandomNumbers = { number1, number2, number3, number4 };
            return RandomNumbers;
    }
        
    private void RandomEnemies()

    {
            int[] RandomPosition = Generate_RandomNumbers();
            picEnemyPoisonPacket.Visible = false;
            picEnemyCheeto.Visible = false;
            picEnemyDorittoMan.Visible = false;
            picEnemyKnife.Visible = false;
            picEnemyGrapeKoolAid.Visible = false;

            foreach (int i in RandomPosition)
            {
                if (i == 0)
                    picEnemyPoisonPacket.Visible = true;
                else if (i == 1)
                    picEnemyCheeto.Visible = true;
                else if (i == 2)
                    picEnemyDorittoMan.Visible = true;
                else if (i == 3)
                    picEnemyKnife.Visible = true;
                else if (i == 4)
                    picEnemyGrapeKoolAid.Visible = true;
            }

        }
    }
}
