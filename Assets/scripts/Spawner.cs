using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class Spawner : MonoBehaviour
{
    public GameObject towerPrefab;

    // Bereik waarin de torens willekeurig worden geplaatst (pas aan in de Inspector)
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -4f;
    public float maxY = 4f;

    void Update()
    {
        if (MuisGeklikt())
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);

            Instantiate(towerPrefab, new Vector3(x, y, 0f), Quaternion.identity);
        }
    }

    bool MuisGeklikt()
    {
#if ENABLE_INPUT_SYSTEM
        return Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame;
#else
        return Input.GetMouseButtonDown(0);
#endif
    }
}