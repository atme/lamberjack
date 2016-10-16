using UnityEngine;
using System.Collections;

public class Food : CommonControl {
    
    private const int max = 3;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    public override void Create()
    {
        Instantiate(gameObject);
    }

    public override void Step() {

        if (level == max) {
            return;
        }

        if (level == 1 && HasSceneObject("Snow"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            level++;
        }
    }
}
