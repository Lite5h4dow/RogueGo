using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeTimerEndSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Dodging)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Entity entity, ref Dodging dodge) => {
        if (dodge.Value > 0)
          return;

        PostUpdateCommands.RemoveComponent<Dodging>(entity);
        PostUpdateCommands.AddComponent<ReadyToDodge>(entity, new ReadyToDodge { Value = 0 });

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=blue>{this.GetType()}</color> Dodge Timer End");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}