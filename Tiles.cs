using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Race_Cars
{
    class Tiles
    {
        protected Texture2D texture;
        private Rectangle rectangle;
        public Rectangle Rectangle
        {
            get { return rectangle; }
            protected set { rectangle = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }

    class Colisao : Tiles
    {
        public Colisao(Game game, int i, Rectangle NovoRetangulo)
        {
                texture = game.Content.Load<Texture2D>("TexturasPistas/Tile" + i);
                this.Rectangle = NovoRetangulo;  
        }
    }
}
