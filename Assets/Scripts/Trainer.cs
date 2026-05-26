using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Trainer : MonoBehaviour
{
    public SpriteRenderer pokachu;
    public Camera gameCamera;
    public Color caughtColour;

public Hider creatureHider;



    public List<SpriteRenderer> uncaughtCreatures;
    public List<SpriteRenderer> caughtCreatures;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;

        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        if (isClicked)
        {
            //caughtCreatures
            //each element output to console
            //FIRST SECTION: Define and set the value of the iterator
            //SECOND SECTION: Define how long it will run
            //THIRD SECTION: Increase the value of i each time it loops
            for (int i = 0; i < caughtCreatures.Count; i++)


                Debug.Log(caughtCreatures[i]);

            if (caughtCreatures.Count > 0)
            {
                Debug.Log(caughtCreatures[0].name);
            }



            if (isClicked && pokachu.bounds.Contains(worldMousePosition))
            {
                pokachu.color = Color.darkBlue;

                bool isCreatureCaught = caughtCreatures.Contains(pokachu);
                if (!isCreatureCaught)
                {
                    creatureHider.Hide();


                    caughtCreatures.Add(pokachu);
                }

                uncaughtCreatures.Remove(pokachu);
            }
        }
    }
}