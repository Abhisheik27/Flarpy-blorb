using UnityEngine;

public class middleCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Logic_manager logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.Addscore(1);
        }
    }
}
