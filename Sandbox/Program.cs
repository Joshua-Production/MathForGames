using MathLibrary;
using Raylib_cs;



namespace Sandbox
{
    internal class Program
    {
        const float SCALE_MULTIPLIER = 100;
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetTargetFPS(60);
            

            Actor a = new Actor();

            Transform2D t1 = new Transform2D(a);
            Vector2 offset = new Vector2(t1.LocalScale.x * SCALE_MULTIPLIER / 2, t1.LocalScale.y * SCALE_MULTIPLIER / 2);
            t1.LocalPosition = new Vector2(
                (Raylib.GetScreenWidth() * 0.33f) - offset.x,
                (Raylib.GetScreenWidth() * 0.33f) - offset.y);


            Transform2D t2 = new Transform2D(a);
            t1.AddChild(t2);
            t2.LocalScale = new Vector2(.5f, .5f);
            t2.LocalPosition = new Vector2(
                (100) - offset.x,
                (50) - offset.y);

            t1.LocalPosition = new Vector2(

                (Raylib.GetScreenHeight() * 0.33f) - offset.y);




            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                t1.Translate(t1.Forward * 50 * Raylib.GetFrameTime());
                t1.Rotate(0.5f * Raylib.GetFrameTime());

                t2.Rotate(0.5f * Raylib.GetFrameTime());

                
                // Draw t1
                Rectangle rect = new Rectangle(t1.GlobalPositon + offset, t1.GlobalScale * SCALE_MULTIPLIER);
                Raylib.DrawRectanglePro(
                    rect,
                    new Vector2(0, 0) + offset,
                    -t1.GlobalRotationAngle * (180 / (float)Math.PI),
                    Color.Blue);

                // Draw t2
                rect = new Rectangle(t2.GlobalPositon + offset, t2.GlobalScale * SCALE_MULTIPLIER);
                Raylib.DrawRectanglePro(
                    rect,
                    new Vector2(0, 0) + offset / 2,
                    -t2.GlobalRotationAngle * (180 / (float)Math.PI),
                    Color.Green);



                Raylib.DrawRectangleV(t1.GlobalPositon, t1.GlobalScale, Color.Blue);
                
                Raylib.DrawLineV(t1.GlobalPositon + offset, t1.GlobalPositon + offset + (t1.Forward * 100), Color.Red);
                Raylib.EndDrawing();

               

            }

            Raylib.CloseWindow();
          
            #region OLD CODE
            //    // Testing my DotProduct for Vector2

            //    Vector2 vector2test = new Vector2(1, 2);
            //    Vector2 vector2test2 = new Vector2(3, 4);

            //    // Making a variable that stores the sum
            //    float vector2sum;

            //    // using DotProduct
            //    vector2sum = vector2test.DotProduct(vector2test2);

            //    Console.WriteLine(vector2test.x + " " + vector2test.y);
            //    Console.WriteLine(vector2test2.x + " " + vector2test2.y);
            //    Console.WriteLine(vector2sum);




            //    // Testing DotProduct for Vector3

            //    // Create new vectors and giving them values
            //    Vector3 vector3test = new Vector3(1, 2, 3);
            //    Vector3 vector3test2 = new Vector3(4, 5, 6);

            //    // Making a variable that stores the sum
            //    float vector3sum;

            //    // using DotProduct
            //    vector3sum = vector3test.DotProduct(vector3test2);

            //    Console.WriteLine(vector3test.x + " " + vector3test.y + " " + vector3test.z);
            //    Console.WriteLine(vector3test2.x + " " + vector3test2.y + " " + vector3test2.z);
            //    Console.WriteLine(vector3sum);

            //    Matrix3 matrix3test = new Matrix3
            //                             (1, 0, 0,                 
            //                             0, 1, 0,
            //                             0, 0, 1);



            //    Console.WriteLine(matrix3test);

            //    // Vectors
            //    // - pre scale float * vector /

            //    // Matrix 3 
            //    // - Create Rotation (float) /
            //    // Matrix3 * Vector3/

            //    // Matrix4
            //    // - Create Rotation x(float)/
            //    // - Create Rotation y(float)/
            //    // - Create Rotation z(float)/
            //    // - Matrix4 * Vector4





            //    // Creating a window for our game

            //    Raylib.InitWindow(800, 480, "Hello World");


            //    Vector2 screenDimensions = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            //    // Player
            //    Vector2 playerPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.75f);
            //    float playerRadius = 10;
            //    float playerSpeed = 50;
            //    Vector2 playerForward = new Vector2(0, 1).Normalized;

            //    // Enemy
            //    Vector2 enemyPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.5f);
            //    float enemyRadius = 10;
            //    Color enemyColor = Color.Red;

            //    float playerViewAngle = 90;
            //    float playerViewDistance = 300;

            //    while (!Raylib.WindowShouldClose())
            //    {
            //        // Update


            //        // Movement 
            //        Vector2 movementInput = new Vector2();
            //         movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
            //         movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
            //         movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
            //         movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

            //        playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();




            //        // Calculate LOS

            //        Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;
            //        float distance = enemyPosition.Distance(playerPosition);
            //        float angleToEnemy = (float)Math.Abs(playerToEnemyDirection.Angle(playerForward));




            //        // If enemy is in sight
            //        if (Math.Abs(angleToEnemy) < (playerViewAngle / 2 )  * (Math.PI / 180) && distance < playerViewDistance)
            //        {
            //            enemyColor = Color.Purple;
            //        }
            //        else
            //        {
            //            enemyColor = Color.Red;
            //        }

            //        // Draw

            //        Raylib.BeginDrawing();
            //        Raylib.ClearBackground(Color.White);


            //        // Draw enemy 

            //        Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);
            //        // Draw player
            //        Raylib.DrawCircleV(playerPosition, playerRadius, Color.Green);


            //        // Draw player forward
            //        Raylib.DrawLineEx(playerPosition, playerPosition - (playerForward * 100), 3,Color.Orange);

            //        // Draw view cone
            //        Raylib.DrawCircleSectorLines(
            //            playerPosition,
            //            playerViewDistance,
            //            -90 - (playerViewAngle / 2),
            //            -90 + (playerViewAngle / 2),
            //             10,
            //             Color.Blue);


            //        Raylib.EndDrawing();
            //        //Raylib.SetTargetFPS(60);
            //        //Raylib.DrawRectangleV(new Vector2(100, 100), new Vector2(150, 150), Color.Red);





            //        //Raylib.DrawCircle(400, 250, 300, Color.Orange);


            //        ////2
            //        //Raylib.DrawEllipse(320, 200, 40, 250, Color.Yellow);

            //        ////3
            //        //Raylib.DrawEllipse(480, 200, 40, 220, Color.Yellow);

            //        //// 1
            //        //Raylib.DrawEllipse(200, 250, 40, 220, Color.Yellow);

            //        ////4
            //        //Raylib.DrawEllipse(600, 250, 40, 220, Color.Yellow);

            //        //Raylib.DrawEllipse(400, 320, 220, 280, Color.Maroon);
            //        //Raylib.DrawEllipse(400, 320, 210, 250, Color.Red);

            //        //Raylib.DrawEllipse(400, 200, 140, 90, Color.Maroon);

            //        //Raylib.DrawEllipse(400, 200, 130, 70, Color.SkyBlue);
            //        //Raylib.DrawEllipse(340, 170, 40, 17, Color.RayWhite);
            //        //Raylib.DrawText("SHHHHHH!", 280, 380, 50, Color.White);


            //        //Raylib.EndDrawing();
            //    }




            //    Raylib.CloseWindow();
            //}
            #endregion
        }
    }
}
