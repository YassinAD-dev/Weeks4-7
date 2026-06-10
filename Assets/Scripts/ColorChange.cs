using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {  // getting the component from the tirangle
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // giving it as public makes so it can be shown in the button when giving an on click function
    public void ChangeToRandomColor()
    { // makes it so the sprite renderer so it can swittch and using new color and random.value so it changes the RGB
        spriteRenderer.color = new Color(Random.value, Random.value, Random.value);

      // make sure that the scrpit is given to the object that you want it to change color when the button is clicked. (note this code can almost be used f
    }
}
