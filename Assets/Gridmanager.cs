using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmanager : MonoBehaviour {
    public Transform [,] Grid;

    // Use this for initialization
    void Start () {
		
	}

    public Transform[,] getGrid() {
        return Grid;
    }

    public void setGrid(Transform [,] newGrid) {
        Grid = newGrid;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
