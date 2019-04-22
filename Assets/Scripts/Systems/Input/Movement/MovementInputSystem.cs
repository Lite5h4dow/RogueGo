using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class MovementInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (MovementInput)
      );
    }

    protected override void OnUpdate () {
      Entities.With (player).ForEach ((ref MovementInput moveInput) => {
        moveInput.Value = Input.GetAxis("Movement");
      });
    }
  }
}