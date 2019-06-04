using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeDirectionMonitorSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(MovementInput),
        typeof(DodgeDirection)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((ref MovementInput md, ref DodgeDirection dd) => {
        if (Mathf.Round(md.Value) == 0)
          return;

        dd.Value = (int)Mathf.Round(md.Value);
      });
    }
  }
}