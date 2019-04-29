using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class AirborneSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (Grounded),
        ComponentType.Exclude (typeof (CollidedWithGround))
      );
    }

    protected override void OnUpdate () {
      Entities.With (player).ForEach (entity => {
        PostUpdateCommands.RemoveComponent<Grounded> (entity);
        PostUpdateCommands.AddComponent<Airborne> (entity, new Airborne { });

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugGroundedState) {
          Debug.Log ($"<color=green>{this.GetType()}</color> Airborne");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */

      });
    }
  }
}