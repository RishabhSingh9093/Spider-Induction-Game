using UnityEngine;
public class EnemyPatrol : MonoBehaviour
{
    public float speed=2f;
    public float Dist=3f; 
    private Vector3 start;
    void Start()
    {
        start=transform.position;
    }
    void Update()
    {
        float move=Mathf.PingPong(Time.time*speed,Dist);
        transform.position=start+Vector3.right*move;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth health=collision.gameObject.GetComponent<PlayerHealth>();
            if (health!=null)
            {
            health.TakeDamage(25);
            }
        }
    }
}
