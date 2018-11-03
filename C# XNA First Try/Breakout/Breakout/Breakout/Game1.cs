using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Breakout
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Variables
        Texture2D tx2BluePaddle;
        Vector2 posBluePaddle = Vector2.Zero;

        Texture2D tx2BlueBall;
        Vector2 posBlueBall = Vector2.Zero;

        Texture2D[] tx2Bricks = new Texture2D[40];
        Vector2[] posBricks = new Vector2[40];

        Boolean boolMovingUp, boolMovingLeft;
        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            boolMovingLeft = true;
            boolMovingUp = true;

            spriteBatch = new SpriteBatch(GraphicsDevice);

            tx2BluePaddle = Content.Load<Texture2D>("BluePaddle");
            posBluePaddle = new Vector2((graphics.GraphicsDevice.Viewport.Width/2) - (tx2BluePaddle.Width/2), (graphics.GraphicsDevice.Viewport.Height - 80) - (tx2BluePaddle.Height / 2));

            tx2BlueBall = Content.Load<Texture2D>("BlueBall");
            posBlueBall = new Vector2((graphics.GraphicsDevice.Viewport.Width / 2) - (tx2BlueBall.Width / 2), (graphics.GraphicsDevice.Viewport.Height - 200) - (tx2BluePaddle.Height / 2));

            int brick = 0;

            for (int x= 0; x< 8; x ++)
            {
                for (int y=0; y<5; y++)
                {
                    tx2Bricks[brick] = Content.Load<Texture2D>("Brick");
                    posBricks[brick].X = 75 + (x * 75);
                    posBricks[brick].Y = 20 + (y * 50);
                    brick++;
                }
            }

        }

        protected override void UnloadContent()
        {
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            PaddleMovement();
            BallMovement();
            if (DetectPaddleBallCollision()) boolMovingUp = true;

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Wheat);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(tx2BluePaddle, posBluePaddle, Color.White);
            spriteBatch.Draw(tx2BlueBall, posBlueBall, Color.White);

            for (int brickC = 0; brickC < 40; brickC++)
            {
                spriteBatch.Draw(tx2Bricks[brickC], posBricks[brickC], Color.White);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void PaddleMovement()
        {
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left) && posBluePaddle.X >= 0)
            {
                posBluePaddle.X -= 4;
            }

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right) && posBluePaddle.X <= graphics.GraphicsDevice.Viewport.Width - tx2BluePaddle.Width)
            {
                posBluePaddle.X += 4;
            }

        }
        public void BallMovement()
        {
            if (boolMovingUp) posBlueBall.Y -= 2;
            else posBlueBall.Y += 2;

            if (boolMovingLeft) posBlueBall.X -= 2;
            else posBlueBall.X += 2;

            if (posBlueBall.X <= 0 && boolMovingLeft) boolMovingLeft = false;
            if (posBlueBall.Y <= 0 && boolMovingUp) boolMovingUp = false;

            if (posBlueBall.X >= (graphics.GraphicsDevice.Viewport.Width - tx2BlueBall.Width) && !boolMovingLeft) boolMovingLeft = true;
        }
        public Boolean DetectPaddleBallCollision()
        {
            if ((posBlueBall.Y + tx2BlueBall.Height >= posBluePaddle.Y) &&
                (posBlueBall.Y < posBluePaddle.Y + 4) &&
                (posBlueBall.X + tx2BlueBall.Width > posBluePaddle.X) && 
                (posBlueBall.X < posBluePaddle.X + tx2BluePaddle.Width))
            {
                return true;
            }
            else return false;
        }
    }
}
