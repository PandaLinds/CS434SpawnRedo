using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour, ICharacter
{
    string newVoice;
    Body(ICharacter newBeing)
    {
        newVoice = newBeing.Speak();
    }

    public string Speak()
    {
        string voice = newVoice;
        Debug.Log(voice);
        return voice;
    }
    // Start is called before the first frame update
    void Start()
    {
        Speak();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
