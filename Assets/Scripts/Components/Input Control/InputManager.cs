using System;
using Unity.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RogueGo {
  [UpdateInGroup(typeof(EarlyPresentationSystemGroup))]
  public class InputManager : MonoBehaviour {
    Entity entity;
    EntityManager em;

    void OnEnable(){
      entity = gameObject.GetComponent<GameObjectEntity>().Entity;
      em = World.Active.EntityManager;
    }

    void Update () {
      GetJumpKey();
      GetMovementKey();
    }

    void GetJumpKey () {
      if (Input.GetButtonDown("Jump")) {
        em.AddComponent(entity, typeof(JumpKeyDown));
      } else if (Input.GetButton("Jump")) {
        em.AddComponent(entity, typeof(JumpKeyHeld));
      } else if (Input.GetButtonUp("Jump")) {
        em.AddComponent(entity, typeof(JumpKeyUp));
      }
    }

    void GetMovementKey(){
      if (Input.GetButtonDown("Movement")) {
        em.AddComponent(entity, typeof(MovementKeyDown));
      } else if (Input.GetButton("Movement")) {
        em.AddComponent(entity, typeof(MovementKeyHeld));
      } else if (Input.GetButtonUp("Movement")) {
        em.AddComponent(entity, typeof(MovementKeyUp));
      }
    }
  }
}