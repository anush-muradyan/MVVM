using SecondView;
using UnityEngine;
using UnityEngine.UI;

namespace HomeView {
    class HomeView : MonoBehaviour {
        private void Start() {
            secondView.Init(new SecondModel());
            secondView.ViewModel.Init();
        }

        [SerializeField] private SecondView.SecondView secondView;
        [SerializeField] private Button startButton;
        [SerializeField] private Button quitButton;


        private void OnEnable() {
            startButton.onClick.AddListener(onGameStart);
            quitButton.onClick.AddListener(onQuitGame);
        }

        private void OnDisable() {
            startButton.onClick.RemoveListener(onGameStart);
            quitButton.onClick.RemoveListener(onQuitGame);
        }

        private void onGameStart() {
            secondView.gameObject.SetActive(true);
            transform.gameObject.SetActive(false);
        }

        private void onQuitGame() {
            Application.Quit();
        }
    }
}