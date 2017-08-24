using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public int x, y;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // OnMouseDown();
        
		
	}

    void OnMouseDown() {
        Debug.Log("CLICK CLICK !"  +x+  y+ this);

    }

    
}
