using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class MovementInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(MovementInput),
        ComponentType.Exclude(typeof(Dodging))
      );
    }

    protected override void OnUpdate() {
      if (!Input.GetButton("Movement"))
        return;

      Entities.With(player).ForEach((ref MovementInput moveInput) => {
        moveInput.Value = Input.GetAxis("Movement");
      });
    }
  }
}