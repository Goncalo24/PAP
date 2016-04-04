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
        public Game game;
        Texture2D imagem;
        bool esquerda;
        Rectangle retangulo;
        Rectangle posicao;

        public Jogador(Game game)
        {
            this.game = game;
        }

        public void Initialize()
        {
            posicao.X = 100;
            posicao.Y = 100;
        }

        public void LoadContent()
        {
            imagem = game.Content.Load<Texture2D>("TexturasJogador/carro");
            retangulo = new Rectangle(0, 0, imagem.Width, imagem.Height);
            posicao.Width = retangulo.Width;
            posicao.Height = retangulo.Height;

        }

        public void Update(KeyboardState teclado)
        {
            if (teclado[Keys.Up] == KeyState.Down) posicao.Y--;
            if (teclado[Keys.Down] == KeyState.Down) posicao.Y++;
            if (teclado[Keys.Left] == KeyState.Down)
            {
                posicao.X--;
                esquerda = true;
            }
            if (teclado[Keys.Right] == KeyState.Down)
            {
                posicao.X++;
                esquerda = false;
            } 

        }

        public void Colisao(Rectangle novoRetangulo, int xOffset, int yOffset)
        {
            if(retangulo.TocaTopo(novoRetangulo))
            {
                retangulo.Y = novoRetangulo.Y - retangulo.Height;
            }

            if (retangulo.TocaEsquerda(novoRetangulo))
            {
                posicao.X = novoRetangulo.X - retangulo.Height - 2;
            }

            if (retangulo.TocaDireita(novoRetangulo))
            {
                posicao.X = novoRetangulo.X + retangulo.Height + 2;
            }
             
            if (retangulo.TocaFundo(novoRetangulo))
            {
                retangulo.Y = novoRetangulo.Y + retangulo.Height;
            }

            if (posicao.X < 0) posicao.X = 0;
            if (posicao.X > xOffset - retangulo.Width) posicao.X = xOffset - retangulo.Width;
            if (posicao.Y < 0) posicao.Y = 0;
            if (posicao.Y > yOffset - retangulo.Width) posicao.Y = yOffset - retangulo.Width;
        }

        public void Draw(SpriteBatch sprites)
        {
            if (!esquerda)
                sprites.Draw(imagem, posicao, Color.White);
            else
                sprites.Draw(imagem, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                    0, Vector2.Zero, Vector2.One, SpriteEffects.FlipHorizontally, 0);
        }
    }
}
