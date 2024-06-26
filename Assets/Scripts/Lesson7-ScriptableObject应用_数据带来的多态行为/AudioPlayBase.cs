using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AudioPlayBase : ScriptableObject
{
    public abstract void Play(AudioSource audioSource);
}
