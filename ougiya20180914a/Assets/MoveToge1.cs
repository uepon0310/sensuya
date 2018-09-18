using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToge1 : MonoBehaviour {


    public float MaxTogetogeX;
    public float MinTogetogeX;
    private int Direction = -1 ;
    public float Position;
    public GameObject Togetoge;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

 Vector3 tmp = Togetoge.transform.position;

        if (tmp.x >= MinTogetogeX)
        {
            Direction = Direction * -1;
        }
        if (tmp.x <= MaxTogetogeX)
        {
            Direction = Direction * -1;
        }
        this.gameObject.transform.Translate(0.05f * Direction, 0, 0);

        //        if (tmp.x >= MinTogetogeX)
        //        {
        //            this.gameObject.transform.Translate(0.05f * Direction, 0, 0);
        //            Direction = Direction * -1;
        //        }
    }
}
