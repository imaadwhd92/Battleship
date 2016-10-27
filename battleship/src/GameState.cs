using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


/// <Info>
/// The GameStates represent the state of the Battleships game play and controll the actoins.
/// </Info>

public enum GameState
{
	/// <summary>
	/// The player is viewing the main menu.
	/// </summary>
	ViewingMainMenu,

	/// <summary>
	/// The player is viewing the game menu
	/// </summary>
	ViewingGameMenu,

	/// <summary>
	/// The player is looking at the high scores
	/// </summary>
	ViewingHighScores,

	/// <summary>
	/// The player is altering the game settings
	/// </summary>
	AlteringSettings,

	/// <summary>
	/// Players are deploying their ships
	/// </summary>
	Deploying,

	/// <summary>
	/// Players are attempting to locate each others ships
	/// </summary>
	Discovering,

	/// <summary>
	/// One player has won, showing the victory screen
	/// </summary>
	EndingGame,

	/// <summary>
	/// The player has quit. Show ending credits and terminate the game
	/// </summary>
	Quitting
}



//=======================================================
//Converted using Telerik (www.telerik.com)
//Conversion powered by NRefactory.
// SWE20001 - Group 2- (Thursday 3.30-5.30)
// Team - Imaad, Bexultan, Malin, Chandima
//=======================================================