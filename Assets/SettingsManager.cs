using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {

    public static SettingsManager instance;

    [SerializeField] Button startButton;
    [SerializeField] List<ButtonLogic> buttons;

    private Color color = Color.white;

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private void Start() {
        buttons.ForEach(button => {
            if(button != null) {
                button.OnButtonPressed += ButtonLogic_OnButtonPressed;
            }
        });
    }

    private void ButtonLogic_OnButtonPressed(object sender, ButtonLogic.OnButtonPressedEventArgs e) {
        color = e.color;
        startButton.image.color = color;
    }

    public Color GetColor() {
        return color;
    }

    public void OnStartPress() {
        SceneManager.LoadScene("GameScene");
    }
}