using UnityEngine;

public class SpriteDestoryer : MonoBehaviour
{
    public GameObject Triangle1;
    public float timer = 0f;
    public bool TriangleDeath = false;
    public Transform spawnPoint;
    public GameObject Fakeangle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;

        if ( timer >=  3f&& TriangleDeath == true)
        {
            Instantiate(Triangle1, spawnPoint);
           

        }
        // used Debug.Log(timer); to test if the timer is working as intended (seconds)
    }
    public void kill()
    {
        Destroy(Fakeangle);

        TriangleDeath = true;

    }
   
}
