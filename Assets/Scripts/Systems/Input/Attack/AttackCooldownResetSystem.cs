using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AttackCooldownResetSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackCounter),
        typeof(AttackCooldown)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((ref AttackCounter counter, ref AttackCooldown cooldown) => {
        if (cooldown.Value > 0)
          return;

        if (counter.Value == 0)
          return;

        counter.Value = 0;

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=yellow>{this.GetType()}</color> Attack Counter Reset");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}