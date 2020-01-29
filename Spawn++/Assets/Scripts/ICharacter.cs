using UnityEngine;

public interface ICharacter
{
    void Speak();
    void addSound();
}


public class Hero : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/leroy.swf") as AudioClip;
        audioSource.Play();
    }

    public void Speak()
    {
        string voice = "Hero";
        Debug.Log(voice);
    }
}

public class Superman : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/Superman") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Superman";
        Debug.Log(voice);
    }
}

public class Enemy : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/EvilLaugh") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Enemy";
        Debug.Log(voice);
    }
}

public class Marshmallow : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/Jump") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Marshmallow";
        Debug.Log(voice);
    }
}

public class Wolf : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/Wolf") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Wolf";
        Debug.Log(voice);
    }
}

public class Dragon : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/Dragon") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Dragon";
        Debug.Log(voice);
    }
}

public class Vampire : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/Vamp") as AudioClip;
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Vampire";
        Debug.Log(voice);
    }
}

public class Cow : ICharacter
{
    public GameObject SoundObject;
    public void addSound()
    {
        SoundObject = GameObject.Find("Sound");
        AudioSource audioSource = SoundObject.GetComponent<AudioSource>();
        audioSource.clip = Resources.Load("Audio/Cow") as AudioClip;
        Debug.Log(audioSource.clip);
        audioSource.Play();
    }
    public void Speak()
    {
        string voice = "Cow";
        Debug.Log(voice);
    }
}