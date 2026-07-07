using UnityEngine;
using UnityEngine.UI;

public class DoorOpener : MonoBehaviour
{
    // made a public slider as a Variable to be able to drag and drop it in unity
    public Slider slider;
    // giving both game objects labels to be able easily manage them in coding with the objects
    public GameObject door1;
    public GameObject door2;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    //  made the function so it can be used in the slider's on value change
    public void openDoor()
    // using the named game object variable with the transform.euler angles to be able to rotate them and using new Vector3 to be able to specify the (X,Y,Z)
    {  // the slider.value is the equivlent to the current value of the slider
        door1.transform.eulerAngles = new Vector3(0f, slider.value,0f );
        door2.transform.eulerAngles = new Vector3(0f, -slider.value,0f );
    
    
    }
}
