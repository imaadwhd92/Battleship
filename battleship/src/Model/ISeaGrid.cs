using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


/// <info>
/// The ISeaGrid defines the read only interface of a Grid. This
/// allows each player to see and attack their opponents grid.
/// </info>


public interface ISeaGrid
{
	
	int Width { get; }
	int Height { get; }

	/// <summary>
	/// Indicates that the grid has changed.
	/// </summary>

	event EventHandler Changed;

	/// <summary>
	/// Provides access to the given row/column
	/// </summary>
	/// <param name="row">the row to access</param>
	/// <param name="column">the column to access</param>
	/// <value>what the player can see at that location</value>
	/// <returns>what the player can see at that location</returns>

	TileView this[int row, int col] { get; }

	/// <summary>
	/// Mark the indicated tile as shot.
	/// </summary>
	/// <param name="row">the row of the tile</param>
	/// <param name="col">the column of the tile</param>
	/// <returns>the result of the attack</returns>

	AttackResult HitTile(int row, int col);
}




//=======================================================
//Converted using Telerik (www.telerik.com)
//Conversion powered by NRefactory.
// SWE20001 - Group 2- (Thursday 3.30-5.30)
// Team - Imaad, Bexultan, Malin, Chandima
//=======================================================