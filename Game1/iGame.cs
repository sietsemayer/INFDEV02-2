using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public interface iGame {
        SpriteBatch spriteBatch { get; }
        GraphicsDevice GraphicsDevice { get; }
    }
}
