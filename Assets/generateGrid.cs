using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateGrid : MonoBehaviour {

    public Transform bricks;
    public Sprite[] colors;
    public int width;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < width; j++) {
                Transform item = Instantiate(bricks);
                SpriteRenderer sprite = item.GetComponent<SpriteRenderer>();
                float sizeX = sprite.bounds.size.x;
                float x = bricks.localPosition.x + (sizeX * (i ));
               
                float size = sprite.bounds.size.y;
                sprite.sprite = colors[Random.Range(0, colors.Length)];
                item.localPosition = new Vector2(x, -(bricks.localPosition.y + (size * (j ))));
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
