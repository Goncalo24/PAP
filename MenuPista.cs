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
    class MenuPista
    {
        KeyboardState teclado;
        GamePadState gamepad;
        Game game;
        int opMenu; //posição selecionada no menu
        Texture2D p1, p2, p3;
        Texture2D opSair;
        bool disparou = false;
        int pvez = 1;

        public MenuPista(Game game)
        {
            this.game = game;
            Initialize();

            LoadContent();
           // Update(gameTime);
        //    atualizarMenu();
            //Draw(gameTime, dispositivo, spriteBatch);
          //  desenhaMenu(gameTime, spriteBatch);
        }

        public void Initialize()
        {
            opMenu = 1;

            
        }

        public void LoadContent()
        {
            p1 = game.Content.Load<Texture2D>("pista 1");
            p2 = game.Content.Load<Texture2D>("pista 2");
            p3 = game.Content.Load<Texture2D>("pista 3");
            opSair = game.Content.Load<Texture2D>("sair");

        }

      /*  public void Update(GameTime gameTime)
        {
            //atualizar jogo
           //atualizarMenu();
            //atualizar menu
           
        }*/
        //devolve: 0-continuar; 1,2,3 para pista; 4 para sair
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
            
            //iniciar desenhar
          /*  spriteBatch.Begin();*/

                desenhaMenu(gameTime, spriteBatch);


            //terminar desenhar
          //  spriteBatch.End();
        }

        public void desenhaMenu(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Rectangle rtemp;
            Color cor;

            if (opMenu == 1)
                cor = Color.White;
            else
                cor = Color.Brown;
            rtemp = new Rectangle(0, 0, p1.Width, p1.Height);
            spriteBatch.Draw(p1, rtemp, cor);

            if (opMenu == 2)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 100, p2.Width, p2.Height);
            spriteBatch.Draw(p2, rtemp, cor);

            if (opMenu == 3)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 200, p3.Width, p3.Height);
            spriteBatch.Draw(p3, rtemp, cor);

            if (opMenu == 4)
                cor = Color.White;
            else
                cor = Color.Brown;

            rtemp = new Rectangle(0, 300, opSair.Width, opSair.Height);
            spriteBatch.Draw(opSair, rtemp, cor);
        }
    }
}
