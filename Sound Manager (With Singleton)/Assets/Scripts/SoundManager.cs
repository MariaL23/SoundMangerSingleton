using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

 public static SoundManager Instance; 

 [SerializeField] private AudioSource _happySource, _sadSource, _angrySource;

 void Awake() {


 }

 public void PlaySound(AudioClip clip)
{
    _happySource.PlayOneShot(clip);
}
 
 
}