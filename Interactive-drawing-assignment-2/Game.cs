// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Blinking Eye");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            DrawEye(200, 200);
        }

        void DrawEye(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Black;
            Draw.Circle(x - 25, y, 50);
        }
    }

}
