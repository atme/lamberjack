using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class CommonControl : MonoBehaviour {

    protected int level;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void Click()
    {
        level = 1;

        Create();
        StepObjects();

        turnButtonOff();
    }

    private void turnButtonOff()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
    }

    private void StepObjects()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            item.GetComponent<CommonControl>().Step();
        }
    }

    protected bool HasSceneObject(string Name)
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            if (Name + "(Clone)" == item.name) {
                return true;
            }
        }
        return false;
    }

    abstract public void Step();
    abstract public void Create();
}
