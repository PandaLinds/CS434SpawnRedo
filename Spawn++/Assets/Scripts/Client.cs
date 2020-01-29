using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public bool Human;
    public bool Evil;
    public bool Unique;
    public Body genBody;
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
            //IVehicle v = GetVehicle(requirements);
            CharacterFactory factory = new CharacterFactory(requirements);
            ICharacter v = factory.Create();
            genBody.Body(v);
            Debug.Log(v);
        }
    }
}
