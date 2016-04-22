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
        List<Texture2D> tileTextures = new List<Texture2D>();
        public List<Colisao> colisao = new List<Colisao>();
        int[,] mapa;
        public int comprimento, altura;

        public Pista(Game game)
        {
            this.game = game;
          
        }

        public void Generate( int tamanho, int npista)
        {
            string[] mapData = File.ReadAllLines("Pistas/pista"+npista+".txt");
            
            var width = mapData[0].Length;
            var height = mapData.Length;
            mapa = new int[height,width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    mapa[y, x] =int.Parse( mapData[y][x].ToString());
            }

            for (int x = 0; x < mapa.GetLength(1); x++)
            {
                for (int y = 0; y < mapa.GetLength(0); y++)
                {
                    int numero = mapa[y, x];

                    if (numero > 0)
                    {
                        colisao.Add(new Colisao(game,numero, new Rectangle(x * tamanho, y * tamanho, tamanho, tamanho)));
                    }

                    comprimento = (x + 1) * tamanho;
                    altura = (y + 1) * tamanho;
                }
            }
        }


        public void Initialize(int npista)
        {
            //carregar mapa do ficheiro
            Generate( 64, npista);
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

        public int getTile(int X, int Y)
        {
            double pX = (double)X / 64;
            double pY = (double)Y / 64;
            int fx =(int) Math.Ceiling(pX);
            int fy = (int)Math.Ceiling(pY);
            int ix = (int)Math.Floor(pX);
            int iy = (int)Math.Floor(pY);

            for (int i = ix; i <= fx; i++)
            {
                for (int l = iy; l <= fy; l++)
                {
                    if (mapa[l,i]!=0)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
