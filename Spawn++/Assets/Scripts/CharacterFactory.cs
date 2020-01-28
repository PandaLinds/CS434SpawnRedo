using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterFactory
{
    ICharacter Create(CharacterRequirements requirements);
}

public class CharacterFactory // : AbstractVehicleFactory
{
    private readonly ICharacterFactory _factory;
    private readonly CharacterRequirements _requirements;

    public CharacterFactory(CharacterRequirements requirements)
    {
        _factory = requirements.Human ? (requirements.Evil ? (ICharacterFactory)new EvilFactory() : new HeroFactory()) : (requirements.Evil ? (ICharacterFactory)new BadAnimalFactory() : new GoodAnimalFactory());
        _requirements = requirements;
    }

    public ICharacter Create()
    {
        return _factory.Create(_requirements);
    }
}

public class HeroFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirements requirements)
    {
        if (requirements.Unique)
        {
            return new Superman();
        }
        else
        {
            return new Hero();
        }
    }
}

public class EvilFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirements requirements)
    {
        if (requirements.Unique)
        {
            return new Vampire();
        }
        else
        {
            return new Enemy();
        }
    }
}

public class BadAnimalFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirements requirements)
    {
        if (requirements.Unique)
        {
            return new Dragon();
        }
        else
        {
            return new Wolf();
        }
    }
}

public class GoodAnimalFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirements requirements)
    {
        if (requirements.Unique)
        {
            return new Marshmallow();
        }
        else
        {
            return new Cow();
        }
    }
}

