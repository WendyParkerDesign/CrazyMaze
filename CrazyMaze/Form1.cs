using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyMaze
{
    public partial class Form1 : Form
    {

        // This creates a Sound Player to create the sound when the player touch a wall.
        // System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\doh1.wav");

        // This creates a Sound Player to create the sound when the player touch a Dark Violet wall.
        System.Media.SoundPlayer wallDarkVioletSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\doh1.wav");

        // This creates a Sound Player to create the sound when the player touch a Blue wall.
        System.Media.SoundPlayer wallBlueSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\sad_trombone.wav");

        // This creates a Sound Player to create the sound when the player touch a Firebrick (red) wall.
        System.Media.SoundPlayer wallFirebrickSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\scream.wav");

        // This creates a Sound Player to create the sound when the player touch a Gold wall.
        System.Media.SoundPlayer wallGoldSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\aallrighty.wav");

        // This creates a Sound Player to create the sound when the player touch a Green wall.
        System.Media.SoundPlayer wallGreenSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\game_show_buzzer.wav");

        // This creates a Sound Player to create the sound when the player touch a Deep Pink wall.
        System.Media.SoundPlayer wallDeepPinkSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\haha.wav");

        // This creates a Sound Player to create the sound when the player touch the apple.
        System.Media.SoundPlayer foodSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\yummy.wav");

        // This creates a Sound Player to create the sound when the player touch the pacman.
        System.Media.SoundPlayer pacmanSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\pacman_death.wav");

        // This creates a Sound Player to create the sound when the player reach the finish.
        // Sound player
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\triosStudent\Documents\Visual Studio 2015\C# Dev Projects\CrazyMaze\Media\force.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Plays a sound, shows a Congrats MessageBox, then close the form.
            finishSoundPlayer.Play();
            MessageBox.Show("Congrats... you finally made it to the Finish !!!");
            MoveToStart();
        }

        /// <summary>
        /// Move the pointer to the point 10 pixels down and to the right
        /// of the starting point in the upper left corner of the maze.
        /// </summary>
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            // This wall_MouseEnter method was for a simple version of this game when all the walls were the same colour and sound.

            // When the mouse pointer hits a wall
            // call the MoveToStart method.
            //startSoundPlayer.Play();
            // MoveToStart();
        }

        private void apple_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer touches the apple
            // play a "yummy" sound.
            foodSoundPlayer.Play();
        }

        private void pacman_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer touches the pacman
            // play a "pacman got eaten by a ghost" sound then call the MoveToStart method.
            pacmanSoundPlayer.Play();
            MoveToStart();
        }

        private void dv_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Dark Violet wall
            // play a "Doh!" sound then call the MoveToStart method.
            wallDarkVioletSoundPlayer.Play();
            MoveToStart();
        }

        private void go_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Gold wall
            // play an "Aallrighty then..." sound.
            wallGoldSoundPlayer.Play();
        }

        private void gr_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Green wall
            // play a "buzzer" sound then call the MoveToStart method.
            wallGreenSoundPlayer.Play();
            MoveToStart();
        }

        private void bl_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Blue wall
            // play a "sad trombone"sound then call the MoveToStart method.
            wallBlueSoundPlayer.Play();
            MoveToStart();
        }

        private void fi_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Firebrick (red) wall
            // play a "scream" sound.
            wallFirebrickSoundPlayer.Play();
        }

        private void dp_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a Deep Pink wall
            // play a "ha ha" sound then call the MoveToStart method.
            wallDeepPinkSoundPlayer.Play();
            MoveToStart();
        }
    }
}
