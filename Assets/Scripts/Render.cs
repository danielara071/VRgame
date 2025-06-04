using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Cambia el color del objeto al colisionar
        objectRenderer.material.color = Color.red;
    }

    
    void OnCollisionExit(Collision collision)
    {
        objectRenderer.material.color = Color.white;
    }
}
