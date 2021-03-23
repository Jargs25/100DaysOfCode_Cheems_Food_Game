using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _100DaysOfCode_Cheems_Food_Game
{
    public partial class frmGame : Form
    {
        public string path;
        public Thread trdFood;
        public Thread trdBonus;
        public delegate void DelBone(PictureBox pbx);
        public delegate void DelBoneStart(PictureBox pbx, Size pnt);
        public delegate void DelBoneImage(PictureBox pbx, string name);
        public int contBonus = 0;
        public int contMove = 0;
        public string lastMove = "Right";
        public int puntosFood = 1;
        public int puntosBonus = 5;
        public int puntos = 0;
        public int tiempo = 50;

        public int gravedad = 13;
        Random rPositionX = new Random();

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath.Replace("bin\\Debug", "Imagenes\\");
            NewImage(pbxBone, "Hueso.png");
            NewImage(pbxBonus, "Pastelfresa.png");
            NewImage(pbxCheems, "Right\\0.png");

            trdFood = new Thread(new ThreadStart(() => StartDown(pbxBone)));
            trdFood.Start();
            trdBonus = new Thread(new ThreadStart(() => StartBonus(pbxBonus)));
            trdBonus.Start();
            Focus();
            lblCTiempo.Text = "00:" + tiempo.ToString();
            tmrTiempo.Start();
        }

        private void StartDown(PictureBox pbx)
        {
            int velocidad = 0, maximo = 0, aceleracion = 0, last = 0;
            int locY = pbx.Location.Y;
            ReStart(pbx, new Size(rPositionX.Next(0, 661), locY));
            int tipoComida = 0;
            int contTipoC = 0;

            while (true)
            {
                velocidad = Convert.ToInt32(318 - (pbxBone.Location.Y + 42));
                maximo = Convert.ToInt32(50 / gravedad);
                aceleracion = (velocidad / gravedad);
                last = 1;
                while (pbx.Location.Y < 318 && pbx.Enabled)
                {
                    Thread.Sleep(velocidad > maximo ? velocidad : maximo);
                    Down(pbx);
                    if (maximo < velocidad)
                    {
                        velocidad = velocidad - aceleracion;
                        aceleracion = velocidad / gravedad;
                        if (aceleracion > 0) last = aceleracion;
                        else aceleracion = last;
                    }
                }
                if (pbx.Enabled)
                {
                    Thread.Sleep(500);
                    if (pbx.Enabled)
                    for (int i = 0; i < 7; i++)
                    {
                        if (pbx.Enabled)
                        {
                            Thread.Sleep(250);
                            Show(pbx);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                
                ReStart(pbx, new Size(rPositionX.Next(0, 604), locY));
                
                tipoComida = rPositionX.Next(0, 100);
                if (tipoComida > 50 && contTipoC > 3)
                {
                    NewImage(pbx, "Pierna.png");
                    contTipoC = 0;
                    puntosFood = 3;
                }
                else
                {
                    NewImage(pbx, "Hueso.png");
                    puntosFood = 1;
                    contTipoC++;
                }

                contBonus++;
                if (!pbx.Visible)
                {
                    Show(pbx);
                }
                if (!pbx.Enabled)
                {
                    Eaten(pbx);
                }
            }


            //Thread.CurrentThread.Abort();
        }
        private void StartBonus(PictureBox pbx)
        {
            while (true)
            {
                if (contBonus == 4)
                {
                    Show(pbx);
                    Eaten(pbx);
                    puntosBonus = 5;
                }
                //else if (contBonus == 8)
                //{
                //    contBonus = 0;
                //}

                if (contBonus == 4)
                {
                    if (pbx.Enabled)
                    {
                        Thread.Sleep(1000);
                        if (pbx.Enabled)
                        for (int i = 0; i < 7; i++)
                        {
                            if (pbx.Enabled)
                            {
                                Thread.Sleep(250);
                                Show(pbx);
                            }
                            else
                            {
                                Show(pbx);
                                break;
                            }
                        }
                    }
                    contBonus = 0;
                    ReStart(pbx, new Size(rPositionX.Next(0,621),pbx.Location.Y));
                }
                Thread.Sleep(1000);
            }
        }

        private void Down(PictureBox pbx)
        {
            if (pbx.InvokeRequired)
            {
                DelBone delBone = new DelBone(Down);
                pbx.Invoke(delBone, pbx);
            }
            else
            {
                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y + 1);
            }
        }
        private void Show(PictureBox pbx)
        {
            if (pbx.InvokeRequired)
            {
                DelBone delBone = new DelBone(Show);
                pbx.Invoke(delBone, pbx);
            }
            else
            {
                if (pbx.Visible)
                {
                    pbx.Visible = false;
                }
                else
                {
                    pbx.Visible = true;
                }
            }
        }
        private void Eaten(PictureBox pbx)
        {
            if (pbx.InvokeRequired)
            {
                DelBone delBone = new DelBone(Eaten);
                pbx.Invoke(delBone, pbx);
            }
            else
            {
                pbx.Enabled = true;
            }
        }
        private void ReStart(PictureBox pbx, Size pnt)
        {
            if (pbx.InvokeRequired)
            {
                DelBoneStart delBone = new DelBoneStart(ReStart);
                pbx.Invoke(delBone, new object[]{ pbx, pnt});
            }
            else
            {
                pbx.Location = new Point(pnt);
            }
        }
        private void NewImage(PictureBox pbx, string name)
        {
            if (pbx.InvokeRequired)
            {
                DelBoneImage delBone = new DelBoneImage(NewImage);
                pbx.Invoke(delBone, new object[] { pbx, name });
            }
            else
            {
                pbx.Image = Image.FromFile(path + name);
            }
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            trdFood.Abort();
            trdBonus.Abort();
        }
        private void frmGame_Leave(object sender, EventArgs e)
        {
            Focus();
        }

        private void frmGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int chemsLocX = 0;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (pbxCheems.Location.X < 540)
                    {
                        pbxCheems.Location = new Point(pbxCheems.Location.X + 20, pbxCheems.Location.Y);
                        if (lastMove != Keys.Right.ToString()) contMove = 0;
                        contMove++;
                        if (contMove > 3) contMove = 0;
                        NewImage(pbxCheems, "Right\\" + contMove + ".png");
                        lastMove = Keys.Right.ToString();
                        chemsLocX = pbxCheems.Location.X + 160;
                    }
                    break;
                case Keys.Left:
                    if (pbxCheems.Location.X > 0)
                    {
                        pbxCheems.Location = new Point(pbxCheems.Location.X - 20, pbxCheems.Location.Y);
                        if (lastMove != Keys.Left.ToString()) contMove = 0;
                        contMove++;
                        if (contMove > 3) contMove = 0;
                        NewImage(pbxCheems, "Left\\" + contMove + ".png");
                        lastMove = Keys.Left.ToString();
                        chemsLocX = pbxCheems.Location.X;
                    }
                    break;
            }

            if (chemsLocX > pbxBone.Location.X && chemsLocX < pbxBone.Location.X + 100 &&
                pbxCheems.Location.Y < pbxBone.Location.Y && pbxBone.Enabled)
            {
                puntos = puntos + puntosFood;
                pbxBone.Visible = false;
                pbxBone.Enabled = false;
                lblCPuntos.Text = puntos.ToString();
            }
            if (chemsLocX > pbxBonus.Location.X && chemsLocX < pbxBonus.Location.X + 70 &&
                pbxCheems.Location.Y < pbxBonus.Location.Y && pbxBonus.Enabled)
            {
                puntos = puntos + puntosBonus;
                pbxBonus.Visible = false;
                pbxBonus.Enabled = false;
                lblCPuntos.Text = puntos.ToString();
                tiempo = tiempo + 5;
                lblCTiempo.Text = "00:" + (tiempo > 9 ? tiempo.ToString() : "0" + tiempo.ToString());
            }
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCTiempo.Text = "00:" + (tiempo > 9 ? tiempo.ToString() : "0" + tiempo.ToString());
            if (tiempo <= 0)
            {
                trdFood.Abort();
                trdBonus.Abort();
                lblGO.Visible = true;
                tmrTiempo.Stop();
            }
        }
    }
}
