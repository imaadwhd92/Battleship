using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;

/// <summary>
/// The battle phase is handled by the DiscoveryController.
/// <summary>




/// <Info>
/// The battle phase is handled by the DiscoveryController.
/// </Info>
static class DiscoveryController
{

	/// <summary>
	/// Handles input during the discovery phase of the game.
	/// </summary>


	public static void HandleDiscoveryInput()
	{

		if (SwinGame.KeyTyped(KeyCode.vk_ESCAPE)) 


		if (SwinGame.KeyTyped(KeyCode.vk_ESCAPE)) {

			GameController.AddNewState(GameState.ViewingGameMenu);
		}

		if (SwinGame.MouseClicked(MouseButton.LeftButton))
		{
			DoAttack();
		}
		if (UtilityFunctions.IsMouseInRectangle ((SwinGame.ScreenWidth () / 2), 94, 80, 15) && SwinGame.MouseClicked (MouseButton.LeftButton))
		{
			GameController.StartGame();
		}
		if (UtilityFunctions.IsMouseInRectangle((SwinGame.ScreenWidth()/2)+ 300, 94, 75, 15) && SwinGame.MouseClicked(MouseButton.LeftButton))
		{
			GameController.AddNewState(GameState.ViewingMainMenu);
		}
		if (UtilityFunctions.IsMouseInRectangle((SwinGame.ScreenWidth () / 2) + 120, 380, 75, 15) && SwinGame.MouseClicked(MouseButton.LeftButton)) {
			GameController.AddNewState(GameState.ViewingMainMenu);
		}

	}

	/// <summary>
	/// Attack the location that the mouse if over.
	/// </summary>




	private static void DoAttack()
	{
		Point2D mouse = default(Point2D);

		mouse = SwinGame.MousePosition();

		//Below Section calculates the row/col clicked


		int row = 0;
		int col = 0;
		row = Convert.ToInt32(Math.Floor((mouse.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
		col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

		if (row >= 0 & row < GameController.HumanPlayer.EnemyGrid.Height) {
			if (col >= 0 & col < GameController.HumanPlayer.EnemyGrid.Width) {
				GameController.Attack(row, col);
			}
		}
	}

	/// <summary>
	///  This section Draws the game during the attack phase.
	/// </summary>



	public static void DrawDiscovery()
	{
		const int SCORES_LEFT = 172;
		const int SHOTS_TOP = 157;
		const int HITS_TOP = 206;
		const int SPLASH_TOP = 256;


		if ((SwinGame.KeyDown (KeyCode.vk_LSHIFT) | SwinGame.KeyDown (KeyCode.vk_RSHIFT)) & SwinGame.KeyDown (KeyCode.vk_c))
		{

			UtilityFunctions.DrawField (GameController.HumanPlayer.EnemyGrid, GameController.ComputerPlayer, true);
		}
		else
		{
		

			if ((SwinGame.KeyDown (KeyCode.vk_LSHIFT) | SwinGame.KeyDown (KeyCode.vk_RSHIFT)) & SwinGame.KeyDown (KeyCode.vk_c))
			{
				UtilityFunctions.DrawField (GameController.HumanPlayer.EnemyGrid, GameController.ComputerPlayer, true);
			}
			else
			{
				UtilityFunctions.DrawField (GameController.HumanPlayer.EnemyGrid, GameController.ComputerPlayer, false);
			}

			UtilityFunctions.DrawSmallField (GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);
			UtilityFunctions.DrawMessage ();

			SwinGame.DrawText (GameController.HumanPlayer.Shots.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, SHOTS_TOP);
			SwinGame.DrawText (GameController.HumanPlayer.Hits.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, HITS_TOP);
			SwinGame.DrawText (GameController.HumanPlayer.Missed.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, SPLASH_TOP);
			SwinGame.DrawTextLines ("Main Menu", Color.Black, Color.White, GameResources.GameFont ("Menu"), FontAlignment.AlignCenter, (SwinGame.ScreenWidth () / 2) + 300, 94, 75, 15);
			SwinGame.DrawTextLines("REPLAY", Color.Black, Color.White, GameResources.GameFont("Menu"), FontAlignment.AlignCenter, (SwinGame.ScreenWidth()/2), 94, 75, 15);


			SwinGame.DrawText (GameController.HumanPlayer.Shots.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, SHOTS_TOP);
			SwinGame.DrawText (GameController.HumanPlayer.Hits.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, HITS_TOP);
			SwinGame.DrawText (GameController.HumanPlayer.Missed.ToString (), Color.White, GameResources.GameFont ("Menu"), SCORES_LEFT, SPLASH_TOP);

		}
	}
}




//=======================================================
//Converted using Telerik (www.telerik.com)
//Conversion powered by NRefactory.
// SWE20001 - Group 2- (Thursday 3.30-5.30)
// Team - Imaad, Bexultan, Malin, Chandima
//=======================================================