using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    /// <summary>
    /// The Player's movement speed
    /// </summary>
    [SerializeField]
    private float speed;

    /// <summary>
    /// The Player's direction
    /// </summary>
    protected Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    /// <summary>
    /// Moves the player
    /// </summary>
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
