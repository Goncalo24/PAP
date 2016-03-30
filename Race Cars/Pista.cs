using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System.IO;

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

        private List<Colisao> colisao = new List<Colisao>();

        public List<Colisao> Colisao
        {
            get { return colisao; }
        }

        private int comprimento, altura;
        public int Comprimento
        {
            get { return comprimento; }  
        }

        public int Altura
        {
            get { return altura; }
        }

        public Pista() { }

        public void Generate( int[,] mapa ,int tamanho)
        {
            Generate(new int[,]
            {
              { 1,1,1,1,1,1,1,1,1,1,1},
              { 1,0,0,0,0,0,0,0,0,0,1},
              { 1,0,0,0,0,0,0,0,0,0,1},
              { 1,0,0,0,0,0,0,0,0,0,1},
              { 1,0,0,0,0,0,0,0,0,0,1},
              { 1,1,1,1,1,1,1,1,1,1,1}
            }, 64);

            for (int x = 0; x < mapa.GetLength(1); x++)
            {
                for (int y = 0; y < mapa.GetLength(0); y++)
                {
                    int numero = mapa[y, x];

                    if (numero > 0)
                    {
                        colisao.Add(new Colisao(numero, new Rectangle(x * tamanho, y * tamanho, tamanho, tamanho)));
                    }

                    comprimento = (x + 1) * tamanho;
                    altura = (y + 1) * tamanho;
                }
            }
        }

        public Pista(Game game)
        {
            this.game = game;
        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {
            tileTextures.Add(game.Content.Load<Texture2D>("TexturasPistas/Tile1.bmp"));
            tileTextures.Add(game.Content.Load<Texture2D>("TexturasPistas/Tile2.jpg"));
        }

        public void Draw(SpriteBatch spritBatch)
        {
            foreach(Colisao tile in colisao)
            {
                tile.Draw(spritBatch);
            }
        }

        /*public void Draw(SpriteBatch sprites)
        {
           for (int y = 0; y < mapa.GetLength(0); y++)
           {
             for (int x = 0; x < mapa.GetLength(1); x++)
             {
                  int index = mapa[y, x];
             
                  Texture2D texture = tileTextures[index];
                  sprites.Draw(texture, new Rectangle(x * 64, y * 64, 64, 64), Color.White);
                  //spriteBatch.Draw(texture, new Rectangle(x * 64, y * 64, 64, 64), Color.White);
               }
            }
        }*/
    }
}
