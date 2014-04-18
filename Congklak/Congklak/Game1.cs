using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using Microsoft.Phone.Tasks;
using Microsoft.Devices;

namespace Congklak
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Boolean vsCPU;
        Boolean backgroundIndex = true;

        VibrateController vibrate = VibrateController.Default;
        Song musicAwalBackground, suaraPagi, suaraSiang, suaraMalam;
        SoundEffect soundBombs, pergantianJam, tikSound;

        Color warnaretryButtonFinal, warnaretryButtonFinal2, warnaexitButtonFinal, warnaexitButtonFinal2;
        Color warnaRestartbtn = Color.Transparent;
        Color warnaResumebtn = Color.Transparent;
        Color warnaMenuAwalBtn = Color.Transparent;
        Color warnaKanvasUser = Color.White;
        Color warnaPegang1 = new Color();
        Color warnaPegang2 = new Color();
        Color warnaLepas1 = new Color();
        Color warnaplayerPict = Color.Transparent;
        Color warnaplayerChar = Color.Transparent;
        Color warnavsCompbttn = Color.White;
        Color warnavsPlayer2bttn = Color.White;
        Color warnahelpbttn = Color.White;
        Color warnaexitbttn = Color.White;
        Color warnavsCompbttn2 = Color.Transparent;
        Color warnavsPlayer2bttn2 = Color.Transparent;
        Color warnahelpbttn2 = Color.Transparent;
        Color warnaexitbttn2 = Color.Transparent;
        Color warnahelppage = Color.Transparent;
        Color warnatakepict = Color.Transparent;
        Color warnatakepictbttn = Color.Transparent;
        Color warnatakepictbttn2 = Color.Transparent;
        Color warnabrowsebtn = Color.Transparent;
        Color warnabrowsebtn2 = Color.Transparent;
        Color warnagobtn = Color.Transparent;
        Color warnagobtn2 = Color.Transparent;
        Color warnaPauseMenu = Color.Transparent;
        Color warnaShare = Color.White;
        Color warnaShare1 = Color.Transparent;

        Boolean isGameOver;
        Boolean arahKiri = true;
        Boolean pauseButton = true;
        int kurakuraX, kurakuraY, kurakuraindex, inckurakura;
        int posisi;
        int Turn = 1;
        int posisiX;
        int posisiY;
        int isi = 30;
        int [] tempLobang = new int [18];
        int gameindex;
        int gerakHelpY1, gerakHelpY2, pembandingHelp;
        int bgX, bgY, bijiX, bijiY, pauseX, pauseY, winY;
        int indexResume, indexRestart, indexKembaliKeMenu;

        Logic logic = new Logic();
        Boolean canMove;
        Boolean tampilMenu = false;
        Texture2D splashScreen;
        Texture2D splashScreenAds;
        Texture2D kurakura;
        Texture2D youWin, youLose, plyr1Win, plyr2Win, finalResult, exitButtonFinal, exitButtonFinal2;
        Texture2D kembaliKeMenuAwal, retryButtonFinal, retryButtonFinal2;
        Texture2D resumeButton;
        Texture2D restartButton;
        Texture2D takeAPicture;
        Texture2D playerPict;
        Texture2D playerChar;
        Texture2D backgroundAwal;
        Texture2D nitebackground;
        Texture2D daybackground;
        Texture2D morningbackground;
        Texture2D afternoonbackground;
        Texture2D TanganPegangP1;
        Texture2D TanganLepasP1;
        Texture2D TanganPegangP2;
        Texture2D TanganLepasP2;
        Texture2D vsCompbttn;
        Texture2D vsPlayer2bttn;
        Texture2D helpbttn;
        Texture2D exitbttn;
        Texture2D vsCompbttn2;
        Texture2D vsPlayer2bttn2;
        Texture2D helpbttn2;
        Texture2D exitbttn2;
        Texture2D compTurn, compTurn1, compTurn2;
        Texture2D player1Turn;
        Texture2D player2Turn;
        Texture2D exitButton;
        Texture2D tanganPlayer;
        Texture2D helpPortrait;
        Texture2D takepictbttn;
        Texture2D takepictbttn2;
        Texture2D backgroundmerah;
        Texture2D kanvasUser;
        Texture2D browsebtn;
        Texture2D browsebtn2;
        Texture2D gobtn;
        Texture2D gobtn2;
        Texture2D pauseMenu;
        Texture2D share;
        Texture2D share1;
        
        SpriteFont fontValue;
        SpriteFont fontwinner;

        private Rectangle kembaliKeMenuRec = new Rectangle(304, 230, 110, 110);
        private Rectangle restartBtnRec = new Rectangle(430, 230, 110, 110);
        private Rectangle resumeBtnRec = new Rectangle(366, 134, 110, 110);
        private Rectangle lubang1 = new Rectangle(280,150, 70, 70);
        private Rectangle lubang2 = new Rectangle(518, 260, 70, 70);
        private Rectangle lubang3 = new Rectangle(441, 260, 70, 70);
        private Rectangle lubang4 = new Rectangle(364, 260, 70, 70);
        private Rectangle lubang5 = new Rectangle(287, 260, 70, 70);
        private Rectangle lubang6 = new Rectangle(210, 260, 70, 70);
        private Rectangle lubang7 = new Rectangle(133, 260, 70, 70);
        private Rectangle lubang8 = new Rectangle(46, 200, 70, 70);
        private Rectangle lubang9 = new Rectangle(133, 147, 70, 70);
        private Rectangle lubang10 = new Rectangle(210, 147, 70, 70);
        private Rectangle lubang11 = new Rectangle(287, 147, 70, 70);
        private Rectangle lubang12 = new Rectangle(364, 147, 70, 70);
        private Rectangle lubang13 = new Rectangle(441, 147, 70, 70);
        private Rectangle lubang14 = new Rectangle(518, 147, 70, 70);
        private Rectangle lubang15 = new Rectangle(595, 147, 70, 70);
        private Rectangle lubang16 = new Rectangle(678, 200, 70, 70);
        private Rectangle vsComputerBtn = new Rectangle(480, 5, 200, 100);
       
        private Rectangle vsCom = new Rectangle(185, 320, 50, 170);
        private Rectangle vsPlayer2 = new Rectangle(245, 320, 50, 170);
        private Rectangle exit = new Rectangle(365, 320, 50, 170);
        private Rectangle help = new Rectangle(305, 320, 50, 170);
        private Rectangle takephoto = new Rectangle(100, 310, 60, 170);
        private Rectangle browsephoto = new Rectangle(345, 310, 60, 170);
        private Rectangle goPlay = new Rectangle(345,625, 50, 120);
        private Rectangle retryFinalRec = new Rectangle(288, 370, 130, 70);
        private Rectangle exitFinalRec = new Rectangle(423, 370, 130, 70);
        private Rectangle shareRec = new Rectangle(380, 117, 40, 130);

        DateTime clockTime;
        DateTime dateTime;
        float waitForSplashscreen;
        int hour, minute, second;
        int helpX, helpY, helpIndex, takeaPictureIndex;
        int incEfek, incPause, incWin;

        public Game1()
        {
            waitForSplashscreen = 0;

            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = true;

            Content.RootDirectory = "Content";

            // Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333);

            // Extend battery life under lock.
            InactiveSleepTime = TimeSpan.FromSeconds(1);

            // Mengubah orientasi menjadi potrait
            graphics.SupportedOrientations = DisplayOrientation.Portrait;
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 480;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            takeaPictureIndex = 0;
            inckurakura = 0;
            bgawal = Color.White;
            incWin = 1;
            gameindex = 1;
            KondisiAwal();
            canMove = false;
            helpIndex = 0;
            helpX = 0;
            helpY = 0;
            bgX = 0;
            bgY = -5;
            bijiX = 0;
            bijiY = 0;
            incEfek = 0;
            incPause = 0;
            kurakuraindex = 1;
            warnaexitButtonFinal = Color.White;
            warnaexitButtonFinal2 = Color.Transparent;
            warnaretryButtonFinal = Color.White;
            warnaretryButtonFinal2 = Color.Transparent;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            share = this.Content.Load<Texture2D>("ShareButton");
            share1 = this.Content.Load<Texture2D>("ShareButton1");
            kurakura = this.Content.Load<Texture2D>("kurakura");
            suaraMalam = this.Content.Load<Song>("Owl_hoot");
            //suaraSiang = this.Content.Load<SoundEffect>("Suara Siang");
            suaraSiang = this.Content.Load<Song>("Bird_sound");
            suaraPagi = this.Content.Load<Song>("KONGKORONGOK");
            pergantianJam = this.Content.Load<SoundEffect>("Pergantian Jam");
            tikSound = this.Content.Load<SoundEffect>("tik");
            soundBombs = this.Content.Load<SoundEffect>("bombs");
            musicAwalBackground = this.Content.Load<Song>("musicAwal");
            exitButtonFinal = this.Content.Load<Texture2D>("exitFinal");
            exitButtonFinal2 = this.Content.Load<Texture2D>("exitFinal2");
            retryButtonFinal = this.Content.Load<Texture2D>("retry");
            retryButtonFinal2 = this.Content.Load<Texture2D>("retry2");
            finalResult = this.Content.Load<Texture2D>("finalResult");
            youWin = this.Content.Load<Texture2D>("You win");
            youLose = this.Content.Load<Texture2D>("comp win");
            plyr1Win = this.Content.Load<Texture2D>("player 1 win");
            plyr2Win = this.Content.Load<Texture2D>("player 2 win");
            backgroundmerah = this.Content.Load<Texture2D>("background malem merah");
            kembaliKeMenuAwal = this.Content.Load<Texture2D>("menu awal button");
            pauseMenu = this.Content.Load<Texture2D>("pause menu tali");
            resumeButton = this.Content.Load<Texture2D>("play button");
            restartButton = this.Content.Load<Texture2D>("Restart button");
            fontwinner = this.Content.Load<SpriteFont>("Menang");
            fontValue = this.Content.Load<SpriteFont>("value");
            kanvasUser = this.Content.Load<Texture2D>("KanvasUser");
            TanganPegangP1 = this.Content.Load<Texture2D>("tangan_megang_p1.");
            TanganLepasP1 = this.Content.Load<Texture2D>("tangan_lepas_p1.");
            TanganPegangP2 = this.Content.Load<Texture2D>("tangan_megang_p2.");
            TanganLepasP2 = this.Content.Load<Texture2D>("tangan_lepas_p2.");
            nitebackground = this.Content.Load<Texture2D>("nitebackground");
            daybackground = this.Content.Load<Texture2D>("congklak daylight 1");
            morningbackground = this.Content.Load<Texture2D>("congklak daylight 2");
            afternoonbackground = this.Content.Load<Texture2D>("congklak daylight 3");
            takeAPicture = this.Content.Load<Texture2D>("take a picture");
            compTurn1 = this.Content.Load<Texture2D>("compTurn");
            compTurn2 = this.Content.Load<Texture2D>("compTurn2");
            player1Turn = this.Content.Load<Texture2D>("player1Turn");
            player2Turn = this.Content.Load<Texture2D>("player2Turn");
            backgroundAwal = this.Content.Load<Texture2D>("menu awal2");
            splashScreen = this.Content.Load<Texture2D>("Splashscreen");
            splashScreenAds = this.Content.Load<Texture2D>("SplashscreenAds");
            exitButton = this.Content.Load<Texture2D>("exit button MENU AWAL");
            vsCompbttn = this.Content.Load<Texture2D>("vs com");
            vsPlayer2bttn = this.Content.Load<Texture2D>("vs player");
            helpbttn = this.Content.Load<Texture2D>("help button");
            exitbttn = this.Content.Load<Texture2D>("exit");
            vsCompbttn2 = this.Content.Load<Texture2D>("vscom2");
            vsPlayer2bttn2 = this.Content.Load<Texture2D>("vsplayer2");
            helpbttn2 = this.Content.Load<Texture2D>("help2");
            exitbttn2 = this.Content.Load<Texture2D>("exit2");
            helpPortrait = this.Content.Load<Texture2D>("help potrait");
            takepictbttn = this.Content.Load<Texture2D>("Takeapictbttn");
            takepictbttn2 = this.Content.Load<Texture2D>("Takeapictbttn2");
            browsebtn = this.Content.Load<Texture2D>("browse button");
            browsebtn2 = this.Content.Load<Texture2D>("browse hopper");
            gobtn = this.Content.Load<Texture2D>("go button");
            gobtn2 = this.Content.Load<Texture2D>("go hover");
            tanganPlayer = TanganPegangP1;
            compTurn = compTurn1;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {   
                gameindex--;
                if ((gameindex == 1) && (warnaPauseMenu != Color.Transparent))
                {
                    isi = 1;
                    posisiX = 0;
                    posisiY = 0;
                    retryTheGame();
                    bgawal = Color.White;
                    warnatakepict = Color.Transparent;
                    warnaplayerPict = Color.Transparent;
                    warnatakepictbttn = Color.Transparent;
                    warnatakepictbttn2 = Color.Transparent;
                    warnabrowsebtn = Color.Transparent;
                    warnabrowsebtn2 = Color.Transparent;
                    warnagobtn = Color.Transparent;
                    warnagobtn2 = Color.Transparent;
                    warnaPegang1 = Color.Transparent;
                    warnavsCompbttn = Color.White;
                    warnavsPlayer2bttn = Color.White;
                    warnaexitbttn = Color.White;
                    warnahelpbttn = Color.White;
                    warnavsCompbttn2 = Color.Transparent;
                    warnavsPlayer2bttn2 = Color.Transparent;
                    warnaexitbttn2 = Color.Transparent;
                    warnahelpbttn2 = Color.Transparent;
                    warnahelppage = Color.Transparent;
                    canMove = false;
                    helpIndex = 0;
                    helpY = 0;
                    pauseX = 0;
                    pauseY = 0;
                }
                else if ((gameindex == 1) && (warnaPauseMenu == Color.Transparent) && (helpIndex == 0))
                {
                    warnaPauseMenu = Color.White;
                    warnaResumebtn = Color.White;
                    warnaRestartbtn = Color.White;
                    warnaMenuAwalBtn = Color.White;
                    incPause = 1;
                }
                else if ((gameindex == 0) && (warnaPauseMenu == Color.Transparent))
                {
                    this.Exit();
                }
                else if((gameindex==0) && (warnaPauseMenu != Color.Transparent))
                {
                    gameindex = 1;
                    incPause = -1;
                    indexResume = 1;
                }
                else if ((gameindex == 1) && (helpIndex == 1))
                {
                    helpIndex = 0;
                    warnahelppage = Color.Transparent;
                    warnahelpbttn = Color.White;
                    warnahelpbttn2 = Color.Transparent;
                    warnaexitbttn = Color.White;
                    warnaexitbttn2 = Color.Transparent;
                    warnavsCompbttn = Color.White;
                    warnavsCompbttn2 = Color.Transparent;
                    warnavsPlayer2bttn = Color.White;
                    warnavsPlayer2bttn2 = Color.Transparent;
                    warnaShare = Color.White;
                    warnaShare1 = Color.Transparent;
                }
            }

            //Dapatkan waktu sekarang
            dateTime = DateTime.Now;
            if (dateTime != clockTime)                          
            {
                hour = dateTime.Hour;
                minute = dateTime.Minute;
                second = dateTime.Second;
            }

            //Sound effect waktu
            if ((bgawal == Color.Transparent) && (second % 10 == 0) && (canMove) && (MediaPlayer.State != MediaState.Playing))
            {
                if ((hour < 11) && (hour >= 6))
                {
                    MediaPlayer.Play(suaraPagi);
                }
                else if ((hour < 15) && (hour >= 11))
                {
                    MediaPlayer.Play(suaraSiang);
                }
                else if ((hour < 18) && (hour >= 15))
                {
                    MediaPlayer.Play(suaraSiang);
                }
                else if (((hour >= 18) && (hour <= 23)) || ((hour >= 0) && (hour < 6)))
                {
                    MediaPlayer.Play(suaraMalam);
                }
            }

            //Musik awal
            if ((bgawal != Color.Transparent) && (MediaPlayer.State != MediaState.Playing))
            {
                MediaPlayer.Play(musicAwalBackground);
            }
 
            //Sound pergantian waktu
            if (((hour == 6) && (minute == 0)) || ((hour == 11) && (minute == 0)) || ((hour == 15) && (minute == 0)) || ((hour == 18) && (minute == 0)))
            {
                pergantianJam.Play();
            }

            // TODO: Add your update logic here
            foreach (TouchLocation location in TouchPanel.GetState())
            {
                if ((location.State == TouchLocationState.Pressed) || (location.State == TouchLocationState.Moved))
                {
                    int X1 = (int)location.Position.X;
                    int Y1 = (int)location.Position.Y;

                    if ((isGameOver) && (incWin == 0))
                    {
                        if (exitFinalRec.Contains(X1, Y1))
                        {
                            warnaexitButtonFinal = Color.Transparent;
                            warnaexitButtonFinal2 = Color.White;
                        }
                        else if (retryFinalRec.Contains(X1, Y1))
                        {
                            warnaretryButtonFinal = Color.Transparent;
                            warnaretryButtonFinal2 = Color.White;
                        }
                        else
                        {
                            warnaretryButtonFinal = Color.White;
                            warnaretryButtonFinal2 = Color.Transparent;
                            warnaexitButtonFinal = Color.White;
                            warnaexitButtonFinal2 = Color.Transparent;
                        }
                    }

                    if (warnatakepict != Color.Transparent)
                    {
                        if (takephoto.Contains(X1, Y1))
                        {
                            warnatakepictbttn = Color.Transparent;
                            warnatakepictbttn2 = Color.White;
                        }
                        else if (browsephoto.Contains(X1, Y1))
                        {
                            warnabrowsebtn = Color.Transparent;
                            warnabrowsebtn2 = Color.White;
                        }
                        else if (goPlay.Contains(X1, Y1))
                        {
                            warnagobtn = Color.Transparent;
                            warnagobtn2 = Color.White;
                        }
                        else
                        {
                            warnatakepictbttn = Color.White;
                            warnatakepictbttn2 = Color.Transparent;
                            warnabrowsebtn = Color.White;
                            warnabrowsebtn2 = Color.Transparent;
                            warnagobtn = Color.White;
                            warnagobtn2 = Color.Transparent;
                        }
                    }

                    if ((bgawal != Color.Transparent) && (!canMove) && (warnahelppage == Color.Transparent))
                    {
                        if (vsCom.Contains(X1, Y1))
                        {
                            warnavsCompbttn = Color.Transparent;
                            warnavsCompbttn2 = Color.White;
                        }
                        else if (vsPlayer2.Contains(X1, Y1))
                        {
                            warnavsPlayer2bttn = Color.Transparent;
                            warnavsPlayer2bttn2 = Color.White;
                        }
                        else if (help.Contains(X1, Y1))
                        {
                            warnahelpbttn = Color.Transparent;
                            warnahelpbttn2 = Color.White;
                        }
                        else if (exit.Contains(X1, Y1))
                        {
                            warnaexitbttn = Color.Transparent;
                            warnaexitbttn2 = Color.White;
                        }
                        else if (shareRec.Contains(X1, Y1))
                        {
                            warnaShare1 = Color.White;
                            warnaShare = Color.Transparent;
                        }
                        else
                        {
                            warnavsCompbttn = Color.White;
                            warnavsPlayer2bttn = Color.White;
                            warnaexitbttn = Color.White;
                            warnahelpbttn = Color.White;
                            warnaShare = Color.White;
                            warnavsCompbttn2 = Color.Transparent;
                            warnavsPlayer2bttn2 = Color.Transparent;
                            warnaexitbttn2 = Color.Transparent;
                            warnahelpbttn2 = Color.Transparent;
                            warnaShare1 = Color.Transparent;
                        }
                    }
                    else if ((bgawal == Color.Transparent) && (canMove) && (warnahelppage == Color.Transparent))
                    {
                        if (vsComputerBtn.Contains(X1, Y1))
                        {
                            compTurn = compTurn2;
                        }
                        else
                        {
                            compTurn = compTurn1;
                        }
                    }
                    else if (warnahelppage != Color.Transparent)
                    {
                        pembandingHelp++;
                        if (pembandingHelp < 2)
                        {
                            gerakHelpY1 = (int)location.Position.Y;
                        }
                        else if (pembandingHelp > 2)
                        {
                            gerakHelpY2 = (int)location.Position.Y;
                        }

                        if (gerakHelpY1 < gerakHelpY2)
                        {
                            helpY = helpY + 2;
                        }
                        else if (gerakHelpY1 > gerakHelpY2)
                        {
                            helpY = helpY - 2;
                        }

                        if (pembandingHelp > 20)
                        {
                            pembandingHelp = 0;
                        }

                        if (helpY >= 0)
                        {
                            helpY = 0;
                        }

                        if (helpY <= -1120)
                        {
                            helpY = -1120;
                        }
                    }
                }

                if (location.State == TouchLocationState.Released)
                {
                    int X = (int)location.Position.X;
                    int Y = (int)location.Position.Y;

                    if ((isGameOver) && (incWin == 0))
                    {
                        if (exitFinalRec.Contains(X, Y))
                        {
                            gameindex++;
                            warnaexitButtonFinal = Color.White;
                            warnaexitButtonFinal2 = Color.Transparent;
                            canMove = false;
                            isi = 1;
                            posisiX = 0;
                            posisiY = 0;
                            retryTheGame();
                            bgawal = Color.White;
                            warnatakepict = Color.Transparent;
                            warnaplayerPict = Color.Transparent;
                            warnatakepictbttn = Color.Transparent;
                            warnatakepictbttn2 = Color.Transparent;
                            warnabrowsebtn = Color.Transparent;
                            warnabrowsebtn2 = Color.Transparent;
                            warnagobtn = Color.Transparent;
                            warnagobtn2 = Color.Transparent;
                            warnaPegang1 = Color.Transparent;
                            warnavsCompbttn = Color.White;
                            warnavsPlayer2bttn = Color.White;
                            warnaexitbttn = Color.White;
                            warnahelpbttn = Color.White;
                            warnaShare = Color.White;
                            warnaShare1 = Color.Transparent;
                            warnavsCompbttn2 = Color.Transparent;
                            warnavsPlayer2bttn2 = Color.Transparent;
                            warnaexitbttn2 = Color.Transparent;
                            warnahelpbttn2 = Color.Transparent;
                            warnahelppage = Color.Transparent;
                            helpY = 0;
                            helpIndex = 0;
                            winY = 0;
                            incWin = 0;
                        }
                        else if (retryFinalRec.Contains(X, Y))
                        {
                            warnaretryButtonFinal = Color.White;
                            warnaretryButtonFinal2 = Color.Transparent;
                            retryTheGame();
                            tampilMenu = false;
                            bgawal = Color.Transparent;
                            warnatakepict = Color.Transparent;
                            warnaPauseMenu = Color.Transparent;
                            warnaRestartbtn = Color.Transparent;
                            warnaResumebtn = Color.Transparent;
                            warnaMenuAwalBtn = Color.Transparent;
                            warnaPauseMenu = Color.Transparent;
                            warnaRestartbtn = Color.Transparent;
                            warnaResumebtn = Color.Transparent;
                            warnaMenuAwalBtn = Color.Transparent;
                            posisiX = 0;
                            posisiY = 0;
                            warnaPegang1 = Color.Transparent;
                            canMove = true;
                            incWin = 0;
                            winY = 0;
                            isGameOver = false;
                        }
                    }

                    if ((warnaPauseMenu != Color.Transparent) && (incPause == 0))
                    {
                        if (restartBtnRec.Contains(X, Y))
                        {
                            indexRestart = 1;
                            incPause = -1;
                            incWin = 0;
                        }
                        else if (kembaliKeMenuRec.Contains(X, Y))
                        {
                            indexKembaliKeMenu = 1;
                            incPause = -1;
                            incWin = 0;
                        }
                        else if (resumeBtnRec.Contains(X, Y))
                        {
                            indexResume = 1;
                            incPause = -1;
                        }
                    }

                    if (warnatakepict != Color.Transparent)
                    {
                        if (takephoto.Contains(X, Y))
                        {
                            warnatakepictbttn = Color.White;
                            warnatakepictbttn2 = Color.Transparent;
                            Microsoft.Phone.Tasks.CameraCaptureTask task = new Microsoft.Phone.Tasks.CameraCaptureTask();
                            task.Completed += new EventHandler<PhotoResult>(CameraTask_Completed);
                            task.Show();
                            warnaplayerPict = Color.White;
                            warnaplayerChar = Color.White;
                        }
                        else if (browsephoto.Contains(X, Y))
                        {
                            warnabrowsebtn = Color.White;
                            warnabrowsebtn2 = Color.Transparent;
                            PhotoChooserTask task = new PhotoChooserTask();
                            task.Completed += (s, evt) =>
                            {
                                if (evt.Error == null && evt.TaskResult == TaskResult.OK)
                                {
                                    playerPict = Texture2D.FromStream(this.GraphicsDevice, evt.ChosenPhoto);
                                    playerChar = playerPict;
                                    takeaPictureIndex = 1;
                                }
                            };

                            task.Show();

                            warnaplayerPict = Color.White;
                            warnaplayerChar = Color.White;
                        }
                        else if (goPlay.Contains(X, Y))
                        {
                            incWin = 1;
                            isGameOver = false;
                            tampilMenu = true;
                            warnagobtn2 = Color.Transparent;
                            warnatakepict = Color.Transparent;
                            warnaplayerPict = Color.Transparent;
                            warnatakepictbttn = Color.Transparent;
                            warnatakepictbttn2 = Color.Transparent;
                            warnabrowsebtn = Color.Transparent;
                            warnabrowsebtn2 = Color.Transparent;
                            warnagobtn = Color.Transparent;
                        }
                    }

                    if ((bgawal!=Color.Transparent) && (!canMove) && (warnahelppage==Color.Transparent) && (warnatakepict == Color.Transparent))
                    {
                        if (vsCom.Contains(X, Y))
                        {
                            if (takeaPictureIndex != 1)
                            {
                                warnatakepict = Color.White;
                                warnatakepictbttn = Color.White;
                                warnabrowsebtn = Color.White;
                                warnagobtn = Color.White;
                            }

                            if ((playerPict != null) || (playerChar != null))
                            {
                                tampilMenu = true;
                            }

                            vsCPU = true;
                            bgawal = Color.Transparent;
                            warnaShare = Color.Transparent;
                            warnaShare1 = Color.Transparent;
                            warnavsCompbttn = Color.Transparent;
                            warnavsPlayer2bttn = Color.Transparent;
                            warnaexitbttn = Color.Transparent;
                            warnavsCompbttn2 = Color.Transparent;
                            warnavsPlayer2bttn2 = Color.Transparent;
                            warnaexitbttn2 = Color.Transparent;
                            warnahelpbttn = Color.Transparent;
                            warnahelpbttn2 = Color.Transparent;
                            gameindex++;
                            canMove = true;
                        }
                        else if (vsPlayer2.Contains(X, Y))
                        {
                            if (takeaPictureIndex != 1)
                            {
                                warnatakepict = Color.White;
                                warnatakepictbttn = Color.White;
                                warnabrowsebtn = Color.White;
                                warnagobtn = Color.White;
                            }

                            if ((playerPict != null) || (playerChar != null))
                            {
                                tampilMenu = true;
                            }

                            vsCPU = false;
                            bgawal = Color.Transparent;
                            warnavsCompbttn = Color.Transparent;
                            warnavsPlayer2bttn = Color.Transparent;
                            warnaexitbttn = Color.Transparent;
                            warnavsCompbttn2 = Color.Transparent;
                            warnavsPlayer2bttn2 = Color.Transparent;
                            warnaexitbttn2 = Color.Transparent;
                            warnahelpbttn = Color.Transparent;
                            warnahelpbttn2 = Color.Transparent;
                            warnaShare = Color.Transparent;
                            warnaShare1 = Color.Transparent;
                            gameindex++;
                            canMove = true;
                        }
                        else if (help.Contains(X, Y))
                        {
                            helpIndex = 1;
                            warnahelppage = Color.White;
                            gameindex++;
                        }
                        else if (exit.Contains(X, Y))
                        {
                            this.Exit();
                        }
                        else if (shareRec.Contains(X, Y))
                        {
                            ShareLinkTask share = new ShareLinkTask();
                            share.Title = "Play Me Congklak";
                            share.LinkUri = new Uri("http://www.windowsphone.com/en-us/store/app/congklak/5c48cbd9-493a-4c34-a341-8eb508588c93", UriKind.Absolute);
                            share.Message = "Hey, I am using Play Me Congklak on my Windows Phone right now. Please download it. #MadeInIndonesia";
                            share.Show();
                        }
                    }
                    else if (warnahelppage != Color.Transparent)
                    {
                        pembandingHelp = 0;
                    }
                    else if ((isGameOver == false) && (warnaPauseMenu == Color.Transparent) && (bgawal == Color.Transparent) && (canMove) && (warnahelppage == Color.Transparent) && (warnatakepict == Color.Transparent))
                    {
                        if (lubang1.Contains(X, Y) && (lobang[1] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 1;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 591;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang2.Contains(X, Y) && (lobang[2] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 2;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 514;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang3.Contains(X, Y) && (lobang[3] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 3;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 437;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang4.Contains(X, Y) && (lobang[4] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 4;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 360;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang5.Contains(X, Y) && (lobang[5] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 5;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 283;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang6.Contains(X, Y) && (lobang[6] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 6;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 206;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang7.Contains(X, Y) && (lobang[7] != 0))
                        {
                            if (Turn == 1)
                            {
                                arahKiri = true;
                                tanganPlayer = TanganLepasP1;
                                warnaPegang1 = Color.Green;
                                posisi = 7;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 129;
                                posisiY = 256;
                                canMove = false;
                            }
                        }
                        else if (lubang9.Contains(X, Y) && (lobang[9] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 9;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 129;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang10.Contains(X, Y) && (lobang[10] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 10;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 206;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang11.Contains(X, Y) && (lobang[11] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 11;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 283;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang12.Contains(X, Y) && (lobang[12] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 12;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 360;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang13.Contains(X, Y) && (lobang[13] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 13;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 437;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang14.Contains(X, Y) && (lobang[14] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 14;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 514;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (lubang15.Contains(X, Y) && (lobang[15] != 0))
                        {
                            if (Turn == 2)
                            {
                                arahKiri = false;
                                tanganPlayer = TanganLepasP2;
                                warnaPegang1 = Color.PeachPuff;
                                posisi = 15;
                                isi = lobang[posisi];
                                lobang[posisi] = 0;
                                posisiX = 591;
                                posisiY = 155;
                                canMove = false;
                            }
                        }
                        else if (vsComputerBtn.Contains(X, Y))
                        {
                            if (Turn == 3)
                            {
                                compTurn = compTurn1;
                                MoveCPU();
                                if (PilihanCPU == 9)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 9;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 129;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 10)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 10;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 206;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 11)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 11;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 283;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 12)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 12;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 360;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 13)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 13;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 437;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 14)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 14;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 514;
                                    posisiY = 155;
                                    canMove = false;
                                }
                                else if (PilihanCPU == 15)
                                {
                                    arahKiri = false;
                                    tanganPlayer = TanganPegangP2;
                                    warnaPegang1 = Color.CornflowerBlue;
                                    posisi = 15;
                                    isi = lobang[posisi];
                                    lobang[posisi] = 0;
                                    posisiX = 591;
                                    posisiY = 155;
                                    canMove = false;
                                }
                            }
                        }
                    }
                }
            }
            if ((isi != 0) && (posisi != 17) && pauseButton)
            {
                if ((arahKiri) && (posisiX >= 129) && (posisiX <= 592))
                { 
                    posisiX--;
                    if ((posisiX == 571) || (posisiX == 494) || (posisiX == 417) || (posisiX == 340) || (posisiX == 263) || (posisiX == 186))
                    {
                        ChangeToPegang(Turn);
                    }

                    if (posisiX == 591)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 514)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 437)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 360)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 283)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 206)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 129)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX--;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                }
                if ((arahKiri) && (posisiX <= 128) && (posisiX >= 69))
                {
                    if (posisiX == 109)
                    {
                        ChangeToPegang(Turn);
                    }

                    posisiX--;
                    posisiY--;
                    if (posisiX == 69)
                    {
                        if (Turn == 1)
                        {
                            posisi++;
                            lobang[posisi]++;
                            posisiX++;
                            isi--;
                            tikSound.Play();
                            arahKiri = false;
                            posisiY = 197;
                            ChangeToLepas(Turn);
                        }
                        else if ((Turn == 2) || (Turn == 3))
                        {
                            posisi++;
                            posisiX++;
                            arahKiri = false;
                            posisiY = 213;
                        }
                    }
                }
                if ((!arahKiri) && (posisiX <= 127) && (posisiX >= 70))
                {
                    if (posisiX == 89)
                    {
                        ChangeToPegang(Turn);
                    }

                    posisiX++;
                    posisiY--;
                }
                if ((!arahKiri) && (posisiX >= 128) && (posisiX <= 591))
                {
                    posisiX++;
                    if ((posisiX == 534) || (posisiX == 457) || (posisiX == 380) || (posisiX == 303) || (posisiX == 226) || (posisiX == 149))
                    {
                        ChangeToPegang(Turn);
                    }

                    if (posisiX == 129)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 206)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 283)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 360)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 437)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 514)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                    if (posisiX == 591)
                    {
                        posisi++;
                        lobang[posisi]++;
                        posisiX++;
                        isi--;
                        tikSound.Play();
                        ChangeToLepas(Turn);
                    }
                }
                if ((!arahKiri) && (posisiX >= 592) && (posisiX <= 650))
                {
                    if (posisiX == 611)
                    {
                        ChangeToPegang(Turn);
                    }

                    posisiX++;
                    posisiY++;
                    if (posisiX == 650)
                    {
                        if ((Turn == 2) || (Turn == 3))
                        {
                            posisi++;
                            lobang[posisi]++;
                            isi--;
                            tikSound.Play();
                            posisiX--;
                            arahKiri = true;
                            posisiY = 213;
                            ChangeToLepas(Turn);
                        }
                        else if (Turn == 1)
                        {
                            posisi++;
                            posisiX--;
                            arahKiri = true;
                            posisiY = 197;
                        }
                    }
                }
                if ((arahKiri) && (posisiX <= 649) && (posisiX >= 593))
                {
                    if (posisiX == 630)
                    {
                        ChangeToPegang(Turn);
                    }

                    posisiX--;
                    posisiY++;
                    if (posisiX == 592)
                    {
                        posisi = 0;
                    }
                }
            }
            else if ((isi==0) && (posisi != 17) && pauseButton)
            {
                if (Turn == 1)
                {
                    if (posisi != 8)
                    {
                        if (lobang[posisi] != 1)
                        {
                            isi = lobang[posisi];
                            lobang[posisi] = 0;
                            MainLagi = 1;
                            RotateTurn();
                        }
                        else if (lobang[posisi] == 1)
                        {
                            setTembakLubang(posisi, 1);
                            warnaPegang1 = Color.Transparent;
                            warnaPegang2 = Color.Transparent;
                            MainLagi = 0;
                            RotateTurn();
                            posisi = 17;
                            isGameOver = ApakahGameBerakhir();
                            canMove = true;
                        }
                    }
                    else
                    {
                        warnaPegang1 = Color.Transparent;
                        warnaPegang2 = Color.Transparent;
                        MainLagi = 1;
                        RotateTurn();
                        isGameOver = ApakahGameBerakhir();
                        canMove = true;
                    }
                }
                else if ((Turn == 2) || (Turn == 3))
                {
                    if (posisi != 16)
                    {
                        if (lobang[posisi] != 1)
                        {
                            isi = lobang[posisi];
                            lobang[posisi] = 0;
                            MainLagi = 1;
                            RotateTurn();
                        }
                        else if (lobang[posisi] == 1)
                        {
                            setTembakLubang(posisi, 2);
                            warnaPegang1 = Color.Transparent;
                            warnaPegang2 = Color.Transparent;
                            MainLagi = 0;
                            RotateTurn();
                            posisi = 17;
                            isGameOver = ApakahGameBerakhir();
                            canMove = true;
                        }
                    }
                    else
                    {
                        warnaPegang1 = Color.Transparent;
                        warnaPegang2 = Color.Transparent;
                        MainLagi = 1;
                        RotateTurn();
                        isGameOver = ApakahGameBerakhir();
                        canMove = true;
                    }
                }
            }

            movingTurtle();
            LedakEfek();
            pauseEvent();
            winEvent();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>

        protected void RotateTurn()
        {
            Turn++;
            
            if (vsCPU == true)
            {
                if ((Turn == 2)&&(MainLagi!=1))
                {
                    Turn = 3;
                }
                else if((Turn == 4)&&(MainLagi!=1))
                {
                    Turn=1;
                }
                else if ((Turn==2)&&(MainLagi == 1))
                {
                    Turn = 1;
                }
                else if ((Turn == 4) && (MainLagi == 1))
                {
                    Turn = 3;
                }
                else { }

            }
            else
            {
                if ((Turn == 3) && (MainLagi!=1))
                {
                    Turn = 1;
                }
                else if ((Turn == 2) && (MainLagi == 1))
                {
                    Turn = 1;
                }
                else if ((Turn==3) && (MainLagi == 1))
                {
                    Turn = 2;
                }
            }
        }

        Color bgawal = new Color();

        protected override void Draw(GameTime gameTime)
        {
            Vector2 vektorP1 = new Vector2(posisiX, posisiY);
            Vector2 vektorP2 = new Vector2(posisiX, posisiY);

            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();

            // Background
            if ((hour < 11) && (hour >= 6))
            {
                spriteBatch.Draw(morningbackground, new Rectangle(bgX, bgY, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            }
            else if ((hour < 15) && (hour >= 11))
            {
                spriteBatch.Draw(daybackground, new Rectangle(bgX, bgY, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            }
            else if ((hour < 18) && (hour >= 15))
            {
                spriteBatch.Draw(afternoonbackground, new Rectangle(bgX, bgY, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            }
            else if (((hour >= 18) && (hour <= 23)) || ((hour >= 0) && (hour < 6)))
            {
                spriteBatch.Draw(nitebackground, new Rectangle(bgX, bgY, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            }

            if (!backgroundIndex)
            {
                spriteBatch.Draw(backgroundmerah, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            }

            if (lobang[1] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[1].ToString()), new Rectangle(595 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[1].ToString(), new Vector2(601 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[2] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[2].ToString()), new Rectangle(518 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[2].ToString(), new Vector2(524 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[3] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[3].ToString()), new Rectangle(441 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[3].ToString(), new Vector2(447 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[4] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[4].ToString()), new Rectangle(364 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[4].ToString(), new Vector2(370 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[5] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[5].ToString()), new Rectangle(287 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[5].ToString(), new Vector2(293 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[6] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[6].ToString()), new Rectangle(210 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[6].ToString(), new Vector2(216 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[7] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[7].ToString()), new Rectangle(133 + bijiX, 260 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[7].ToString(), new Vector2(139 + bijiX, 263 + bijiY), Color.White);
            }

            if (lobang[8] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[8].ToString()), new Rectangle(46 + bijiX, 200 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[8].ToString(), new Vector2(57 + bijiX, 208 + bijiY), Color.White);
            }

            if (lobang[9] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[9].ToString()), new Rectangle(133 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[9].ToString(), new Vector2(139 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[10] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[10].ToString()), new Rectangle(210 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[10].ToString(), new Vector2(216 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[11] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[11].ToString()), new Rectangle(287 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[11].ToString(), new Vector2(293 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[12] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[12].ToString()), new Rectangle(364 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[12].ToString(), new Vector2(370 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[13] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[13].ToString()), new Rectangle(441 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[13].ToString(), new Vector2(447 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[14] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[14].ToString()), new Rectangle(518 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[14].ToString(), new Vector2(524 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[15] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[15].ToString()), new Rectangle(595 + bijiX, 147 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[15].ToString(), new Vector2(601 + bijiX, 150 + bijiY), Color.White);
            }

            if (lobang[16] <= 16)
            {
                spriteBatch.Draw(this.Content.Load<Texture2D>(lobang[16].ToString()), new Rectangle(678 + bijiX, 200 + bijiY, 70, 70), Color.White);
            }
            else
            {
                spriteBatch.DrawString(fontValue, lobang[16].ToString(), new Vector2(689 + bijiX, 208 + bijiY), Color.White);
            }

            if ((isGameOver == false) && (canMove))
            {
                if (Turn == 1)
                {
                    spriteBatch.Draw(player1Turn, new Rectangle(120, 375, 100, 200), Color.White);
                    spriteBatch.Draw(player2Turn, new Rectangle(480, 5, 100, 200), Color.Transparent);
                    spriteBatch.Draw(compTurn, new Rectangle(480, 5, 100, 200), Color.Transparent);
                }
                else if (Turn == 2)
                {
                    spriteBatch.Draw(player1Turn, new Rectangle(120, 375, 100, 200), Color.Transparent);
                    spriteBatch.Draw(player2Turn, new Rectangle(480, 5, 100, 200), Color.White);
                }
                else if (Turn == 3)
                {
                    spriteBatch.Draw(player1Turn, new Rectangle(120, 375, 100, 200), Color.Transparent);
                    spriteBatch.Draw(compTurn, new Rectangle(480, 5, 100, 200), Color.White);
                }
            }
            else if (isGameOver)
            {
                spriteBatch.Draw(player1Turn, new Rectangle(450, 355, 60, 250), Color.Transparent);
                spriteBatch.Draw(player2Turn, new Rectangle(100, 65, 60, 250), Color.Transparent);
                spriteBatch.Draw(compTurn, new Rectangle(100, 50, 60, 250), Color.Transparent);
            }

            spriteBatch.Draw(tanganPlayer, vektorP1, warnaPegang1);

            spriteBatch.Draw(kanvasUser, new Rectangle(695, 5, 100, 100), warnaKanvasUser);
            spriteBatch.Draw(kanvasUser, new Rectangle(5, 375, 100, 100), warnaKanvasUser);

            if (playerPict != null)
            {
                spriteBatch.Draw(playerChar, new Rectangle(10, 380, 90, 90), warnaplayerChar);
            }

            if (waitForSplashscreen < 3)
            {
                spriteBatch.Draw(splashScreen, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), bgawal);
                waitForSplashscreen += (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (waitForSplashscreen > 2 && waitForSplashscreen < 5)
            {
                spriteBatch.Draw(splashScreenAds, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), bgawal);
                waitForSplashscreen += (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else
            {
                spriteBatch.Draw(backgroundAwal, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), bgawal);
                spriteBatch.Draw(vsCompbttn, vsCom, warnavsCompbttn);
                spriteBatch.Draw(vsPlayer2bttn, vsPlayer2, warnavsPlayer2bttn);
                spriteBatch.Draw(exitbttn, exit, warnaexitbttn);
                spriteBatch.Draw(helpbttn, help, warnahelpbttn);
                spriteBatch.Draw(vsCompbttn2, vsCom, warnavsCompbttn2);
                spriteBatch.Draw(vsPlayer2bttn2, vsPlayer2, warnavsPlayer2bttn2);
                spriteBatch.Draw(exitbttn2, exit, warnaexitbttn2);
                spriteBatch.Draw(helpbttn2, help, warnahelpbttn2);
                spriteBatch.Draw(share, shareRec, warnaShare);
                spriteBatch.Draw(share1, shareRec, warnaShare1);
            }

            if (bgawal != Color.Transparent && waitForSplashscreen > 5)
            {
                spriteBatch.Draw(kurakura, new Rectangle(640 + kurakuraX, 330 + kurakuraY, 90, 90), Color.White);
            }


            if (helpIndex == 1)
            {
                spriteBatch.Draw(helpPortrait, new Rectangle(helpX, helpY, 1600, 800), warnahelppage);
            }

            if (warnatakepict != Color.Transparent)
            {
                spriteBatch.Draw(takeAPicture, new Rectangle(0, 0, 480, 800), warnatakepict);
                spriteBatch.Draw(takepictbttn, takephoto, warnatakepictbttn);
                spriteBatch.Draw(takepictbttn2, takephoto, warnatakepictbttn2);
                spriteBatch.Draw(browsebtn, browsephoto, warnabrowsebtn);
                spriteBatch.Draw(browsebtn2, browsephoto, warnabrowsebtn2);
                spriteBatch.Draw(gobtn, goPlay, warnagobtn);
                spriteBatch.Draw(gobtn2, goPlay, warnagobtn2);
            }

            if (playerPict != null)
            {
                spriteBatch.Draw(playerPict, new Rectangle(324, 175, 152, 158), warnaplayerPict);
            }

            if (isGameOver)
            {
                if ((lobang[16] < lobang[8]) && (vsCPU == true))
                {
                    spriteBatch.Draw(finalResult, new Rectangle(0, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(youWin, new Rectangle(40, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(retryButtonFinal, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal);
                    spriteBatch.Draw(retryButtonFinal2, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal2);
                    spriteBatch.Draw(exitButtonFinal, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal);
                    spriteBatch.Draw(exitButtonFinal2, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal2);
                }
                if ((lobang[16] > lobang[8]) && (vsCPU == true))
                {
                    spriteBatch.Draw(finalResult, new Rectangle(0, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(youLose, new Rectangle(16, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(retryButtonFinal, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal);
                    spriteBatch.Draw(retryButtonFinal2, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal2);
                    spriteBatch.Draw(exitButtonFinal, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal);
                    spriteBatch.Draw(exitButtonFinal2, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal2);
                }
                if ((lobang[8] < lobang[16]) && (vsCPU == false))
                {
                    spriteBatch.Draw(finalResult, new Rectangle(0, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(plyr2Win, new Rectangle(2, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(retryButtonFinal, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal);
                    spriteBatch.Draw(retryButtonFinal2, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal2);
                    spriteBatch.Draw(exitButtonFinal, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal);
                    spriteBatch.Draw(exitButtonFinal2, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal2);
                }
                if ((lobang[8] > lobang[16]) && (vsCPU == false))
                {
                    spriteBatch.Draw(finalResult, new Rectangle(0, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(plyr1Win, new Rectangle(2, -376 + winY, 480, 800), Color.White);
                    spriteBatch.Draw(retryButtonFinal, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal);
                    spriteBatch.Draw(retryButtonFinal2, new Rectangle(288, -6 + winY, 70, 130), warnaretryButtonFinal2);
                    spriteBatch.Draw(exitButtonFinal, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal);
                    spriteBatch.Draw(exitButtonFinal2, new Rectangle(423, -6 + winY, 70, 130), warnaexitButtonFinal2);
                }

                //Tampilan high score
                spriteBatch.Draw(kanvasUser, new Rectangle(345, -206 + winY, 55, 55), Color.White);
                spriteBatch.Draw(kanvasUser, new Rectangle(345, -144 + winY, 55, 55), Color.White);
                spriteBatch.Draw(kanvasUser, new Rectangle(345, -82 + winY, 55, 55), Color.White);
                spriteBatch.DrawString(fontwinner, lobang[8].ToString(), new Vector2(455, -206 + winY), Color.White);
                spriteBatch.DrawString(fontwinner, "40", new Vector2(455, -144 + winY), Color.White);
                spriteBatch.DrawString(fontwinner, "30", new Vector2(455, -82 + winY), Color.White);

                if (playerPict != null)
                {
                    spriteBatch.Draw(playerPict, new Rectangle(346, -205 + winY, 53, 53), Color.White);
                }
            }

            //Tampilan pause menu
            spriteBatch.Draw(pauseMenu, new Rectangle(0 + pauseX, -376 + pauseY, 480, 800), warnaPauseMenu);
            spriteBatch.Draw(resumeButton, new Rectangle(366 + pauseX, -242 + pauseY, 110, 110), warnaResumebtn);
            spriteBatch.Draw(kembaliKeMenuAwal, new Rectangle(304 + pauseX, -146 + pauseY, 110, 110), warnaMenuAwalBtn);
            spriteBatch.Draw(restartButton, new Rectangle(430 + pauseX, -146 + pauseY, 110, 110), warnaRestartbtn);

            if (isGameOver!=true)
            {
                spriteBatch.Draw(exitButton, exit, Color.Transparent);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }


        private int[] lobang = new int[17]; //isi nilai lubang
        static int MainLagi;
        private int Berakhir = 0;
        public int PilihanCPU;

        //Mendefinisikan kondis awal permainan
        public void KondisiAwal()
        {
            for (int i = 1; i < 17; i++)
            {
                if (i != 8 && i != 16)
                {
                    lobang[i] = 7;
                    tempLobang[i] = 7;
                }
                else
                {
                    lobang[i] = 0;
                }
            }
            posisi = 17;
        }

        public void setTembakLubang(int _posisi, int _pemain)
        {
            if (_pemain == 1)
            {
                if ((_posisi == 1) && (lobang[_posisi + 14] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 14]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 14] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 2) && (lobang[_posisi + 12] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 12]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 12] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 3) && (lobang[_posisi + 10] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 10]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 10] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 4) && (lobang[_posisi + 8] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 8]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 8] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 5) && (lobang[_posisi + 6] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 6]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 6] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 6) && (lobang[_posisi + 4] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 4]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 4] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 7) && (lobang[_posisi + 2] != 0))
                {
                    lobang[8] += (lobang[_posisi] + lobang[_posisi + 2]);
                    lobang[_posisi] = 0;
                    lobang[_posisi + 2] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
            }
            else
            {
                if ((_posisi == 9) && (lobang[_posisi - 2] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 2]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 2] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 10) && (lobang[_posisi - 4] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 4]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 4] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 11) && (lobang[_posisi - 6] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 6]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 6] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 12) && (lobang[_posisi - 8] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 8]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 8] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 13) && (lobang[_posisi - 10] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 10]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 10] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 14) && (lobang[_posisi - 12] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 12]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 12] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
                else if ((_posisi == 15) && (lobang[_posisi - 14] != 0))
                {
                    lobang[16] += (lobang[_posisi] + lobang[_posisi - 14]);
                    lobang[_posisi] = 0;
                    lobang[_posisi - 14] = 0;
                    incEfek = 1;
                    vibrate.Start(TimeSpan.FromSeconds(1.2));
                    soundBombs.Play();
                }
            }
        }

        public Boolean ApakahGameBerakhir()
        {
            if ((lobang[1] == 0) && (lobang[2] == 0) && (lobang[3] == 0) && (lobang[4] == 0) &&
                (lobang[5] == 0) && (lobang[6] == 0) && (lobang[7] == 0))
            {
                Berakhir = 1;
            }
            else if ((lobang[9] == 0) && (lobang[10] == 0) && (lobang[11] == 0) && (lobang[12] == 0) &&
                (lobang[13] == 0) && (lobang[14] == 0) && (lobang[15] == 0))
            {
                Berakhir = 1;
            }

            if (Berakhir == 1)
            {
                incWin = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Proses Berpikir AI1
        public void MoveCPU()
        {
            //Pilihan untuk bermain lagi
            if ((lobang[15] == 1) || (lobang[15] == 16))
            {
                PilihanCPU = 15;
            }
            else if ((lobang[14] == 2) || (lobang[14] == 17))
            {
                PilihanCPU = 14;
            }
            else if ((lobang[13] == 3) || (lobang[13] == 18))
            {
                PilihanCPU = 13;
            }
            else if ((lobang[13] < 3) && ((13 + lobang[13]) + (lobang[13 + lobang[13]]) + 1 == 16) && (lobang[13] != 0))
            {
                PilihanCPU = 13;
            }
            else if ((lobang[12] == 4) || (lobang[12] == 19))
            {
                PilihanCPU = 12;
            }
            else if ((lobang[12] < 4) && ((12 + lobang[12]) + (lobang[12 + lobang[12]]) + 1 == 16) && (lobang[12] != 0))
            {
                PilihanCPU = 12;
            }
            else if ((lobang[11] == 5) || (lobang[11] == 20))
            {
                PilihanCPU = 11;
            }
            else if ((lobang[11] < 5) && ((11 + lobang[11]) + (lobang[11 + lobang[11]]) + 1 == 16) && (lobang[11] != 0))
            {
                PilihanCPU = 11;
            }
            else if ((lobang[10] == 6) || (lobang[10] == 21))
            {
                PilihanCPU = 10;
            }
            else if ((lobang[10] < 6) && ((10 + lobang[10]) + (lobang[10 + lobang[10]]) + 1 == 16) && (lobang[10] != 0))
            {
                PilihanCPU = 10;
            }
            else if ((lobang[9] == 7) || (lobang[9] == 22))
            {
                PilihanCPU = 9;
            }
            else if ((lobang[9] < 7) && ((9 + lobang[9]) + (lobang[9 + lobang[9]]) + 1 == 16) && (lobang[9] != 0))
            {
                PilihanCPU = 9;
            }
            // Tembak
            else if((lobang[9] == 15) && (lobang[7] != 0))
            {
                PilihanCPU = 9;
            }
            else if ((lobang[10] == 15) && (lobang[6] != 0))
            {
                PilihanCPU = 10;
            }
            else if ((lobang[11] == 15) && (lobang[5] != 0))
            {
                PilihanCPU = 11;
            }
            else if ((lobang[12] == 15) && (lobang[4] != 0))
            {
                PilihanCPU = 12;
            }
            else if ((lobang[13] == 15) && (lobang[3] != 0))
            {
                PilihanCPU = 13;
            }
            else if ((lobang[14] == 15) && (lobang[2] != 0))
            {
                PilihanCPU = 14;
            }
            else if ((lobang[15] == 15) && (lobang[1] != 0))
            {
                PilihanCPU = 15;
            }
            else if ((9 + lobang[9] <= 15) && (lobang[(9 + lobang[9])] == 0) && (lobang[9] != 0) && (lobang[16 - (9 + lobang[9])] != 0))
            {
                PilihanCPU = 9;
            }
            else if ((10 + lobang[10] <= 15) && (lobang[(10 + lobang[10])] == 0) && (lobang[10] != 0) && (lobang[6] != 0) && (lobang[16 - (10 + lobang[10])] != 0))
            {
                PilihanCPU = 10;
            }
            else if ((11 + lobang[11] <= 15) && (lobang[(11 + lobang[11])] == 0) && (lobang[11] != 0) && (lobang[5] != 0) && (lobang[16 - (11 + lobang[11])] != 0))
            {
                PilihanCPU = 11;
            }
            else if ((12 + lobang[12] <= 15) && (lobang[(12 + lobang[12])] == 0) && (lobang[12] != 0) && (lobang[4] != 0) && (lobang[16 - (12 + lobang[12])] != 0))
            {
                PilihanCPU = 12;
            }
            else if ((13 + lobang[13] <= 15) && (lobang[(13 + lobang[13])] == 0) && (lobang[13] != 0) && (lobang[3] != 0) && (lobang[16 - (13 + lobang[13])] != 0))
            {
                PilihanCPU = 13;
            }
            else if ((14 + lobang[14] <= 15) && (lobang[(14 + lobang[14])] == 0) && (lobang[14] != 0) && (lobang[2] != 0) && (lobang[16 - (14 + lobang[14])] != 0))
            {
                PilihanCPU = 14;
            }
            // Bertahan agar ga di tembak
            else if ((lobang[9] >= 5) && ((lobang[7] == 0) || (lobang[7] == 1)))
            {
                PilihanCPU = 9;
            }
            else if ((lobang[10] >= 5) && ((lobang[6] == 0) || (lobang[6] == 2)))
            {
                PilihanCPU = 10;
            }
            else if ((lobang[11] >= 5) && ((lobang[5] == 0) || (lobang[5] == 3)))
            {
                PilihanCPU = 11;
            }
            else if ((lobang[12] >= 5) && ((lobang[4] == 0) || (lobang[4] == 4)))
            {
                PilihanCPU = 12;
            }
            else if ((lobang[13] >= 5) && (lobang[3] == 0))
            {
                PilihanCPU = 13;
            }
            else if ((lobang[14] >= 5) && (lobang[2] == 0))
            {
                PilihanCPU = 14;
            }
            else if ((lobang[15] >= 5) && (lobang[1] == 0))
            {
                PilihanCPU = 15;
            }
            else
            {
                PilihanCPU = nilaiRandom();
            }
        }

        //Proses pemilihan keputusan AI1 untuk memilih lubang dengan biji terbesar
        public int nilaiTerbesar()
        {
            int terbesar = lobang[9];
            int pilih = 9;
            for (int a = 10; a <= 15; a++)
            {
                if (terbesar < lobang[a])
                {
                    terbesar = lobang[a];
                    pilih = a;
                }
            }
            return pilih;
        }

        //Proses pemilihan keputusan AI untuk memilih lubang secara acak
        public int nilaiRandom()
        {
            Random rand = new Random();
            int randVal = rand.Next(9, 15);

            while (lobang[randVal] == 0)
            {
                randVal = rand.Next(9, 15);
            }
            return randVal;
        }

        public void retryTheGame()
        {
            MainLagi = 0;
            KondisiAwal();
            isGameOver = false;
            Turn=1;
            Berakhir = 0;
        }

        public void backToMainMenu()
        {
            Initialize();
            isGameOver = false;
            Turn = 1;
        }

        public void ChangeToLepas(int _Turn)
        {
            if (_Turn == 1)
            {
                tanganPlayer = TanganLepasP1;
                warnaPegang1 = Color.Green;
            }
            else if (_Turn == 2)
            {
                tanganPlayer = TanganLepasP2;
                warnaPegang1 = Color.PeachPuff;
            }
            else if(_Turn == 3)
            {
                tanganPlayer = TanganLepasP2;
                warnaPegang1 = Color.CornflowerBlue;
            }
        }

        public void ChangeToPegang(int _Turn)
        {
            if (_Turn == 1)
            {
                tanganPlayer = TanganPegangP1;
                warnaPegang1 = Color.Green;
            }
            else if (_Turn == 2)
            {
                tanganPlayer = TanganPegangP2;
                warnaPegang1 = Color.PeachPuff;
            }
            else if (_Turn == 3)
            {
                tanganPlayer = TanganPegangP2;
                warnaPegang1 = Color.CornflowerBlue;
            }
        }


        public void CameraTask_Completed(object sender, PhotoResult pr)
        {
            if (pr.TaskResult == TaskResult.OK)
            {
                MediaLibrary medialibrary = new MediaLibrary();
                medialibrary.SavePicture("Congklak Captured", pr.ChosenPhoto);
                playerPict = Texture2D.FromStream(this.GraphicsDevice, pr.ChosenPhoto);
                playerChar = playerPict;
                takeaPictureIndex = 1;
            }
        }

        public void LedakEfek()
        {
            if (incEfek >= 1)
            {
                incEfek++;
                if ((incEfek == 20) || (incEfek == 60) || (incEfek == 100) || (incEfek == 140) || (incEfek == 180))
                {
                    backgroundIndex = false;
                }
                else if ((incEfek == 40) || (incEfek == 80) || (incEfek == 120) || (incEfek == 160) || (incEfek == 200))
                {
                    backgroundIndex = true;
                }

                if ((incEfek == 5) || (incEfek == 15) || (incEfek == 25) || (incEfek == 35) || (incEfek == 45) || (incEfek == 55)
                    || (incEfek == 65) || (incEfek == 75) || (incEfek == 85) || (incEfek == 95) || (incEfek == 105) || (incEfek == 115)
                    || (incEfek == 125) || (incEfek == 135) || (incEfek == 145) || (incEfek == 155) || (incEfek == 165) || (incEfek == 175)
                    || (incEfek == 185) || (incEfek == 195))
                {
                    bgY = 0;
                    bijiY = 5;
                }
                else if ((incEfek == 10) || (incEfek == 20) || (incEfek == 30) || (incEfek == 40) || (incEfek == 50) || (incEfek == 60)
                    || (incEfek == 70) || (incEfek == 80) || (incEfek == 90) || (incEfek == 100) || (incEfek == 110) || (incEfek == 120)
                    || (incEfek == 130) || (incEfek == 140) || (incEfek == 150) || (incEfek == 160) || (incEfek == 170) || (incEfek == 180)
                    || (incEfek == 190) || (incEfek == 200))
                {
                    bgY = -10;
                    bijiY = -5;
                }

                if (incEfek >= 201)
                {
                    incEfek = 0;
                    bgY = -5;
                    bijiY = 0;
                }
            }
        }

        public void winEvent()
        {
            if ((isGameOver) && (incWin != 0))
            {
                incWin++;
                winY = winY + 1;

                if (incWin >= 376)
                {
                    incWin = 0;
                }
            }
        }

        public void movingTurtle()
        {
            if (bgawal != Color.Transparent)
            {
                if (kurakuraindex == 1)
                {
                    inckurakura++;
                    if (inckurakura % 10 == 0)
                    {
                        kurakuraX = kurakuraX + 1;
                        kurakuraY = kurakuraY + 1;
                        if (kurakuraX == 15)
                        {
                            kurakuraindex = 0;
                            inckurakura = 0;
                        }
                    }
                }

                if (kurakuraindex == 0)
                {
                    inckurakura++;
                    if (inckurakura % 10 == 0)
                    {
                        kurakuraX = kurakuraX - 1;
                        kurakuraY = kurakuraY - 1;
                        if (kurakuraX == -15)
                        {
                            kurakuraindex = 1;
                            inckurakura = 0;
                        }
                    }
                }
            }
        }

        public void pauseEvent()
        {

            if (incPause >= 1)
            {
                pauseButton = false;
                incPause++;
                pauseY = pauseY + 1;

                if (incPause >= 376)
                {
                    incPause = 0;
                }
            }

            if ((incPause <= -1) && (indexRestart == 1))
            {
                incPause--;
                pauseY = pauseY - 1;

                if (incPause <= -376)
                {
                    gameindex++;
                    incPause = 0;
                    pauseY = 0;
                    retryTheGame();
                    tampilMenu = false;
                    warnaPauseMenu = Color.Transparent;
                    warnaRestartbtn = Color.Transparent;
                    warnaResumebtn = Color.Transparent;
                    warnaMenuAwalBtn = Color.Transparent;
                    warnaPauseMenu = Color.Transparent;
                    warnaRestartbtn = Color.Transparent;
                    warnaResumebtn = Color.Transparent;
                    warnaMenuAwalBtn = Color.Transparent;
                    indexRestart = 0;
                    posisiX = 0;
                    posisiY = 0;
                    warnaPegang1 = Color.Transparent;
                    canMove = true;
                    incWin = 0;
                    winY = 0;
                    isGameOver = false;
                }
            }

            if ((incPause <= -1) && (indexResume == 1))
            {
                incPause--;
                pauseY = pauseY - 1;

                if (incPause <= -376)
                {
                    incPause = 0;
                    pauseY = 0;
                    gameindex++;
                    tampilMenu = false;
                    warnaPauseMenu = Color.Transparent;
                    warnaResumebtn = Color.Transparent;
                    warnaRestartbtn = Color.Transparent;
                    warnaMenuAwalBtn = Color.Transparent;
                    indexResume = 0;
                    pauseButton = true;
                }
            }

            if ((incPause <= -1) && (indexKembaliKeMenu == 1))
            {
                incPause--;
                pauseY = pauseY - 1;

                if (incPause <= -376)
                {
                    indexKembaliKeMenu = 0;
                    incPause = 0;
                    pauseY = 0;
                    tampilMenu = false;
                    canMove = false;
                    warnaPauseMenu = Color.Transparent;
                    warnaRestartbtn = Color.Transparent;
                    warnaResumebtn = Color.Transparent;
                    warnaMenuAwalBtn = Color.Transparent;
                    isi = 1;
                    posisiX = 0;
                    posisiY = 0;
                    retryTheGame();
                    bgawal = Color.White;
                    warnatakepict = Color.Transparent;
                    warnaplayerPict = Color.Transparent;
                    warnatakepictbttn = Color.Transparent;
                    warnatakepictbttn2 = Color.Transparent;
                    warnabrowsebtn = Color.Transparent;
                    warnabrowsebtn2 = Color.Transparent;
                    warnagobtn = Color.Transparent;
                    warnagobtn2 = Color.Transparent;
                    warnaPegang1 = Color.Transparent;
                    warnavsCompbttn = Color.White;
                    warnaShare = Color.White;
                    warnavsPlayer2bttn = Color.White;
                    warnaexitbttn = Color.White;
                    warnahelpbttn = Color.White;
                    warnavsCompbttn2 = Color.Transparent;
                    warnavsPlayer2bttn2 = Color.Transparent;
                    warnaexitbttn2 = Color.Transparent;
                    warnahelpbttn2 = Color.Transparent;
                    warnahelppage = Color.Transparent;
                    helpY = 0;
                    helpIndex = 0;
                    winY = 0;
                }
            }
        }
    }
}
