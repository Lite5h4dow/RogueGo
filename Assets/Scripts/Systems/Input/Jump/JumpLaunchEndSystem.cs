using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class JumpLaunchEndSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpLaunch)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Entity entity, ref JumpLaunch launch) => {
        if (launch.Value > 0)
          return;

        PostUpdateCommands.RemoveComponent<JumpLaunch>(entity);
        PostUpdateCommands.AddComponent<JumpEnd>(entity, new JumpEnd { });

      });
    }
  }
}