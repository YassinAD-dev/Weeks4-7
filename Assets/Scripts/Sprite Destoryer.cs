using UnityEngine;

public class SpriteDestoryer : MonoBehaviour
{ 
    // it is the triangle prefab itself
    public GameObject Triangle1;
    // it is the prefab clone
    public GameObject destroyMe;
    // how much time it has exsited since it was destroyed
    public float timer = 0f;
    // it is the boolean to check if the prefab is dead or alive 
    public bool TriangleDeath = false;
    // the location of where the prefab spawns
    public Transform spawnPoint;
    // so it can call out the prefab clones
    public GameObject Fakeangle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate makes it so it spawns at a certain location
        destroyMe = Instantiate(Triangle1, spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {// it would respawn the object after 3 seconds when its destroyed
      timer += Time.deltaTime;

        if ( timer >=  3f&& TriangleDeath == true)
        { 
            destroyMe = Instantiate(Triangle1, spawnPoint);
           
            TriangleDeath = false;
        }
        // used Debug.Log(timer); to test if the timer is working as intended (seconds)
    }
    //resets the timer when the object is destroyed
    public void kill()
    {
        Destroy(destroyMe);
        timer = 0f;
        TriangleDeath = true;

    }
   
}
