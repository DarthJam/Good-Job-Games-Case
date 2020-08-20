using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RoboRyanTron.Unite2017.Sets;
using RoboRyanTron.Unite2017.Events;

namespace ColorHoleClone
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] List<ThingRuntimeSet> Sets;
        private int currentSet;

        bool haveWon;

        [Space]
        [SerializeField] GameEvent PassLevelEvent;
        [SerializeField] GameEvent PassStageEvent;

        private void Awake()
        {
            currentSet = 0;
        }

        private void Update()
        {
            if (Sets[currentSet].Items.Count <= 0)
            {
                CheckWin();
            }
        }

        public void CheckWin()
        {
            if (currentSet != Sets.Count - 1)
            {
                currentSet++;
                PassStageEvent.Raise();
            }
            else
            {
                if (!haveWon)
                {
                    haveWon = true;
                    PassLevelEvent.Raise();
                }
            }
        }

        public void Win()
        {
            StartCoroutine(LoadNextScene());
        }

        private IEnumerator LoadNextScene()
        {
            // waiting for particleFX to finish
            yield return new WaitForSeconds(1f);

            if (SceneManager.sceneCountInBuildSettings != SceneManager.GetActiveScene().buildIndex + 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                print("end of the line");
            }
        }
    }
}
