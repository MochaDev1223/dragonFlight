using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // 미사일 프리팹

    void Start()
    {
        //InvokeRepeating("함수 이름", 초기지연시간, 지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 0.7f);

    }

    void Shoot()
    {
        // 미사일 프리팹, 런처포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);

        // 싱글톤 사운드
        SoundManager.instance.SoundBullet();
    }

}
