using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if(Input.GetAxis("SpawnTeddyBear") > 0)
        {
            //only teddy bear on frame
            if(!spawnInputOnPreviousFrame)
            {
                //input flag
                spawnInputOnPreviousFrame = true;

                //instantiate position
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

                GameObject.Instantiate(prefabTeddyBear, mousePosition, Quaternion.identity);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }
        // explode teddy bear as appropriate
		if(Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;

                //find teddybear TAG
                GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
                if (teddyBear != null)
                {
                    Instantiate(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
	}
}
