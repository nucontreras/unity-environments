using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class Roomba : Agent
{
    public float Movespeed = 20;
    private Vector3 orig;
    //private Bounds bndFloor;  // I won't use this
    private GameObject Target = null;
    public override void Initialize()
    {
        orig = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        //Target = this.transform.parent.transform.Find("Target").GameObject;
    }
}
