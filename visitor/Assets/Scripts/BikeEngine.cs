using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Visitor
{
    public class BikeEngine : MonoBehaviour, IBikeElement
    {
        public float turboBoost = 25;
        public float maxTurboBoost = 200;

        public bool _isTurboOn;
        public float _defaultSpeed = 300f;

        public float CurrentSpeed
        {
            get
            {
                if (_isTurboOn)
                {
                    return _defaultSpeed = turboBoost;
                }
                return _defaultSpeed;
            }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void ToggleTurbo()
        {
            _isTurboOn = !_isTurboOn;
        }
        void OnGUI()
        {
            GUI.color = Color.green;

            GUI.Label(new Rect(125, 20, 200, 20),"Turbo Boost: " + turboBoost);
        }
    }
}
