using UnityEngine;

public class SingletonTest : MonoBehaviour
{

    // 디자인 패턴 중 하나, 자주쓰임

    void Start()
    {
        SingletonTest.instance.PlayerSound();
    }

    // 자기 자신을 변수로 만들고, 어디서든 편하게 쓸 수 있게 함
    public static SingletonTest instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // 자기 참고 객체
        }
    }

    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드 테스트야");
    }

    public void EnemySound()
    {
        Debug.Log("적 사운드 테스트야");
    }

}
