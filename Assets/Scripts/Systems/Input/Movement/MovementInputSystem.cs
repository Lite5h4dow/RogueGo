using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class MovementInputSystem : ComponentSystem {
    EntityQuery player;
    EntityQuery key;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (MovementInput)
      );

      key = GetEntityQuery (
        typeof(MovementKeyHeld)
      );

      RequireForUpdate(player);
      RequireForUpdate(key);
    }

    protected override void OnUpdate () {
      Entities.With (player).ForEach ((ref MovementInput moveInput) => {
        moveInput.Value = Input.GetAxis("Movement");
      });
    }
  }
}