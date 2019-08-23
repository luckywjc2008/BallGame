﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tag_Hole")
        {
            Destroy(this.gameObject,0.5f);
        }
    }

}
