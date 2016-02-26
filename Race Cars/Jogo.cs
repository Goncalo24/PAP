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
    class Jogo
    {
        Game game;
        KeyboardState teclado;
        GamePadState gamepad;
        Jogador jogador;
        Pista pista;

        public Jogo(Game game)
        {
            this.game = game;
        }
        public void Initialize()
        {
            pista = new Pista(game);
            pista.Initialize();

            jogador = new Jogador(game);
            jogador.Initialize();
        }
        public void LoadContent()
        {
            pista.LoadContent();
            jogador.LoadContent();
        }
        //devolve true para voltar ao menu
        public bool Update(GameTime gameTime)
        {
            teclado = Keyboard.GetState();

            gamepad = GamePad.GetState(PlayerIndex.One);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || teclado[Keys.Escape] == KeyState.Down)
            {
                return true;
            }
            //atualizar jogador
            jogador.Update(teclado);

            return false;
        }
        public void Draw(GameTime gameTime, GraphicsDevice dispositivo, SpriteBatch spriteBatchPista, SpriteBatch spriteBatchJogador)
        {
            //fundo
            pista.Draw(spriteBatchPista);
            //plataformas
            //jogador
            jogador.Draw(spriteBatchJogador);
            //inimigos
            //balas
            //explosoes
        }
    }
}
