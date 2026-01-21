using System.Collections;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChangeText());
    }

    // 코루틴 쓸때 이건 외워야함
    IEnumerator ChangeText()
    {
        Debug.Log("준비");
        yield return new WaitForSeconds(1f);
        Debug.Log("시작");
        yield return new WaitForSeconds(1f);
        Debug.Log("끝");
    }

}
