using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmanager : MonoBehaviour {
    public Transform [,] Grid;

    // Use this for initialization
    void Start () {
		
	}

    public Transform[,] getGrid() {
        return this.Grid;
    }

    public void setGrid(Transform [,] newGrid) {
       this. Grid = newGrid;
    }

  public void moveRight(Transform tile) {
        Transform tmp=tile;
        Vector3 tmpLocalPosition = tile.localPosition;
        moving currentmoving = tile.GetComponent<moving>( );
        Debug.Log(Grid);
        Debug.Log(Grid [currentmoving.x, currentmoving.y]);
        if ( currentmoving.x<4 )
        {
            Debug.Log(Grid [currentmoving.x+1, currentmoving.y].localPosition);
            Debug.Log(tmpLocalPosition);
            Grid [currentmoving.x, currentmoving.y].localPosition=Grid [currentmoving.x+1, currentmoving.y].localPosition;
            Grid [currentmoving.x, currentmoving.y]=Grid [currentmoving.x+1, currentmoving.y];

            Grid [currentmoving.x+1, currentmoving.y].localPosition=tmpLocalPosition;
            Instantiate(Grid [currentmoving.x+1, currentmoving.y]);
            Destroy(tile.GetComponent<GameObject>());
            // tmps is ref to tile.
            // We change tile and tmp. \
            // Need to clone game object and destruct previous one
            Grid [currentmoving.x+1, currentmoving.y]=tmp;
            Debug.Log(Grid [currentmoving.x+1, currentmoving.y].localPosition);
            Debug.Log(tmpLocalPosition);

          
            
        }
  }
	// Update is called once per frame
	void Update () {
		
	}
}
