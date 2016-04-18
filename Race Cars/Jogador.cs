using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Race_Cars
{
    class Jogador
    {
        GraphicsDevice graphics;
        Vector2 pos1 = Vector2.Zero;
        public Game game;
        Texture2D imagem1, imagem2;
        bool esquerda, cima;
        Rectangle retangulo;
        Rectangle posicao;
        int dir = 0;

        public Jogador(Game game)
        {
            this.game = game;
            graphics = game.GraphicsDevice;
        }

        public void Initialize()
        {
            posicao.X = 100;
            posicao.Y = 100;
        }

        public void LoadContent()
        {
            imagem1 = game.Content.Load<Texture2D>("TexturasJogador/carro1_lado");
            retangulo = new Rectangle(0, 0, imagem1.Width, imagem1.Height);
            posicao.Width = retangulo.Width;
            posicao.Height = retangulo.Height;

            imagem2 = game.Content.Load<Texture2D>("TexturasJogador/carro1_cima");
            retangulo = new Rectangle(0, 0, imagem2.Width, imagem2.Height);
            posicao.Width = retangulo.Width;
            posicao.Height = retangulo.Height;
        }

        public void Update(KeyboardState teclado,Pista pista)
        {
            Rectangle anterior = posicao;
            if (teclado[Keys.Up] == KeyState.Down)
            {
                posicao.Y--;
                cima = true;
                dir = 1;
            }
            if (teclado[Keys.Down] == KeyState.Down) 
            {
                posicao.Y++;
                cima = false;
                dir = 1;
            }
            if (teclado[Keys.Left] == KeyState.Down)
            {
                posicao.X--;
                esquerda = true;
                dir = 0;
            }
            if (teclado[Keys.Right] == KeyState.Down)
            {
                posicao.X++;
                esquerda = false;
                dir = 0;
            }
            if (pista.getTile(posicao.X, posicao.Y) != 0)
            {
                posicao = anterior;
                Console.WriteLine("x: {0}; y: {1}", posicao.X, posicao.Y);
            }
        }

        public void Draw(SpriteBatch sprites)
        {
            if (dir == 0)
            {
                if (!esquerda)
                {
                    sprites.Draw(imagem1, posicao, Color.White);
                }
                else
                {
                    sprites.Draw(imagem1, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                            0, Vector2.Zero, Vector2.One, SpriteEffects.FlipHorizontally, 0);
                }
            }
            else
            {
                if (!cima)
                {
                    sprites.Draw(imagem2, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                             0, Vector2.Zero, Vector2.One, SpriteEffects.FlipVertically, 0);
                }
                else
                {
                    sprites.Draw(imagem2, posicao, Color.White);
                }
            }
        }
    }
}
