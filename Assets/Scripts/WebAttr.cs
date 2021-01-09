using UnityEngine;

public class WebAttr : MonoBehaviour
{
    public float disapperTime;
    public int damage;
    private System.Random random = new System.Random();

    void Start()
    {
        Destroy(gameObject, disapperTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        {
            var rd = random.Next(0, 10);
            if (rd > 7)
            {
                collision.SendMessage("TakeDamage", damage);
            }
        }
    }
}
