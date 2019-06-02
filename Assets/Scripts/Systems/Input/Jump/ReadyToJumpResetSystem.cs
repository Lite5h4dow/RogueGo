using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class ReadyToJumpResetSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Grounded),
        typeof(JumpEnd)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.RemoveComponent<JumpEnd>(entity);
        PostUpdateCommands.AddComponent<ReadyToJump>(entity, new ReadyToJump { });
      });
    }
  }
}