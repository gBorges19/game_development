using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject prefabRock;

    [SerializeField]
    Sprite greenRockSprite;
    [SerializeField]
    Sprite magentaRockSprite;
    [SerializeField]
    Sprite whiteRockSprite;

    const float SpawnDelaySeconds = 1;
    Timer spawnTimer;

    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelaySeconds;
        spawnTimer.Run();
    }

    void Update()
    {

        if (spawnTimer.Finished && GameObject.FindGameObjectsWithTag("Rock").Length < 3)
        {
            SpawnRock();

            spawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = Vector3.zero;

        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = greenRockSprite;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = magentaRockSprite;
        }
        else
        {
            spriteRenderer.sprite = whiteRockSprite;
        }

    }
}