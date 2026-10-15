using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace Death_Runners;

public class Game1 : Core
{
        
    private TextureRegion _arbusto;
    private TextureRegion _arbustoLargo;
    // private TextureRegion _moto;
    // private Texture2D _suelo;
    // private Texture2D _pinchos;


    public Game1() : base("Death Runners", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        TextureAtlas atlas = TextureAtlas.FromFile(Content, "Juego_Moto_Img/atlas-definition.xml");
        // _arbustos = Content.Load<Texture2D>("Juego_Moto_Img/arbustos");
        _arbusto = atlas.GetRegion("arbusto");
        _arbustoLargo = atlas.GetRegion("arbustoLargo");
        // _suelo = Content.Load<Texture2D>("Juego_Moto_Img/suelo");
        // _pinchos = Content.Load<Texture2D>("Juego_Moto_Img/pinchosPista");

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        // Begin the sprite batch to prepare for rendering.
        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        // Draw the logo texture
        _arbusto.Draw(SpriteBatch, Vector2.Zero, Color.White, 0.0f, Vector2.One, 2.0f, SpriteEffects.None, 0.0f);
        _arbustoLargo.Draw(SpriteBatch, new Vector2(_arbusto.Width * 4.0f + 10, 0), Color.White, 0.0f, Vector2.One, 2.0f, SpriteEffects.None, 0.0f);
        // SpriteBatch.Draw(_arbustos, Vector2.Zero, Color.White);
        // SpriteBatch.Draw(_moto, Vector2.Zero, Color.White);
        // SpriteBatch.Draw(_suelo, Vector2.Zero, Color.White);
        // SpriteBatch.Draw(_pinchos, Vector2.Zero, Color.White);

        // Always end the sprite batch when finished.
        SpriteBatch.End();


        base.Draw(gameTime);
    }
}