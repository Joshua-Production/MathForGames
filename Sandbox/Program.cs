using MathLibrary;
using Raylib_cs;
using System.Numerics;


namespace Sandbox
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Raylib.InitWindow(800, 480, "Hello World");
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Hello World");
            Vector2 deltaPosition = new Vector2(0, 0);
            Vector2 position = new Vector2();


            while (!Raylib.WindowShouldClose())
            {
                int speed = 1500;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Raylib.SetTargetFPS(60);
                Raylib.DrawRectangle((int)position.X, (int)position.Y, 30, 30, Color.Violet);
               
                
                Rectangle player = new Rectangle(0, 0, 0, 0);
                
                int up = Raylib.IsKeyDown(KeyboardKey.W);
                int down = Raylib.IsKeyDown(KeyboardKey.S);
                int left = Raylib.IsKeyDown(KeyboardKey.A);
                int right = Raylib.IsKeyDown(KeyboardKey.D);

                deltaPosition.Y -= up;
                deltaPosition.Y += down;
                deltaPosition.X -= left;
                deltaPosition.X += right;

                position.X = deltaPosition.X * Raylib.GetFrameTime() * speed;
                position.Y = deltaPosition.Y * Raylib.GetFrameTime() * speed;



                








                // Raylib.DrawCircle(400, 250, 300, Color.Orange);


                // //2
                // Raylib.DrawEllipse(320, 200, 40, 250, Color.Yellow);

                // //3
                //Raylib.DrawEllipse(480, 200, 40, 220, Color.Yellow);

                // // 1
                // Raylib.DrawEllipse(210, 250, 40, 220, Color.Yellow);

                // //4
                // Raylib.DrawEllipse(600, 250, 40, 220, Color.Yellow);

                // Raylib.DrawEllipse(400, 320, 220, 280, Color.Maroon);
                // Raylib.DrawEllipse(400, 320, 210, 250, Color.Red);

                // Raylib.DrawEllipse(400, 200, 140, 90, Color.Maroon);

                // Raylib.DrawEllipse(400, 200, 130, 70, Color.SkyBlue);
                // Raylib.DrawEllipse(340, 170, 40, 17, Color.RayWhite);
                // Raylib.DrawText("SHHHHHH!", 280, 380, 50, Color.White);


                Raylib.EndDrawing();
            }
            

            
                
            Raylib.CloseWindow();
        }
    }
}
