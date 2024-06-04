using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class RandomPlayAudio : AudioPlayBase {
    public List<AudioClip> clips;
    public override void Play(AudioSource audioSource) {
        if(clips.Count == 0)
            return;
        audioSource.clip = clips[Random.Range(0,clips.Count)];
    }
}
