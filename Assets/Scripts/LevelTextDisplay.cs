using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace ColorHoleClone
{
    public class LevelTextDisplay : MonoBehaviour
    {
        [SerializeField] private int sceneOffset;
        [SerializeField] private TextMeshProUGUI levelText;

        // Start is called before the first frame update
        void Awake()
        {
            levelText.text = (SceneManager.GetActiveScene().buildIndex + sceneOffset).ToString();
        }
    }
}