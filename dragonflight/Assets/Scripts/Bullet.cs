using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0,moveSpeed*Time.deltaTime,0);

    }

    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // trigger 충돌일 경우 한번 실행
        // if(collision.gameObject.tag == "Enemy")
        
        if(collision.gameObject.CompareTag("Enemy"))
        {
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            Destroy(collision.gameObject);         
            Destroy(gameObject);         

            SoundManager.instance.SoundDie();

            GameManager.instance.AddScore(100);
               
        }
    }



}
