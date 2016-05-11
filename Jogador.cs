using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Race_Cars
{
    class Jogador
    {
        GraphicsDevice graphics;
        Vector2 pos1 = Vector2.Zero;
        public Game game;
        Texture2D imagem1, imagem2, imagem3, imagem4;
        bool esquerda, direi, cima, baixo;
        Rectangle retangulo;
        Rectangle posicao;
        int dir = 0;
        int velocidade = 0;
        int player = 0;
        int carro = 2;
        int id, pist;
        int pontuacao = 500;
        double voltas = 0;
        bool check1, check2, check3, check4=true;

        public Jogador(Game game)
        {
            this.game = game;
            graphics = game.GraphicsDevice;
        }

        public void Initialize()
        {
            posicao.X = 620;
            posicao.Y = 100;
        }

        public void LoadContent()
        {
            string[] data = File.ReadAllLines("Content/Carro.txt");
            id = int.Parse(data[0]);
            player = int.Parse(data[1]);
            carro = int.Parse(data[2]);

            if (player != 0)
            {
                if (carro == 1)
                {
                    velocidade = 2;

                    imagem1 = game.Content.Load<Texture2D>("TexturasJogador/carro1_lado");
                    retangulo = new Rectangle(0, 0, imagem1.Width, imagem1.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem2 = game.Content.Load<Texture2D>("TexturasJogador/carro1_cima");
                    retangulo = new Rectangle(0, 0, imagem2.Width, imagem2.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem3 = game.Content.Load<Texture2D>("TexturasJogador/carro1_de");
                    retangulo = new Rectangle(0, 0, imagem3.Width, imagem3.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem4 = game.Content.Load<Texture2D>("TexturasJogador/carro1_dd");
                    retangulo = new Rectangle(0, 0, imagem4.Width, imagem4.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;
                }
                else if (carro == 2)
                {
                    velocidade = 5;

                    imagem1 = game.Content.Load<Texture2D>("TexturasJogador/carro2_lado");
                    retangulo = new Rectangle(0, 0, imagem1.Width, imagem1.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem2 = game.Content.Load<Texture2D>("TexturasJogador/carro2_cima");
                    retangulo = new Rectangle(0, 0, imagem2.Width, imagem2.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem3 = game.Content.Load<Texture2D>("TexturasJogador/carro2_de");
                    retangulo = new Rectangle(0, 0, imagem3.Width, imagem3.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem4 = game.Content.Load<Texture2D>("TexturasJogador/carro2_dd");
                    retangulo = new Rectangle(0, 0, imagem4.Width, imagem4.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;
                }
                else if (carro == 3)
                {
                    velocidade = 8;

                    imagem1 = game.Content.Load<Texture2D>("TexturasJogador/carro3_lado");
                    retangulo = new Rectangle(0, 0, imagem1.Width, imagem1.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem2 = game.Content.Load<Texture2D>("TexturasJogador/carro3_cima");
                    retangulo = new Rectangle(0, 0, imagem2.Width, imagem2.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem3 = game.Content.Load<Texture2D>("TexturasJogador/carro3_de");
                    retangulo = new Rectangle(0, 0, imagem3.Width, imagem3.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;

                    imagem4 = game.Content.Load<Texture2D>("TexturasJogador/carro3_dd");
                    retangulo = new Rectangle(0, 0, imagem4.Width, imagem4.Height);
                    posicao.Width = retangulo.Width;
                    posicao.Height = retangulo.Height;
                }
            }
            else
            {
                velocidade = 5;

                imagem1 = game.Content.Load<Texture2D>("TexturasJogador/carro2_lado");
                retangulo = new Rectangle(0, 0, imagem1.Width, imagem1.Height);
                posicao.Width = retangulo.Width;
                posicao.Height = retangulo.Height;

                imagem2 = game.Content.Load<Texture2D>("TexturasJogador/carro2_cima");
                retangulo = new Rectangle(0, 0, imagem2.Width, imagem2.Height);
                posicao.Width = retangulo.Width;
                posicao.Height = retangulo.Height;

                imagem3 = game.Content.Load<Texture2D>("TexturasJogador/carro2_de");
                retangulo = new Rectangle(0, 0, imagem3.Width, imagem3.Height);
                posicao.Width = retangulo.Width;
                posicao.Height = retangulo.Height;

                imagem4 = game.Content.Load<Texture2D>("TexturasJogador/carro2_dd");
                retangulo = new Rectangle(0, 0, imagem4.Width, imagem4.Height);
                posicao.Width = retangulo.Width;
                posicao.Height = retangulo.Height;
            }
        }

        public bool Update(KeyboardState teclado,Pista pista, int npista)
        {
            Rectangle anterior = posicao;
            if (teclado[Keys.Up] == KeyState.Down)
            {
                posicao.Y -= velocidade;
                cima = true;
                baixo = false;
                dir = 1;
            }
            if (teclado[Keys.Down] == KeyState.Down) 
            {
                posicao.Y+=velocidade;
                cima = false;
                baixo = true;
                dir = 1;
            }
            if (teclado[Keys.Left] == KeyState.Down)
            {
                posicao.X-=velocidade;
                esquerda = true;
                direi = false;
                dir = 0;
            }
            if (teclado[Keys.Right] == KeyState.Down)
            {
                posicao.X+=velocidade;
                esquerda = false;
                direi = true;
                dir = 0;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 1 || pista.getTile(posicao.X, posicao.Y) == 4)
            {
                posicao = anterior;
                Console.WriteLine("x: {0}; y: {1}", posicao.X, posicao.Y);
            }
            if (pista.getTile(posicao.X, posicao.Y) == 2)
            {
                check4 = false;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 3)
            {
                posicao = anterior;
                pontuacao = pontuacao - 10;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 5)
            {
                check3 = true;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 6)
            {
                check2 = true;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 7)
            {
                check1 = true;
            }
            if (pista.getTile(posicao.X, posicao.Y) == 8)
            {
                check4 = true;
            }

            if (check1 == true && check2 == true && check3 == true && check4 == false)
            {
                voltas += 1;

                check1 = false;
                check2 = false;
                check3 = false;
                check4 = true;
            }
            if (voltas == 1)
            {
                pist = npista;
                Resultados r = new Resultados(id, pontuacao, carro, pist);
                r.Enabled = true;
                r.ShowDialog();
                return true;
            }
            return false;
        }

        public void Draw(SpriteBatch sprites)
        {
            if (dir == 0)
            {
                if (!esquerda)
                {
                    if (direi && cima)
                    {
                        sprites.Draw(imagem4, posicao, Color.White);
                        cima = false;
                    }
                    else
                    {
                        if (direi && baixo)
                        {
                            sprites.Draw(imagem4, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                                 0, Vector2.Zero, Vector2.One, SpriteEffects.FlipVertically, 0);
                            baixo = false;
                        }
                        else
                        {
                            sprites.Draw(imagem1, posicao, Color.White);
                        }
                    }
                }
                else
                {
                    if (cima && esquerda)
                    {
                        sprites.Draw(imagem3, posicao, Color.White);
                        cima = false;
                    }
                    else
                    {
                        if (esquerda && baixo)
                        {
                            sprites.Draw(imagem3, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                                0, Vector2.Zero, Vector2.One, SpriteEffects.FlipVertically, 0);
                            baixo = false;
                        }
                        else
                        {
                            sprites.Draw(imagem1, new Vector2(posicao.X, posicao.Y), retangulo, Color.White,
                               0, Vector2.Zero, Vector2.One, SpriteEffects.FlipHorizontally, 0);
                        }
                    }
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
