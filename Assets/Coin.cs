using UnityEngine;

public class Coin : MonoBehaviour
{
    public float value = 1;
    public void Collect()
    {
        Resource.Find("gold").Change(value);
        Destroy(gameObject);
    }
}