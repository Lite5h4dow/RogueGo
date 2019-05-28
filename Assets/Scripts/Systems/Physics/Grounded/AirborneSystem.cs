using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  [UpdateAfter(typeof(GroundedSystem))]
  public class AirborneSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        ComponentType.Exclude(typeof(CollidedWithGround)),
        typeof(Player),
        typeof(Grounded)
      );
    }

    protected override void OnUpdate () {
      EntityManager.RemoveComponent(player, typeof(Grounded));

      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
      if (Bootstrap.DeveloperSettings.DebugGroundedState) {
        Debug.Log($"<color=green>{this.GetType()}</color> Airborne");
      }
      /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
    }
  }
}