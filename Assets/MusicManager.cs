using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Este objeto no se destruirá al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Elimina duplicados
        }
    }
}
