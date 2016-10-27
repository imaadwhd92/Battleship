using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// The different AI levels.
/// </summary>


public enum AIOption
{
	/// <summary>
	/// Easy, total random shooting
	/// </summary>
	Easy,

	/// <summary>
	/// Medium, marks squares around hits
	/// </summary>
	Medium,

	/// <summary>
	/// As medium, but removes shots once it misses
	/// </summary>
	Hard
}

//=======================================================
//Converted using Telerik (www.telerik.com)
//Conversion powered by NRefactory.
// SWE20001 - Group 2- (Thursday 3.30-5.30)
// Team - Imaad, Bexultan, Malin, Chandima
//=======================================================