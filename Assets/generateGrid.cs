using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class generateGrid : MonoBehaviour {

    public Transform bricks;
    public Sprite[] colors;
    public int width;
    private Transform[,] Grid;
    // private int xTile, yTile;
    public Gridmanager gridmanager;

    // Use this for initialization
    void Start () {
        Grid = new Transform[width, width];
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < width; y++) {
                Transform item = Instantiate(bricks);
                SpriteRenderer sprite = item.GetComponent<SpriteRenderer>();
                float sizeX = sprite.bounds.size.x;
                float xCoordinate = bricks.localPosition.x + (sizeX * (x ));
               
                float size = sprite.bounds.size.y;
                sprite.sprite = colors[Random.Range(0, colors.Length)];
               
                item.localPosition = new Vector3(xCoordinate, -(bricks.localPosition.y + (size * (y ))) , 1);
                moving movingClass = item.GetComponent<moving>();
                movingClass.type = sprite.sprite.name;
                movingClass.x = x;
                movingClass.y = y;
                Grid[x, y] = item;
            }
        }
        gridmanager.setGrid(Grid);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Transform[,] GetGrid() {
        return Grid;
    }

}
