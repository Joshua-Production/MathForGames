﻿using MathLibrary;
using Raylib_cs;



namespace Sandbox
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           

            Raylib.InitWindow(800, 480, "Hello World");

            Vector2 screenDimensions = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            // Player
            Vector2 playerPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.75f);
            float playerRadius = 10;
            float playerSpeed = 50;
            Vector2 playerForward = new Vector2(0, 1).Normalized;

            // Enemy
            Vector2 enemyPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.5f);
            float enemyRadius = 10;
            Color enemyColor = Color.Red;

            float playerViewAngle = 90;
            float playerViewDistance = 300;
            
            while (!Raylib.WindowShouldClose())
            {
                // Update

                
                // Movement 
                Vector2 movementInput = new Vector2();
                 movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                 movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                 movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                 movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

                playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();
               
               
               
               
                // Calculate LOS

                Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;
                float distance = enemyPosition.Distance(playerPosition);
                float angleToEnemy = (float)Math.Abs(playerToEnemyDirection.Angle(playerForward));

               
                

                // If enemy is in sight
                if (Math.Abs(angleToEnemy) < (playerViewAngle / 2 )  * (Math.PI / 180) && distance < playerViewDistance)
                {
                    enemyColor = Color.Purple;
                }
                else
                {
                    enemyColor = Color.Red;
                }

                // Draw
               
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);


                // Draw enemy 

                Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);
                // Draw player
                Raylib.DrawCircleV(playerPosition, playerRadius, Color.Green);


                // Draw player forward
                Raylib.DrawLineEx(playerPosition, playerPosition - (playerForward * 100), 3,Color.Orange);

                // Draw view cone
                Raylib.DrawCircleSectorLines(
                    playerPosition,
                    playerViewDistance,
                    -90 - (playerViewAngle / 2),
                    -90 + (playerViewAngle / 2),
                     10,
                     Color.Blue);


                Raylib.EndDrawing();
                //Raylib.SetTargetFPS(60);
                //Raylib.DrawRectangleV(new Vector2(100, 100), new Vector2(150, 150), Color.Red);





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
