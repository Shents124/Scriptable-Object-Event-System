using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public UnityEvent enemyDead;
    
    private int health = 10;

    public void TakeDame()
    {
        health--;
        if (health <= 0)
        {
            enemyDead.Invoke();
            Destroy(this.gameObject);
        }
    }
}
