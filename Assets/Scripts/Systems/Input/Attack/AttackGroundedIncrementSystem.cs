using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AttackGroundedIncrementSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackInputPressed),
        typeof(CollidedWithGround),
        typeof(GroundedMaxAttackCount),
        typeof(AttackCounter)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Entity entity, ref GroundedMaxAttackCount gmac, ref AttackCounter ac) => {
        PostUpdateCommands.RemoveComponent<AttackInputPressed>(entity);

        if (ac.Value >= gmac.Value)
          return;

        ac.Value++;
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugDodgeState) {
          Debug.Log($"<color=yellow>{this.GetType()}</color> Attack Grounded Increment");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      });
    }
  }
}