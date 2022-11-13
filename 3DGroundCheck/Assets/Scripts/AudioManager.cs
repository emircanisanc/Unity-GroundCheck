using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip someAudioClip;

    public void PlaySomeAudio()
    {
        AudioSource.PlayClipAtPoint(someAudioClip, Vector3.zero);
    }
}
