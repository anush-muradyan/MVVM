using System;
using UnityEngine;

namespace Controls {
    [Serializable]
    public abstract class ComponentControl : MonoBehaviour {
        public abstract void SetValue(object value);
    }

    [Serializable]
    public abstract class ComponentControl<T> : ComponentControl {
        [SerializeField] private T property;

        public T Property
        {
            get => property;

            set => property = value;
        }
    }

    [Serializable]
    public abstract class StaticComponentControl : ComponentControl {
        [SerializeField] private string propertyName;
        public string PropertyName => propertyName;
    }

    [Serializable]
    public abstract class StaticComponentControl<T> : StaticComponentControl {
        [SerializeField] private T property;

        public T Property => property;
    }
}