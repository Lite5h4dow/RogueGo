using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateAfter(typeof(MainSimulationSystemGroup))]
  public class MovementReleaseSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(MovementInput)
      );
    }

    protected override void OnUpdate () {
      if (!Input.GetButtonUp("Movement"))
        return;

      Entities.With(player).ForEach((ref MovementInput moveInput) => {
        moveInput.Value = 0;
      });
    }
  }
}