using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance; // 싱글톤 변수
    AudioSource myAudio; // AudioSource 컴포넌트 변수

    public AudioClip soundBullet;
    public AudioClip soundDie;

    void Start()
    {
        myAudio = GetComponent<AudioSource>(); // AudioSource 컴포넌트 가져오기
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
