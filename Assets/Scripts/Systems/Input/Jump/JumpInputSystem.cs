using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(EarlyPresentationSystemGroup))]
  public class JumpInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpInput),
        typeof(LaunchDuration),
        typeof(ReadyToJump)
      );
    }

    protected override void OnUpdate () {
      // NOTE: just check directly in the systems, there are no performance difference anymore
      if (!Input.GetButtonDown("Jump"))
        return;

      Entities.With(player).ForEach((Entity entity, ref JumpInput jumpIn, ref LaunchDuration duration) => {
        PostUpdateCommands.RemoveComponent<ReadyToJump>(entity);
        PostUpdateCommands.AddComponent<JumpLaunch>(entity, new JumpLaunch { Value = duration.Value });
      });
    }
  }
}