using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        private const int MAX_POKEMONS = 5;

        private ArrayList pokemons = new ArrayList();
        private ArrayList pokemonLabels = new ArrayList();
        private ArrayList pokemonImages = new ArrayList();
        private ArrayList pokemonLives = new ArrayList();
        private string savedGame;

        private int currentTurn = 0;


        public Form1()
        {
            InitializeComponent();
            comboBoxPokemon1.SelectedIndex = 0;
        }

        private void UpdateHealthLabels()
        {
            for (int i=0; i<this.pokemons.Count; i++)
            {
                ((Label)this.pokemonLives[i]).Text = ((Pokemon)this.pokemons[i]).Health + "";
            }
        }

        private void StartBattle_btn(object sender, EventArgs e)
        {
            StartBattleBtn.Enabled = false;
            add_to_arena.Enabled = false;
            RemoveFromArena.Enabled = false;
            comboBoxPokemon1.Enabled = false;
            attack_button.Enabled = true;
            comboBoxAttackPokimon.Enabled = true;
            SaveGameBtn.Enabled = true;

            this.comboBoxAttackPokimon.Items.Clear();
            
            string[] pokemonNames = new string[this.pokemons.Count];
            for (int i = 0; i < this.pokemons.Count; i++)
                pokemonNames[i] = "Player " + (i+1) + " (" + this.pokemons[i].GetType().Name + ")";

            this.comboBoxAttackPokimon.Items.AddRange(pokemonNames);

            this.current_turn_label.Text = "It is currently player " + (this.currentTurn+1) +"'s turn. Who would you like to attack?";

        }

        private void comboBoxPokemon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private int nextTurnIndex()
        {
            int i = this.currentTurn;
            do
            {
                i = (i + 1) % this.pokemons.Count;
            }
            while (!((Pokemon)this.pokemons[i]).Alive && i != this.currentTurn) ;

            return i;
        }

        private void attack_button_click(object sender, EventArgs e)
        {
            if (comboBoxAttackPokimon.SelectedIndex < 0)
                return;
            if (this.pokemons[this.currentTurn] == null)
                return;

            Pokemon PokeAttaker, Pokedefender;
            PokeAttaker = (Pokemon) pokemons[this.currentTurn];
            Pokedefender= (Pokemon) pokemons[this.comboBoxAttackPokimon.SelectedIndex];

            Pokedefender.defend(PokeAttaker.attack());

            this.comboBoxAttackPokimon.SelectedItem = null; 
            UpdateHealthLabels();

            int nextTurn = nextTurnIndex(); 

            if (nextTurn == this.currentTurn)
            {
                // there is only one survivor
                this.current_turn_label.Text = "Player " + (this.currentTurn + 1) + " won!";
                this.attack_button.Enabled = false;
            }
            else
            {
                this.currentTurn = nextTurn;
                this.current_turn_label.Text = "It is currently player " + (this.currentTurn + 1) + "'s turn. Who would you like to attack?";
            }
        }

        private void add_to_arena_Click(object sender, EventArgs e)
        {
            if (this.pokemons.Count >= MAX_POKEMONS)
                return;



            Pokemon p = null;
            switch (comboBoxPokemon1.Text)
            {
                case "Pikachu":
                    p = new Pikachu();
                    break;
                case "Magnemite":
                    p = new Magnemite();
                    break;
                case "Squirtle":
                    p = new Squirtle() ;
                    break;
                case "Psyduck":
                    p = new Psyduck();
                    break;
                case "Charmander":
                    p = new Charmander();
                    break;
                case "Ponyta":
                    p = new Ponyta();
                    break;
            }

            this.pokemons.Add(p);

            this.Label_Count_Pokemon_Arena.Text = "There are currently " + this.pokemons.Count + " pokemons in the arena";

            Label pokemonLabel = this.addLabel(this.pokemons[this.pokemons.Count - 1].GetType().Name, 100 + (this.pokemons.Count - 1) * 120, 200);
            this.pokemonLabels.Add(pokemonLabel);

            Label pokemonLife = this.addLabel(((Pokemon)this.pokemons[this.pokemons.Count - 1]).Health + "", 120 + (this.pokemons.Count - 1) * 120, 220);
            this.pokemonLives.Add(pokemonLife);

            PictureBox picture = new PictureBox
            {
                Name = "pictureBox" + this.pokemons.Count,
                Size = new Size(70, 70),
                Location = new Point(100 + (this.pokemons.Count - 1) * 120, 245),
                Image = p.Image,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage

            };
            this.Controls.Add(picture);
            this.pokemonImages.Add(picture);

            if (this.pokemons.Count > 1)
                StartBattleBtn.Enabled = true;

            UpdateHealthLabels();
        }
        private Label addLabel(string text, int x, int y)
        {
            Label label = new Label
            {
                Location = new Point(x, y),
                Text = text,
                AutoSize = true,
                Font = new Font("Arial", 13),
                BackColor = Color.Red

            };
            //label.Location = new Point((int) (Math.Cos(2 * Math.PI / this.pokemons.Count)*300 + 600), (int)(600 - Math.Sin(2 * Math.PI / this.pokemons.Count)*300));
            
            this.Controls.Add(label);
            return label;
        }

        private void RemoveLast(object sender, EventArgs e)
        {
            int i = pokemons.Count - 1;
            if (i < 0) 
                return;

            this.Controls.Remove((Control) this.pokemonLabels[i]);
            this.Controls.Remove((Control) this.pokemonLives[i]);
            this.Controls.Remove((Control) this.pokemonImages[i]);

            this.pokemons.RemoveAt(i);
            this.pokemonLabels.RemoveAt(i);
            this.pokemonLives.RemoveAt(i);
            this.pokemonImages.RemoveAt(i);

            this.Label_Count_Pokemon_Arena.Text = "There are currently " + this.pokemons.Count + " pokemons in the arena";
            
            if (this.pokemons.Count <= 1)
                StartBattleBtn.Enabled = false;
        }

        private void TurnPanel(object sender, EventArgs e)
        {

        }

        private void SaveTheGame(object sender, EventArgs e)
        {
            PokemonGameSerializationString s = new PokemonGameSerializationString(this.currentTurn, this.pokemons);
            this.savedGame = JsonSerializer.Serialize(s);
        }

        private void Load_Game(object sender, EventArgs e)
        {
            if (this.savedGame == null)
                return;

            PokemonGameSerializationString o = JsonSerializer.Deserialize<PokemonGameSerializationString>(this.savedGame);

            ArrayList p = new ArrayList();
            for (int i = 0; i < o.pokemons.Length; i++)
            {
                p.Add(o.pokemons[i].deserialize());
            }

            Reset_Game(null,null);            // remove everything from the board

            this.pokemons = p;
            this.currentTurn = o.CurrentTurn;

            UpdateBoard();
        }

        private void UpdateBoard()
        {
            StartBattleBtn.Enabled = false;
            if(this.pokemons.Count<=1)
            {
                
                add_to_arena.Enabled = true;
                RemoveFromArena.Enabled = true;
                comboBoxPokemon1.Enabled = true;

                attack_button.Enabled = false;
                comboBoxAttackPokimon.Enabled = false;
            }
            else
            {
                add_to_arena.Enabled = false;
                RemoveFromArena.Enabled = false;
                comboBoxPokemon1.Enabled = false;

                attack_button.Enabled = true;
                comboBoxAttackPokimon.Enabled = true;
            }

            this.Label_Count_Pokemon_Arena.Text = "There are currently " + this.pokemons.Count + " pokemons in the arena";// update the string that says how many pokemons there are
            this.current_turn_label.Text = "It is currently player " + (this.currentTurn + 1) + "'s turn. Who would you like to attack?";// update the string below that says "it is currently XX turn"


            for (int i = 0; i < this.pokemons.Count; i++)// add the labels, lives, images of pokemons that are currently in this.pokemons
            {

                Label pokemonLabel = this.addLabel(this.pokemons[i].GetType().Name, 100 + (i) * 120, 200);
                this.pokemonLabels.Add(pokemonLabel);

                Label pokemonLife = this.addLabel(((Pokemon)this.pokemons[i]).Health + "", 120 + (i) * 120, 220);
                this.pokemonLives.Add(pokemonLife);

                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(70, 70),
                    Location = new Point(100 + (i) * 120, 245),
                    Image = ((Pokemon)pokemons[i]).Image,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage

                };
                this.Controls.Add(picture);
                this.pokemonImages.Add(picture);

            }

            this.comboBoxAttackPokimon.Items.Clear();

            string[] pokemonNames = new string[this.pokemons.Count];
            for (int i = 0; i < this.pokemons.Count; i++)
                pokemonNames[i] = "Player " + (i + 1) + " (" + this.pokemons[i].GetType().Name + ")";

            this.comboBoxAttackPokimon.Items.AddRange(pokemonNames);


            UpdateHealthLabels();
            

        }

        private void Reset_Game(object sender, EventArgs e)
        {
            for (int i = this.pokemons.Count - 1; i >= 0; i--)
            {
                RemoveLast(null, null);
            }
            this.currentTurn = 0;
            StartBattleBtn.Enabled = false;

            add_to_arena.Enabled = true;
            RemoveFromArena.Enabled = true;
            comboBoxPokemon1.Enabled = true;

            attack_button.Enabled = false;
            comboBoxAttackPokimon.Enabled = false;
            this.current_turn_label.Text = "It is currently player " + (this.currentTurn + 1) + "'s turn. Who would you like to attack?";


        }
    }
}

