using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private Health playerHealth;
    [SerializeField] private float damage;

        void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<Health>();
        playerHealth.TakeDamage(damage);
    }
}
