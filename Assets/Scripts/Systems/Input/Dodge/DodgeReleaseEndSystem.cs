using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeReleaseEndSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Dodging)
      );
    }

    protected override void OnUpdate() {
      if (Input.GetButton("Dodge"))
        return;

      PostUpdateCommands.RemoveComponent<Dodging>(player.GetSingletonEntity());
      PostUpdateCommands.AddComponent<ReadyToDodge>(player.GetSingletonEntity(), new ReadyToDodge { Value = 0 });

      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      if (Bootstrap.DeveloperSettings.DebugDodgeState) {
        Debug.Log($"<color=blue>{this.GetType()}</color> Dodge Release End");
      }
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
    }
  }
}