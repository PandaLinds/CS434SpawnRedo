using UnityEngine;

public interface ICharacter
{
    void Speak();
}


public class Hero : ICharacter
{
    public void Speak()
    {
        Debug.Log("Hero");
    }
}

public class Superman : ICharacter
{
    public void Speak()
    {
        Debug.Log("Superman");
    }
}

public class Enemy : ICharacter
{
    public void Speak()
    {
        Debug.Log("Enemy");
    }
}

public class Marshmallow : ICharacter
{
    public void Speak()
    {
        Debug.Log("Marshmallow");
    }
}

public class Wolf : ICharacter
{
    public void Speak()
    {
        Debug.Log("Dog");
    }
}

public class Dragon : ICharacter
{
    public void Speak()
    {
        Debug.Log("Dragon");
    }
}

public class Vampire : ICharacter
{
    public void Speak()
    {
        Debug.Log("Vampire");
    }
}

public class Cow : ICharacter
{
    public void Speak()
    {
        Debug.Log("Cow");
    }
}