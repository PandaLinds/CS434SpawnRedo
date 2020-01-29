using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBody : MonoBehaviour
{
    public ICopyable mCopy;
    private Body newBod;
    public Body SpawnNewBody()
    {
        mCopy = newBod.Copy();
        return (Body)mCopy;
    }
}
