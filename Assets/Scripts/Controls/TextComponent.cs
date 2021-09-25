using UnityEngine.UI;

namespace Controls {
    public class TextComponent :StaticComponentControl<Text> {
        
        public override void SetValue(object value) {
            if (value == null) {
                return;
            }
            var str = value.ToString();
            Property.text = str;
        }
    }
}