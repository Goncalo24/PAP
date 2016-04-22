using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Cars
{
    class MenuCarro
    {
        KeyboardState teclado;
        GamePadState gamepad;
        Game game;
        int opMenu; //posição selecionada no menu
        Texture2D c1, c2, c3;
        Texture2D opSair;
        bool disparou = false;
        int pvez = 1;

        public MenuCarro(Game game)
        {
            this.game = game;
            Initialize();

            LoadContent();
        }

        public void Initialize()
        {
            opMenu = 1;
        }

        public void LoadContent()
        {
            c1 = game.Content.Load<Texture2D>("pista 1");
            c2 = game.Content.Load<Texture2D>("pista 2");
            c3 = game.Content.Load<Texture2D>("pista 3");
            opSair = game.Content.Load<Texture2D>("sair");

        }

        //devolve 0-continuar;1,2,3 para pista 4 para sair
        public int atualizarMenu()
        {
            //teclas
            teclado = Keyboard.GetState();

            gamepad = GamePad.GetState(PlayerIndex.One);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                return 4;

            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
                return opMenu;

            if (teclado[Keys.Down] == KeyState.Down || teclado[Keys.Up] == KeyState.Down || teclado[Keys.Enter] == KeyState.Down)
            {
                if (disparou == true || pvez == 1) return 0;
                disparou = true;
            }
            else
            {
                disparou = false;
                pvez = 0;
            }

            if (teclado[Keys.Up] == KeyState.Down)
            {
                opMenu--;
                disparou = true;

            }
            if (teclado[Keys.Down] == KeyState.Down)
            {
                opMenu++;
                disparou = true;

            }
            if (opMenu < 1) opMenu = 4;
            if (opMenu > 4) opMenu = 1;

            if (teclado[Keys.Enter] == KeyState.Down)
            {
                return opMenu;
            }
            return 0;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            desenhaMenu(gameTime, spriteBatch);
        }

        public void desenhaMenu(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Rectangle rtemp;
            Color cor;

            if (opMenu == 1)
                cor = Color.White;
            else
                cor = Color.Brown;
            rtemp = new Rectangle(0, 0, c1.Width, c1.Height);
            spriteBatch.Draw(c1, rtemp, cor);

            if (opMenu == 2)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 100, c2.Width, c2.Height);
            spriteBatch.Draw(c2, rtemp, cor);

            if (opMenu == 3)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 200, c3.Width, c3.Height);
            spriteBatch.Draw(c3, rtemp, cor);

            if (opMenu == 4)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 300, opSair.Width, opSair.Height);
            spriteBatch.Draw(opSair, rtemp, cor);
        }
    }
}
