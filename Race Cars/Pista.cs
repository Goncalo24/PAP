using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace Race_Cars
{
    class Pista
    {
        public Game game;
        Rectangle retangulo;
        Rectangle posicao;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        List<Texture2D> tileTextures = new List<Texture2D>();

        int[,] map = new int[,]
        {
            {0,0,0,1,1,1,1,0,0,0},
            {0,0,1,0,0,0,0,1,0,0},
            {0,1,0,0,0,0,0,0,1,0},
            {0,0,1,0,0,0,0,1,1,0},
            {0,0,0,1,1,1,1,1,0,0},
        };


        public Pista(Game game)
        {
            this.game = game;
        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {
            tileTextures.Add(game.Content.Load<Texture2D>("TexturasPistas/mud_wa_nm.bmp"));
            tileTextures.Add(game.Content.Load<Texture2D>("TexturasPistas/se_free_rock_texture.jpg"));
        }

        public void Draw(SpriteBatch sprites)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    int index = map[y, x];

                    Texture2D texture = tileTextures[index];
                    sprites.Draw(texture, new Rectangle(x * 64, y * 64, 64, 64), Color.White);
                    //spriteBatch.Draw(texture, new Rectangle(x * 64, y * 64, 64, 64), Color.White);
                }
            }
        }
    }
}
