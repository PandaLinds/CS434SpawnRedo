using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour, ICopyable
{

    public ICopyable Copy()
    {
        return Instantiate(this);
    }
}
