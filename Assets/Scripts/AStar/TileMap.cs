using UnityEngine;
using System.Collections;
//https://www.youtube.com/watch?v=0Q2z5g28ows
public class TileMap : MonoBehaviour {

	public TileType [] tileTypes;
	int[,] tiles;

	int mapSizeX = 10;
	int mapSizeY = 10;

	int valOfGrass = 0;
	int valOfSwamp = 1;
	int valOfMountain = 2;



	// Use this for initialization
	void Start () {
		tiles = new int[mapSizeX, mapSizeY];

		//initialize the array to grass
		for (int x = 0; x < mapSizeX; x++) {
			for(int y = 0; y < mapSizeY; y++){
				tiles[x,y] = 0;
			}
		}

		//U-shaped mountain range
		tiles [4, 4] = valOfMountain;
		tiles [4, 5] = valOfMountain;
		tiles [4, 6] = valOfMountain;

		tiles [5, 4] = valOfMountain;
		tiles [6, 4] = valOfMountain;
		tiles [7, 4] = valOfMountain;

		tiles [8, 4] = valOfMountain;
		tiles [8, 5] = valOfMountain;

		GenerateMapVisual ();
	}
	void GenerateMapVisual(){
		//spawn visual prefabs
		for (int x = 0; x < mapSizeX; x++) {
			for(int y = 0; y < mapSizeY; y++){
				//Debug.Log();
				TileType tt = tileTypes[ tiles[x,y] ];
				Instantiate(tt.tileVisualPrefab, new Vector3(x,y,0), Quaternion.identity);
			}
		}
	}

}
