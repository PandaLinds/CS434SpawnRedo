using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public bool Good;
    public bool Bad;
    CharacterRequirements requirements = new CharacterRequirements();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        requirements.Good = Good;
        requirements.Bad = Bad;
        if (Input.GetKeyDown(KeyCode.A))
        {
            //IVehicle v = GetVehicle(requirements);
            CharacterFactory factory = new CharacterFactory(requirements);
            ICharacter v = factory.Create();
            Debug.Log(v);
        }
    }
}
