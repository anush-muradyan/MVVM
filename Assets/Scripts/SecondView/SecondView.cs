using System.Collections;
using Controls;
using UnityEngine;
using UnityEngine.UI;
using View;

namespace SecondView {
    public class SecondView : View<SecondViewModel, SecondModel> {
        [SerializeField] private TextComponent contentText;
        [SerializeField] private InputField inputField;
        [SerializeField] private Button button;

        public override void Bind() {
            base.Bind();
            Controls.Add(contentText);
        }

        protected override void OnEnable() {
            base.OnEnable();
            button.onClick.AddListener(onButtonClick);
        }

        protected override void OnDisable() {
            base.OnDisable();
            button.onClick.RemoveListener(onButtonClick);
        }

        private void onButtonClick() {
            ViewModel.UpdateContentCommand.Execute(inputField.text);
        }
    }
}