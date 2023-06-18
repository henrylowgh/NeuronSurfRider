using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharge : MonoBehaviour
{
    public Sprite negCharge;
    public Sprite posCharge;

    private GameObject player;
    private float playerX;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = negCharge;
        player = GameObject.Find("Player");
        playerX = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x < (playerX + 3.5)) && (transform.position.x > (playerX - 3.5)))
        {
            GetComponent<SpriteRenderer>().sprite = posCharge;
        }

        else
        {
            GetComponent<SpriteRenderer>().sprite = negCharge;
        }
    }
}
