using UnityEngine;

public class CollisionAndTriggerExample : MonoBehaviour
{
    // 衝突時のイベントメソッド
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
        // 衝突したオブジェクトの色を変える
        collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay: " + collision.gameObject.name);
        // 衝突している間、オブジェクトの色を青に変える
        collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit: " + collision.gameObject.name);
        // 衝突が終わったらオブジェクトの色を元に戻す
        collision.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    // トリガー時のイベントメソッド
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + other.gameObject.name);
        // トリガーに入ったオブジェクトの色を緑に変える
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay: " + other.gameObject.name);
        // トリガーに入っている間、オブジェクトの色を黄色に変える
        other.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit: " + other.gameObject.name);
        // トリガーから出たらオブジェクトの色を元に戻す
        other.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}