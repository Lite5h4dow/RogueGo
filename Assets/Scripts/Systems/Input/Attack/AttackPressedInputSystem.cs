using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(EarlyPresentationSystemGroup))]
  public class AttackPressedInputSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(CanUnequip)
      );
    }

    protected override void OnUpdate() {
      if (!Input.GetButtonDown("Attack"))
        return;

      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.AddComponent<AttackInputPressed>(entity, new AttackInputPressed {});
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=yellow>{this.GetType()}</color> Attack Key Pressed");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}