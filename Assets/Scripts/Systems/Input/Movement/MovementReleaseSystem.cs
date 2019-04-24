using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateBefore(typeof(CleanupGroup))]
  [UpdateAfter(typeof(InputManager))]
  public class MovementReleaseSystem : ComponentSystem {
    EntityQuery player;
    EntityQuery key;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (MovementInput)
      );

      key = GetEntityQuery (
        typeof(MovementKeyUp)
      );

      RequireForUpdate(player);
      RequireForUpdate(key);
    }

    protected override void OnUpdate () {
      Entities.With (player).ForEach ((ref MovementInput moveInput) => {
        moveInput.Value = 0;
      });
    }
  }
}