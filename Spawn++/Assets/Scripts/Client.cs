using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public bool Human;
    public bool Evil;
    public bool Unique;

    // public SpawnBody mSpawner;
    // private Body mBody;
    CharacterRequirements requirements = new CharacterRequirements();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        requirements.Human = Human;
        requirements.Evil = Evil;
        requirements.Unique = Unique;
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterFactory factory = new CharacterFactory(requirements);
            ICharacter v = factory.Create();
            Debug.Log(v);
            v.addSound();
            // mBody = mSpawner.SpawnNewBody();
            // mBody.transform.Translate(Vector3.forward * 1.5f);
            Debug.Log("after spawn");
        }
    }

    
}
