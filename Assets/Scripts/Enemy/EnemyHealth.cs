using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 1;
    [SerializeField] private GameObject _explosionPrefab, _destroyPrint;
    public void TakeDamage(int damageValue)
    {
        _health -= damageValue;
        if(_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(_explosionPrefab, transform.position, transform.rotation);
        Instantiate(_destroyPrint, transform.position, _destroyPrint.transform.rotation);
        Destroy(gameObject);
    }
}
