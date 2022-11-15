using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject success;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            success.SetActive(true);
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
