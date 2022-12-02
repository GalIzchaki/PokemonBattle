
namespace PokemonBattle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attack_button = new System.Windows.Forms.Button();
            this.current_turn_label = new System.Windows.Forms.Label();
            this.comboBoxPokemon1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.add_to_arena = new System.Windows.Forms.Button();
            this.RemoveFromArena = new System.Windows.Forms.Button();
            this.comboBoxAttackPokimon = new System.Windows.Forms.ComboBox();
            this.SaveGameBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ResetGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Count_Pokemon_Arena = new System.Windows.Forms.Label();
            this.StartBattleBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // attack_button
            // 
            this.attack_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attack_button.Enabled = false;
            this.attack_button.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attack_button.Location = new System.Drawing.Point(575, 10);
            this.attack_button.Margin = new System.Windows.Forms.Padding(2);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(99, 37);
            this.attack_button.TabIndex = 2;
            this.attack_button.Text = "Attack!";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.attack_button_click);
            // 
            // current_turn_label
            // 
            this.current_turn_label.AutoSize = true;
            this.current_turn_label.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_turn_label.Location = new System.Drawing.Point(9, 23);
            this.current_turn_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.current_turn_label.Name = "current_turn_label";
            this.current_turn_label.Size = new System.Drawing.Size(229, 16);
            this.current_turn_label.TabIndex = 1;
            this.current_turn_label.Text = "Press Start Battle to begin fighting!";
            this.current_turn_label.Click += new System.EventHandler(this.TurnPanel);
            // 
            // comboBoxPokemon1
            // 
            this.comboBoxPokemon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPokemon1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPokemon1.FormattingEnabled = true;
            this.comboBoxPokemon1.Items.AddRange(new object[] {
            "Pikachu",
            "Magnemite",
            "Squirtle",
            "Psyduck",
            "Charmander",
            "Ponyta"});
            this.comboBoxPokemon1.Location = new System.Drawing.Point(158, 23);
            this.comboBoxPokemon1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPokemon1.Name = "comboBoxPokemon1";
            this.comboBoxPokemon1.Size = new System.Drawing.Size(129, 23);
            this.comboBoxPokemon1.TabIndex = 4;
            this.comboBoxPokemon1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemon1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a Pokemon:";
            // 
            // add_to_arena
            // 
            this.add_to_arena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_arena.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_to_arena.Location = new System.Drawing.Point(300, 8);
            this.add_to_arena.Margin = new System.Windows.Forms.Padding(2);
            this.add_to_arena.Name = "add_to_arena";
            this.add_to_arena.Size = new System.Drawing.Size(122, 48);
            this.add_to_arena.TabIndex = 10;
            this.add_to_arena.Text = "Add to Arena!";
            this.add_to_arena.UseVisualStyleBackColor = true;
            this.add_to_arena.Click += new System.EventHandler(this.add_to_arena_Click);
            // 
            // RemoveFromArena
            // 
            this.RemoveFromArena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveFromArena.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveFromArena.Location = new System.Drawing.Point(518, 8);
            this.RemoveFromArena.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveFromArena.Name = "RemoveFromArena";
            this.RemoveFromArena.Size = new System.Drawing.Size(136, 48);
            this.RemoveFromArena.TabIndex = 11;
            this.RemoveFromArena.Text = "Remove Last Pokemon";
            this.RemoveFromArena.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveFromArena.UseVisualStyleBackColor = true;
            this.RemoveFromArena.Click += new System.EventHandler(this.RemoveLast);
            // 
            // comboBoxAttackPokimon
            // 
            this.comboBoxAttackPokimon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAttackPokimon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttackPokimon.Enabled = false;
            this.comboBoxAttackPokimon.FormattingEnabled = true;
            this.comboBoxAttackPokimon.Location = new System.Drawing.Point(393, 19);
            this.comboBoxAttackPokimon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAttackPokimon.Name = "comboBoxAttackPokimon";
            this.comboBoxAttackPokimon.Size = new System.Drawing.Size(171, 23);
            this.comboBoxAttackPokimon.TabIndex = 12;
            // 
            // SaveGameBtn
            // 
            this.SaveGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveGameBtn.Enabled = false;
            this.SaveGameBtn.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveGameBtn.Location = new System.Drawing.Point(11, 57);
            this.SaveGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveGameBtn.Name = "SaveGameBtn";
            this.SaveGameBtn.Size = new System.Drawing.Size(202, 36);
            this.SaveGameBtn.TabIndex = 13;
            this.SaveGameBtn.Text = "Save Game";
            this.SaveGameBtn.UseVisualStyleBackColor = true;
            this.SaveGameBtn.Click += new System.EventHandler(this.SaveTheGame);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadBtn.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadBtn.Location = new System.Drawing.Point(241, 57);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(202, 36);
            this.LoadBtn.TabIndex = 14;
            this.LoadBtn.Text = "Load Last Saved Game";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Game);
            // 
            // ResetGame
            // 
            this.ResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetGame.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetGame.Location = new System.Drawing.Point(472, 57);
            this.ResetGame.Margin = new System.Windows.Forms.Padding(2);
            this.ResetGame.Name = "ResetGame";
            this.ResetGame.Size = new System.Drawing.Size(202, 36);
            this.ResetGame.TabIndex = 15;
            this.ResetGame.Text = "Reset Game";
            this.ResetGame.UseVisualStyleBackColor = true;
            this.ResetGame.Click += new System.EventHandler(this.Reset_Game);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.RemoveFromArena);
            this.panel1.Controls.Add(this.add_to_arena);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxPokemon1);
            this.panel1.Location = new System.Drawing.Point(57, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 65);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.ResetGame);
            this.panel3.Controls.Add(this.LoadBtn);
            this.panel3.Controls.Add(this.SaveGameBtn);
            this.panel3.Controls.Add(this.comboBoxAttackPokimon);
            this.panel3.Controls.Add(this.attack_button);
            this.panel3.Controls.Add(this.current_turn_label);
            this.panel3.Location = new System.Drawing.Point(53, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 100);
            this.panel3.TabIndex = 18;
            // 
            // Label_Count_Pokemon_Arena
            // 
            this.Label_Count_Pokemon_Arena.AutoSize = true;
            this.Label_Count_Pokemon_Arena.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Count_Pokemon_Arena.Location = new System.Drawing.Point(106, 367);
            this.Label_Count_Pokemon_Arena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Count_Pokemon_Arena.Name = "Label_Count_Pokemon_Arena";
            this.Label_Count_Pokemon_Arena.Size = new System.Drawing.Size(535, 37);
            this.Label_Count_Pokemon_Arena.TabIndex = 0;
            this.Label_Count_Pokemon_Arena.Text = "There are currently 0 Pokemons in the arena";
            // 
            // StartBattleBtn
            // 
            this.StartBattleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBattleBtn.Enabled = false;
            this.StartBattleBtn.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBattleBtn.Location = new System.Drawing.Point(44, 80);
            this.StartBattleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartBattleBtn.Name = "StartBattleBtn";
            this.StartBattleBtn.Size = new System.Drawing.Size(708, 49);
            this.StartBattleBtn.TabIndex = 3;
            this.StartBattleBtn.Text = "Start Battle!";
            this.StartBattleBtn.UseVisualStyleBackColor = true;
            this.StartBattleBtn.Click += new System.EventHandler(this.StartBattle_btn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.Label_Count_Pokemon_Arena);
            this.Controls.Add(this.StartBattleBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label current_turn_label;
        private System.Windows.Forms.Button attack_button;
        private System.Windows.Forms.ComboBox comboBoxPokemon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button add_to_arena;
        private System.Windows.Forms.Button RemoveFromArena;
        private System.Windows.Forms.ComboBox comboBoxAttackPokimon;
        private System.Windows.Forms.Button SaveGameBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button ResetGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_Count_Pokemon_Arena;
        private System.Windows.Forms.Button StartBattleBtn;
    }
}

