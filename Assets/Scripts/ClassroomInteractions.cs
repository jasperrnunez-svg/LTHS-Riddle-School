using UnityEngine;

public class ClassroomInteractions : MonoBehaviour 
{ 
    private int counter = 0; 
    public float test;

    private void OnMouseDown() 
    { 
        if (counter < 1) 
        { 
            counter++; 
            Debug.Log("Mouse clicked on: " + gameObject.name); 
        } 
    } 
}
