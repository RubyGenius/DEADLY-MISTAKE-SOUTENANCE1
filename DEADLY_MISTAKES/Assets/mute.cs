using UnityEngine;
using System.Collections;

public class mute : MonoBehaviour {

    public GameObject music;

    public void mute_play() {
        if (this.music.audio.isPlaying)
            this.music.audio.Pause();
        else
            this.music.audio.Play();
    }
}
