using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    
    
  

    // Update is called once per frame
    protected override void Update()
    {
        //Executes the GetInput function
        GetInput();
        base.Update();
        
    }
    /// <summary>
    /// Listen's to the players input
    /// </summary>
    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
    }

}
