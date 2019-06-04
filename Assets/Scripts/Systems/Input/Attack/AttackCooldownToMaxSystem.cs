using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AttackCooldownToMaxSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackCooldown),
        typeof(MaxAttackCooldown),
        typeof(AttackInputPressed)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((ref AttackCooldown cooldown, ref MaxAttackCooldown max) => {
        cooldown.Value = max.Value;
      });
    }
  }
}