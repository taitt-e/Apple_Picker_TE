using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    public static float bottomY = -20f;
    // Update is called once per frame
    void Update()
    {
        //Destroy branch if it reaches the bottom of the screen, no repurcussions.
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
