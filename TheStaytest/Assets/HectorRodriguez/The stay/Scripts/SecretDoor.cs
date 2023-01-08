using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class SecretDoor : MonoBehaviour
    {
            public string anima;

        private SecretDoorLever _lever;

        private void Start()
        {
            _lever = GameObject.FindGameObjectWithTag("SecretDoorSlide").GetComponent<SecretDoorLever>();

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _lever.ChangeAnimationState(anima);
            }
        }
    }
