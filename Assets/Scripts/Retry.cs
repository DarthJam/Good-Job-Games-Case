using UnityEngine;
using UnityEngine.SceneManagement;

namespace ColorHoleClone
{
    public class Retry : MonoBehaviour
    {
        public void RetryLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}