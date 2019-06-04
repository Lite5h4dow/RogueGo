using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AttackCooldownSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackCooldown),
        typeof(MaxAttackCooldown)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((ref AttackCooldown cooldown, ref MaxAttackCooldown max) => {
        if (cooldown.Value <= 0)
          return;

        cooldown.Value -= Time.deltaTime;

        if (cooldown.Value < 0)
          cooldown.Value = 0;
      });
    }
  }
}