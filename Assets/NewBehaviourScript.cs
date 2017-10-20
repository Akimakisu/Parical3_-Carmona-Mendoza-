using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float time;
    int i;

    // Use this for initialization
    public Patrullar(float viewDistance, float wait, GameObject waypoints) : base(viewDistance, wait, waypoints)
        { }

    
    void Start () {
        time = wait;
	}
	
	// Update is called once per frame
	public override ExcecuteProfile() {

        Moverse();
	}
    public void Moverse() {

        if (time >= 1)
        {
            if (i < route.transform.childCount) 
            {
                this.transform.position = new Vector3(route.transform.GetChild(i).transform.position.x, route.transform.GetChild(i).transform.position.y, route.transform.GetChild(i).transform.position.z);
                        
                if (i == route.transform.childCount - 1) 
                {
                    i = 0; 
                }
                else 
                {
                    i++;
                }

            }
            time = 0; 
        }
        else
        {
            time += Time.deltaTime;
        }

    }
}
