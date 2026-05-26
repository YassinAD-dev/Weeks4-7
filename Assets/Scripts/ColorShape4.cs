using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ColorShape4 : MonoBehaviour
{

    public SpriteRenderer colory;
    public Camera gameCamera;

    public float timeSinceWeStarted = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceWeStarted += Time.deltaTime;

        if (timeSinceWeStarted > 1f)
        {
            colory.color = Random.ColorHSV();
            timeSinceWeStarted = 0;
        }
       
           
        
        
    }
}
