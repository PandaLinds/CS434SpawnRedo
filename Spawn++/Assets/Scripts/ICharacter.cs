using UnityEngine;

public interface ICharacter
{
    string Speak();
}


public class Hero : ICharacter
{
    public string Speak()
    {
        string voice = "Hero";
        Debug.Log(voice);
        return voice;
    }
}

public class Superman : ICharacter
{
    public string Speak()
    {
        string voice = "Superman";
        Debug.Log(voice);
        return voice;
    }
}

public class Enemy : ICharacter
{
    public string Speak()
    {
        string voice = "Enemy";
        Debug.Log(voice);
        return voice;
    }
}

public class Marshmallow : ICharacter
{
    public string Speak()
    {
        string voice = "Marshmallow";
        Debug.Log(voice);
        return voice;
    }
}

public class Wolf : ICharacter
{
    public string Speak()
    {
        string voice = "Wolf";
        Debug.Log(voice);
        return voice;
    }
}

public class Dragon : ICharacter
{
    public string Speak()
    {
        string voice = "Dragon";
        Debug.Log(voice);
        return voice;
    }
}

public class Vampire : ICharacter
{
    public string Speak()
    {
        string voice = "Vampire";
        Debug.Log(voice);
        return voice;
    }
}

public class Cow : ICharacter
{
    public string Speak()
    {
        string voice = "Cow";
        Debug.Log(voice);
        return voice;
    }
}