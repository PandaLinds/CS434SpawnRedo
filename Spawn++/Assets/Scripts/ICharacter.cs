using UnityEngine;

public interface ICharacter
{
    void Speak();
}

public class AntiHero : ICharacter
{
    public void Speak()
    {
        Debug.Log("AntiHero");
    }
}

public class Hero : ICharacter
{
    public void Speak()
    {
        Debug.Log("Hero");
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