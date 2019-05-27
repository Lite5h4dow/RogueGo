using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(LateSimulationSystemGroup))]
  public class CollidedWithGroundCleanupSystem : ComponentSystem {
    EntityQuery collision;

    protected override void OnCreateManager () {
      collision = GetEntityQuery(
        typeof(CollidedWithGround)
      );
    }

    protected override void OnUpdate () {
      EntityManager.RemoveComponent(collision, typeof(CollidedWithGround));
    }
  }
}