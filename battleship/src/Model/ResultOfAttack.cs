using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


/// <Info>
/// This file contains detalis when an Attack is conducted
/// </Info>



public enum ResultOfAttack
{
	/// <summary>
	/// The player hit something
	/// </summary>
	Hit,

	/// <summary>
	/// The player missed
	/// </summary>
	Miss,

	/// <summary>
	/// The player destroyed a ship
	/// </summary>
	Destroyed,

	/// <summary>
	/// That location was already shot.
	/// </summary>
	ShotAlready,

	/// <summary>
	/// The player killed all of the opponents ships
	/// </summary>
	GameOver
}

//=======================================================
//Converted using Telerik (www.telerik.com)
//Conversion powered by NRefactory.
// SWE20001 - Group 2- (Thursday 3.30-5.30)
// Team - Imaad, Bexultan, Malin, Chandima
//=======================================================