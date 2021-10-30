using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;




    
        {
          private void FrmLevel_Lo
        }

    
        {
            player = new Player(Cr
            player.InventoryAdd("Hear

            player.InventoryRemove(0);
      
            bossKoolaid = new Enemy(Create
            enemyPoisonPacket = new En

      
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;

      
            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;

      
            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++) {

              walls[w] = new Character(Create
            }
            {
        
              Game.player = player;
            }

      
          private Vector2 CreatePosit
        }

    
        {
          private Collider CreateCollider(PictureBox pic, int p
        }

        }
        {
      
          private void FrmLevel_KeyUp(
        }

    
        {
          private void tmrUpdateInGa
        }

          lblInGameTime.Text = "Time: " + time.ToString();
        {
          }
      
          private void tmrPlayerMove_Tick(object sender, Eve
        }

    
        {
            // move player
            if (HitAWall(p

            // check collision with walls
      
            {
              // check collision w
            }

            // check collision with enemies
            else if (HitAChar(player, enemyCheeto)) 
            {
                Fight(enemyCheeto);
            }
            if (HitAChar(player, bossKoolaid)) {
            {
                Fight(bossKoolaid);
            }
      
            {
              // update player's pi
            }

            // update player's picture box
          private bool HitAWall(Character c) {
        }

            if (c.Collider.Intersects(wall
        {
                hitAWall = true;
                break;
            {
                }
                {
                }
                    break;
                }
            }
            return hitAWall;
        }

    
        {
          private void Fight(Enemy enemy) {
        }

          frmBattle = FrmBattle.GetInst
        {
            frmBattle.Show();
      
            if (enemy == bossKoolaid) {
              frmBattle.Setup

          }
            {
        
            }
        }

              player.GoLeft();
        {
                break;
            {
        
                  case Keys.Right:
                    break;

        
                  case Keys.Up:
                    break;

        
                  case Keys.Down:
                    break;

        
                  default:
                    break;

                default:
              }
                    break;
            }
        }

      }
        {

    