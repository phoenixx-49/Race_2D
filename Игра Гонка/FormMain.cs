using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_Гонка
{
    public partial class FormMain : Form
    {
        #region <Переменные>

        private Point Pos;//координаты первоначальной позиции мышки
        private bool Dragging;//информация о том: передвигаем мы сейчас окно или нетч
        int CountCoins = 0;//колчество монет при старте игры

        SoundPlayer SoundCoin = new SoundPlayer(Properties.Resources.zakinuli_monetku_v_kopilku);
        SoundPlayer SoundAvaria = new SoundPlayer(Properties.Resources.material_zvukovoy_effekt_stolknoveniya_razdavit_39619);
        #endregion
        public FormMain()
        {
            InitializeComponent();

            PbxTrack1.MouseDown += PbxTrack_MouseDown;
            PbxTrack1.MouseUp += PbxTrack_MouseUp;
            PbxTrack1.MouseMove += PbxTrack_MouseMove;

            PbxTrack2.MouseDown += PbxTrack_MouseDown;
            PbxTrack2.MouseUp += PbxTrack_MouseUp;
            PbxTrack2.MouseMove += PbxTrack_MouseMove;

            LblDefeat.Hide();
            BtnRestart.Hide();

            KeyPreview = true;

        }
        /// <summary>
        /// перемещение окна
        /// </summary>
        private void PbxTrack_MouseMove(object sender, MouseEventArgs e)
        {
            //если перетаскивание включено
            if (Dragging)
            {
                //получение текущих координат мышки
                Point CurrentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(CurrentPoint.X - Pos.X, CurrentPoint.Y - Pos.Y +PbxTrack1.Top);
            }
        }

        private void PbxTrack_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;//перетаскивание закончено
        }

        /// <summary>
        /// перемещение окна
        /// </summary>
        private void PbxTrack_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;//перетаскивание начато
            //запоминаем позицию мышки
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// движение трассы
        /// </summary>
        private void TimerAnim_Tick(object sender, EventArgs e)
        {

            int speed = 5;//скорость
            Random Rnd = new Random();

            PbxTrack1.Top += speed;
            PbxTrack2.Top += speed;

            int EnemySpeed = 8;
            PbxEnemy1.Top += EnemySpeed;
            PbxEnemy2.Top += EnemySpeed;

            PbxCoin.Top += speed;
            //движение трассы
            if (PbxTrack1.Top >= 650)
            {
                PbxTrack1.Top = 0;
                PbxTrack2.Top = -650;
            }
            //движение монетки
            if (PbxCoin.Top >= 650)
            {
                ChangeCoinPosition(Rnd);
            }
            //движение первого врага
            if (PbxEnemy1.Top >= 650)
            {
                PbxEnemy1.Top = -550;
                int PositionCar1 = Rnd.Next(155, 300);
                PbxEnemy1.Left = PositionCar1;
            }
            //движение второго врага
            if (PbxEnemy2.Top >= 650)
            {
                PbxEnemy2.Top = -1500;
                int PositionCar2 = Rnd.Next(300, 600);
                PbxEnemy2.Left = PositionCar2;

            }
            //если наш объект (машинка) пересекается с чем либо
            if (PbxCar.Bounds.IntersectsWith(PbxEnemy1.Bounds) || PbxCar.Bounds.IntersectsWith(PbxEnemy2.Bounds)) 
            {
                TimerAnim.Enabled = false;

                SoundAvaria.Play();

                LblDefeat.Show();
                BtnRestart.Show();
            }

            //подсчёт монет
            if(PbxCar.Bounds.IntersectsWith(PbxCoin.Bounds))
            {
                SoundCoin.Play();//проиграть звук сбора монетки
                CountCoins++;
                LblCountCoin.Text = CountCoins.ToString();
                ChangeCoinPosition(Rnd);
            }
        }
        /// <summary>
        /// изменение позиции монетки
        /// </summary>
        /// <param name="Rnd">рандом</param>
        private void ChangeCoinPosition(Random Rnd)
        {
            PbxCoin.Top = -100;
            int CoinPosition = Rnd.Next(155, 600);
            PbxCoin.Left = CoinPosition;
        }

        /// <summary>
        /// перемещение машинки (данное событие срабатывает всегда, пока пользователь нажимает на кнопку)
        /// </summary>
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 15;//скорость перемещения машинки

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && PbxCar.Left > 155)
            {
                PbxCar.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && PbxCar.Right < 685) 
            {
                PbxCar.Left += speed;
            }

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            PbxEnemy1.Top = -500;
            PbxEnemy2.Top = -1500;

            PbxCoin.Top = -500;
            CountCoins = 0;
            LblCountCoin.Text = CountCoins.ToString();

            LblDefeat.Hide();
            BtnRestart.Hide();

            TimerAnim.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
