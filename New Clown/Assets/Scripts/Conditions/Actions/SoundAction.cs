using System.Collections;
using UnityEngine;

[AddComponentMenu("Playground/Actions/Sound")]
public class SoundAction : Action
{
    public AudioSource objectToPlaySound;
    public enum Type { Play, Stop, PlayOneShot }
    public Type paramType;

    public AudioClip audioClip;
    [Range(0,1)]
    public float volume;

    public override bool ExecuteAction(GameObject dataObject)
    {
       AudioSource source;

        if (objectToPlaySound != null)
        {
            source = objectToPlaySound.GetComponent<AudioSource>();

            switch (paramType)
            {
                case Type.PlayOneShot:
                    source.PlayOneShot(audioClip, volume);
                    break;
                case Type.Play:
                    source.Play();
                    break;
                case Type.Stop:
                    if(source.isPlaying) source.Stop();
                    break;
            }

        }

        return true;
    }

}
