using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AttackAirborneIncrementSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackInputPressed),
        ComponentType.Exclude(typeof(Grounded)),
        typeof(AirborneMaxAttackCount),
        typeof(AttackCounter)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Entity entity, ref AirborneMaxAttackCount amac, ref AttackCounter ac) => {
        PostUpdateCommands.RemoveComponent<AttackInputPressed>(entity);

        if (ac.Value >= amac.Value)
          return;

        ac.Value++;
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=yellow>{this.GetType()}</color> Attack Airborne Increment");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}