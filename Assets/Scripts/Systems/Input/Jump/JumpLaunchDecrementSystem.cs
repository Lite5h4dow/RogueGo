using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class JumpLaunchDecrementSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpLaunch)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((ref JumpLaunch launch) => {
        launch.Value -= Time.fixedDeltaTime;
      });
    }
  }
}