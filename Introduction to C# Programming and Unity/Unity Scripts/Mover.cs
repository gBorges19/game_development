using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Moves the game object
/// </summary>
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        //Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        //rb2d.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);

        GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
    }

}