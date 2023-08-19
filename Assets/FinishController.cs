using System.Collections;
using System.Collections.Generic;
using Players;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public GameObject finishLine;
    public GameObject[] spawners;
    private PlayerManager pm;
    private bool isOver = false;
    
    void Start()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerManager>();
    }

    void Update()
    {
        if (pm.currentHomeNum == pm.aimHomeNum && !isOver)
        {
            isOver = !isOver;
            foreach (var spawner in spawners)
            {
                spawner.SetActive(false);
            }
            Instantiate(finishLine, new Vector3(transform.position.x + 2, finishLine.transform.position.y, 1),
                Quaternion.identity);
        }
    }
}
