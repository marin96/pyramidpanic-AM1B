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

namespace PyramidPanic
{
   
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public PyramidPanic()
        {
          
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            //Maakt de muiscursor zichtbaar in het canvas
            this.IsMouseVisible = true;

            //Veranderd de titel van het canvas
            this.Window.Title = "Pyramid Panic";

            //Veranderd de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;

            //Veranderd de hoogte vaan het canvas
            this.graphics.PreferredBackBufferHeight = 480;

            //Past de veranderingen betreffende het canvas toe
            this.graphics.ApplyChanges();
            base.Initialize();
        }

       
        protected override void LoadContent()
        {
 
            spriteBatch = new SpriteBatch(GraphicsDevice);

    
        }

       void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
           
            if ( (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) || 
                (Keyboard.GetState().IsKeyDown(Keys.Escape))) 
                this.Exit();

         

            base.Update(gameTime);
        }

    
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

         

            base.Draw(gameTime);
        }
    }
}
