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
        _factory = requirements.Bad ? (ICharacterFactory)new TownspeopleFactory() : new TownspeopleFactory();
        _requirements = requirements;
    }

    public ICharacter Create()
    {
        return _factory.Create(_requirements);
    }
}

public class TownspeopleFactory : ICharacterFactory
{
    public ICharacter Create(CharacterRequirements requirements)
    {
        if(requirements.Bad && requirements.Good)
        {
            Debug.Log("Anti");
            return new AntiHero();
        }
        else if(requirements.Bad)
        {
            Debug.Log("Enemy");
            return new Enemy();
        }
        else if(requirements.Good)
        {
            Debug.Log("Good");
            return new Hero();
        }
        else
        {
            Debug.Log("Marsh");
            return new Marshmallow();
        }
    }
}
