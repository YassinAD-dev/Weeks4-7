using UnityEngine;

public class SpriteDestoryer : MonoBehaviour
{
    public GameObject Triangle1;
    public GameObject destroyMe;
    public float timer = 0f;
    public bool TriangleDeath = false;
    public Transform spawnPoint;
    public GameObject Fakeangle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroyMe = Instantiate(Triangle1, spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;

        if ( timer >=  3f&& TriangleDeath == true)
        {
            destroyMe = Instantiate(Triangle1, spawnPoint);
           
            TriangleDeath = false;
        }
        // used Debug.Log(timer); to test if the timer is working as intended (seconds)
    }
    public void kill()
    {
        Destroy(destroyMe);
        timer = 0f;
        TriangleDeath = true;

    }
   
}
