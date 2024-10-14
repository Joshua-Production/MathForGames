using MathLibrary;
using Raylib_cs;



namespace Sandbox
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           

            Raylib.InitWindow(800, 480, "Hello World");
           
           
            while (!Raylib.WindowShouldClose())
            {
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Raylib.SetTargetFPS(60);
                Raylib.DrawRectangleV(new Vector2(100, 100), new Vector2(150, 150), Color.Red);


               


                //Raylib.DrawCircle(400, 250, 300, Color.Orange);


                ////2
                //Raylib.DrawEllipse(320, 200, 40, 250, Color.Yellow);

                ////3
                //Raylib.DrawEllipse(480, 200, 40, 220, Color.Yellow);

                //// 1
                //Raylib.DrawEllipse(200, 250, 40, 220, Color.Yellow);

                ////4
                //Raylib.DrawEllipse(600, 250, 40, 220, Color.Yellow);

                //Raylib.DrawEllipse(400, 320, 220, 280, Color.Maroon);
                //Raylib.DrawEllipse(400, 320, 210, 250, Color.Red);

                //Raylib.DrawEllipse(400, 200, 140, 90, Color.Maroon);

                //Raylib.DrawEllipse(400, 200, 130, 70, Color.SkyBlue);
                //Raylib.DrawEllipse(340, 170, 40, 17, Color.RayWhite);
                //Raylib.DrawText("SHHHHHH!", 280, 380, 50, Color.White);


                //Raylib.EndDrawing();
            }




            Raylib.CloseWindow();
        }
    }
}
