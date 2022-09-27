using UnityEngine;
using UnityEngine.UI;

public class Bloody : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
