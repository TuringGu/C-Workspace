using System;

namespace MyFirstGame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Before the game start */

			// Define game parameters
			const int mapW = 46;    // Map weight
			const int mapH = 16;    // Map height

			// Define constant
			const int EmptyTiledMap = 0;    // Empty tiles
			const int TBTiledMap = 1;       // top and bottom tiles
			const int LRTiledMap = 2;       // left and right tiles
			const int Player = 3;           // Player


			// Initializing variable
			bool isOver = false;    // Weather game is over
			int[,] mapData = new int[mapH, mapW];       // Map data
			string[,] mapView = new string[mapH, mapW]; // Map view
			int posW = 1;   // Player in the W position
			int posH = 1;   // Player in the H position

			// Initializing map data
			for (int i = 0; i < mapH; i++)
			{
				for (int j = 0; j < mapW; j++)
				{
					// Initializing map as emtpy tiles
					mapData[i, j] = EmptyTiledMap;

					if (i == 0 || i == mapH - 1)
					{   // If tiles on the most top or bottom
						mapData[i, j] = TBTiledMap;

					}
					else if (j == 0 || j == mapW - 1)
					{   // If tiles on the most left or right
						mapData[i, j] = LRTiledMap;
					}
					else if(i == posW && j == posH)
					{   // Current position is player
						mapData[i, j] = Player;
					}
				}
			}


			//Game main loop
			while (!isOver)
			{
				/* When the game start */

				/* Computer computing date -> Converting data to view 
				* -> Display view -> Obtain player events 
				*/

				// Refresh the map
				for (int i = 0; i < mapH; i++)
				{
					for (int j = 0; j < mapW; j++)
					{
						// Obtian data from the map data to determine how to display
						// Getting tile's data
						int tileData = mapData[i, j];
						// Tile view
						string tileView = "";
						// Decide the tiles' display
						switch (tileData)
						{
						case EmptyTiledMap:
							// Empty tiles display blank
							tileView = " ";
							break;
						case TBTiledMap:
							// Top or Bottom tiles display -
							tileView = "-";
							break;
						case LRTiledMap:
							// Left or Right tiles display "
							tileView = "|";
							break;
						case Player:
							// Refresh player
							tileView = "P";
							break;
						}
						// Store tiles view into map view
						mapView[i, j] = tileView;
					}
					// Output the line information
				}

				// Clean the console
				Console.Clear();

				// Display map
				for (int i = 0; i < mapH; i++)
				{
					// Create a string using for receiving a line info.
					string str = "";
					for (int j = 0; j < mapW; j++)
					{
						// Stitching each character of each line into a string
						str += mapView[i, j];
					}
					// Print a line info.
					Console.WriteLine(str);
				}

				// Store player current position
				int oldposW = posW;
				int oldPosH = posH;

				// Waiting for usring input
				// Obtain user input key string
				string key = Console.ReadKey().KeyChar.ToString();
				if (key == "w" || key == "W")
				{   // Player moving up
					if(posH > 1)
					{
						posH--;
					}
				}
				else if(key == "s" || key == "S")
				{   // Player moving down
					if(posH < mapH - 2)
					{
						posH++;
					}
				}
				else if(key == "a" || key == "A")
				{   // Player moving left
					if(posW > 1)
					{
						posW--;
					}
				}
				else if(key == "d" || key == "D")
				{   // Player moving right
					if(posW < mapW - 2)
					{
						posW++;
					}
				}
				else if(key == "q" || key == "Q")
				{   // Press the "q" to quit the game
					isOver = true;
					continue;
				}

				// Update map data (and player data)
				// Moving the player from the old position
				mapData[oldPosH, oldposW] = EmptyTiledMap;
				// Adding the player into the new position
				mapData[posH, posW] = Player;

			}

			/* Before the game end */
			Console.WriteLine("Game over!");
				
		}
	}
}
