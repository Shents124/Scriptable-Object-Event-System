using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
    public UnityEvent dameEnemy;
    
    void Update()
    {
        transform.Translate(Vector3.up * 30 * Time.deltaTime);

        if (transform.position.y >= 6)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<Enemy>().TakeDame();
        dameEnemy.Invoke();
    }
}
