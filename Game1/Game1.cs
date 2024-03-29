﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using GUI;
using System;
using System.Diagnostics;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game, iGame {
        public GraphicsDeviceManager graphics { protected set; get; }
        public SpriteBatch spriteBatch { protected set; get; }

        //public GraphicsDevice graphicsDevice { get; }
        List<AbstractGuiComponent> components = new List<AbstractGuiComponent>();

        public Game1() {

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            this.IsMouseVisible = true;
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

            Button b = new Button(10, 10, 100, 25, "click me", Content.Load<SpriteFont>("Pesca"));
            b.addListener(() => Debug.WriteLine("Mouse Clicked LAMBDA!!!;"));
            components.Add(b);
            components.Add(new Label("test", Content.Load<SpriteFont>("Pesca"), 10, 60));
            components.Add(PanelFactory.generatePanel(Content));
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach( AbstractGuiComponent obj in components ) {
                obj.update(this);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.HotPink);

            // TODO: Add your drawing code here
            
            spriteBatch.Begin();
            foreach(AbstractGuiComponent obj in components ) {
                obj.paint(this);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public Point getMousePoint() {
            return new Point(Mouse.GetState().X, Mouse.GetState().Y);
        }

        public MouseState getMouseState() {
            return Mouse.GetState();
        }
    }
}
