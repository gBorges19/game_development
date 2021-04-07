using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 5, 3), ForceMode2D.Impulse);
    }

}
