using UnityEngine;

public class GetCombonetrotator : MonoBehaviour
{
   // To get the transform of the prefab
    private Transform Rotatory;
    // so the sprite render can be called to change colors
    private SpriteRenderer DiffrentColorYay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    { // the Get Component is mainly used to be able to call out the specific component, like Transform and Sprite Renderer.
        Rotatory = GetComponent<Transform>();

        DiffrentColorYay = GetComponent<SpriteRenderer>();
        // makes it so the sprite color woul be blueViolet
        DiffrentColorYay.color = Color.blueViolet;

    }

    // Update is called once per frame
    void Update()
    {// makes it so the object would rotate 180 in the z axis and using Time.delta time to keep spinning while being as similar as possible to diffrent hardwares.
        Rotatory.transform.eulerAngles += new Vector3(0, 0, 180f * Time.deltaTime);
    }
   
}
