// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Text.Json.Serialization.Metadata;

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
            Window.SetTitle("Eye");
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

            //Create player inputs

            if (Input.IsMouseButtonDown(0))
            {
                DrawEye(200, 200);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                DrawEyeLeft(200, 200);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                DrawEyeRight(200, 200);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                DrawEyeUp(200,200);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Down))
            {
                DrawEyeDown(200, 200);
            }
            else
            {
                DrawEye2(200, 200);
            }
        }


        //Normal Eye 
        void DrawEye(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(x, y, 25);
            Draw.FillColor = Color.Black;
            Draw.Circle(x, y, 10);
            
        }

        //Eye with dialated pupil
        void DrawEye2(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(x, y, 45);
            Draw.FillColor = Color.Black;
            Draw.Circle(x, y, 20);
        }

        //Eye looking left
        void DrawEyeLeft(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(150, y, 25);
            Draw.FillColor = Color.Black;
            Draw.Circle(145, y, 10);
        }

        //Eye looking right
        void DrawEyeRight(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(250, y, 25);
            Draw.FillColor = Color.Black;
            Draw.Circle(255, y, 10);
        }

        //Eye looking up
        void DrawEyeUp(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(x, 150, 25);
            Draw.FillColor = Color.Black;
            Draw.Circle(x, 145, 10);
        }

        //Eye looking down
        void DrawEyeDown(int x, int y)
        {
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(x,250,25);
            Draw.FillColor = Color.Black;
            Draw.Circle(x,255,10);
        }
    }

}
