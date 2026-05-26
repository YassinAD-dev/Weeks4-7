using UnityEngine;

public class Hider : MonoBehaviour



{ public Vector3 hidepostion;


    public void Hide()
        {
        transform.position = hidepostion;
            }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
