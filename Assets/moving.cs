using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;
using Lean.Touch;

  public class moving : MonoBehaviour
  {

    public int x, y;
    public string type;
    public Transform [,] Grid;

    // Use this for initialization
    void Start()
    {

    }

    protected virtual void OnEnable()
    {
        LeanTouch. OnFingerSwipe+=OnSwipe;
 
    }

    public  void OnSwipe(LeanFinger finger) {
      Debug.Log("CLICK CLICK !"+x+y+this);
      swapTiles(finger);

    }
    // Update is called once per frame
    void Update()
    {

    }
    public moving getPosition()
    {
      return this;
    }

    private void swapTiles(LeanFinger finger) {
    //this.transform;
      // get coord
      // get in array
      // swap with other from direction
      // left = 
    Debug.Log(finger);
    // droite

    Camera main = Camera.main;
    main.World
     
    
    if ( finger.LastSnapshotScaledDelta.x>0 ) {
    }
    if ( finger.LastSnapshotScaledDelta.x<0 )  {
    }
    //haut
    if ( finger.LastSnapshotScaledDelta.y>0 )  {
    }
    if ( finger.LastSnapshotScaledDelta.y<0 )    {
    }
    //if ( input.gettouch(0).deltaposition.x>0 )
    //{
    //  transform currenttmp = tile;
    //  moving currentmoving = tile.getcomponent<moving>( );
    //  grid [currentmoving.x, currentmoving.y]=grid [currentmoving.x+1, currentmoving.y];
    //  grid [currentmoving.x+1, currentmoving.y]=tile;


    //  debug.log("user is swiping to the right");
    //}

  }


  }
