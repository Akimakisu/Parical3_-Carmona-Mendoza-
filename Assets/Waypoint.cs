using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

    private Transform[] waypoints;
	// Use this for initialization
	void Start () {
        waypoints = new transform[transform.childCount];
        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = transform.GetChild(i);
        }
	}

    public Transform[] Waypointsitos
    {
        get
        {
            return waypoints;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
