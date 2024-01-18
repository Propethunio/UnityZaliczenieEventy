using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour {

    [SerializeField] Color color;

    public event EventHandler<OnButtonPressedEventArgs> OnButtonPressed;
    public class OnButtonPressedEventArgs : EventArgs {
        public Color color;
    }

    private void Start() {
        color = gameObject.GetComponent<Image>().color;
    }

    public void OnPress() {
        OnButtonPressed?.Invoke(this, new OnButtonPressedEventArgs { color = color });
    }
}